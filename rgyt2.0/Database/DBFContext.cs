using DbfDataReader;
using rgyt2._0;
using rgyt2._0.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

public class DbfContext
{
    private readonly string _basePath;

    private List<Child>? _children;   // gyfix
    private List<Parent>? _parents;   // szfix
    private List<Institution>? _institutions;

    public DbfContext(string basePath)
    {
        _basePath = basePath;
    }


    public IReadOnlyList<Child> GetChildren()
    {
        if (_children == null)
            LoadChildren();


        return _children!
            .Where(c =>
                c.Szuloazon != 0 &&
                !string.IsNullOrWhiteSpace(c.Gyereknev) &&
                c.Gyereknev != "*"
            )
            .ToList();

    }

    public IReadOnlyList<Parent> GetParents()
    {
        if (_parents == null)
            LoadParents();


        return _parents!
            .Where(p =>
                p.Szuloazon != 0 &&
                !string.IsNullOrWhiteSpace(p.Szulonev) &&
                p.Szulonev != "*"
            )
            .ToList();

    }

    public IReadOnlyList<Institution> GetInstitutions()
    {
        if (_institutions == null)
            LoadInstitutions();

        return _institutions!;
    }

    private static int ParseInt(object? value)
    {
        if (value == null || value == DBNull.Value)
            return 0;

        return value switch
        {
            int i => i,
            short sh => sh,
            long l => (int)l,
            decimal d => (int)d,
            double db => (int)db,
            float f => (int)f,
            string s when int.TryParse(s.Trim(), out var r) => r,
            string s when decimal.TryParse(
                s.Trim(),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out var dr) => (int)dr,
            _ => 0
        };
    }

    private static short ParseShort(object? value)
    {
        if (value == null || value == DBNull.Value)
            return 0;

        return value switch
        {
            short s => s,
            int i => (short)Math.Clamp(i, short.MinValue, short.MaxValue),
            long l => (short)Math.Clamp(l, short.MinValue, short.MaxValue),
            string s when short.TryParse(s, out var r) => r,
            _ => 0
        };
    }


    private static object? Get(
    Dictionary<string, object?> map,
    string key
    )
    {
        return map.TryGetValue(key, out var value)
            ? value
            : null;
    }

    private static string ParseString(object value)
    {
        if (value == null || value == DBNull.Value)
            return string.Empty;

        return value.ToString() ?? string.Empty;
    }

    private static DateOnly ParseDbfDate(object? value)
    {
        if (value == null)
            return default;

        var s = value.ToString()?.Trim();
        if (string.IsNullOrEmpty(s))
            return default;

        if (DateOnly.TryParseExact(
                s,
                "yy/MM/dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var date))
        {
            return date;
        }

        return default;
    }


    private void LoadChildren()
    {
        _children = new List<Child>();

        var path = Path.Combine(
            Program.Config.Settings.Database.DbfFolder,
            "gyfix.dbf"
        );

        if (!File.Exists(path))
        {
            MessageBox.Show(
                $"A gyerek DBF nem található:\n{path}",
                "DBF hiba",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return;
        }

        try
        {
            using var reader = new DbfDataReader.DbfDataReader(path);

            var columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                columns.Add(reader.GetName(i).Trim());
            }



            if (_institutions == null)
                LoadInstitutions();

            var institutionLookup = _institutions!
                .Where(i => i.Id != 0)
                .GroupBy(i => i.Id)
                .ToDictionary(g => g.Key, g => g.First().Name);



            int rowIndex = 0;


            while (reader.Read())
            {
                try
                {
                    var map = new Dictionary<string, object?>(
                        StringComparer.OrdinalIgnoreCase
                    );

                    for (int i = 0; i < columns.Count; i++)
                        map[columns[i]] = reader.GetValue(i);

                    var intezmenyId = ParseInt(Get(map, "INTEZMENY"));

                    var intezmenyNev = institutionLookup.TryGetValue(intezmenyId, out var nev)
                        ? nev
                        : "Hiányzó adat";

                    var child = new Child(
                        ParseInt(Get(map, "GYEREKID")),
                        ParseInt(Get(map, "SZULOAZON")),
                        ParseString(Get(map, "GYEREKNEV")),
                        ParseInt(Get(map, "IRSZ")),
                        ParseString(Get(map, "UTCA")),
                        ParseString(Get(map, "HSZ")),
                        ParseInt(Get(map, "TAJSZAM")),
                        ParseString(Get(map, "SZULIDO")),
                        ParseString(Get(map, "ANYJANEVE")),
                        intezmenyNev,
                        ParseInt(Get(map, "GYEREKTIPUS")),
                        ParseInt(Get(map, "OSSZEG")),
                        ParseInt(Get(map, "SZAMLASZAM")),
                        ParseInt(Get(map, "HH")),
                        ParseInt(Get(map, "HHJOG1")),
                        ParseInt(Get(map, "HHJOG2")),
                        ParseInt(Get(map, "HHJOG3")),
                        ParseString(Get(map, "JOGDATUM"))
                    );

                    if (child.Szuloazon == 0)
                        continue;

                    if (string.IsNullOrWhiteSpace(child.Gyereknev))
                        continue;

                    _children.Add(child);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"HIBA a gyerek DBF-ben!\n\n" +
                        $"Rekord index: {rowIndex}\n\n" +
                        $"{ex.GetType().Name}\n{ex.Message}",
                        "DBF rekord hiba",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    break;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"DBF betöltési hiba gyerek.dbf:\n\n{ex.GetType().Name}\n{ex.Message}",
                "DBF hiba",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }


    private void LoadParents()
    {
        _parents = new List<Parent>();

        var path = Path.Combine(
            Program.Config.Settings.Database.DbfFolder,
            "szfix.dbf"
        );

        if (!File.Exists(path))
        {
            MessageBox.Show(
                $"A szülők DBF nem található:\n{path}",
                "DBF hiba",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return;
        }

        try
        {
            using var reader = new DbfDataReader.DbfDataReader(path);

            var columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                columns.Add(reader.GetName(i).Trim());
            }

            var sbFields = new StringBuilder();
            sbFields.AppendLine("SZULOK.DBF mezők:");
            for (int i = 0; i < columns.Count; i++)
                sbFields.AppendLine($"{i}: {columns[i]}");

            Debug.WriteLine(sbFields.ToString());

            int rowIndex = 0;

            while (reader.Read())
            {

                try
                {
                    var map = new Dictionary<string, object?>(
                        StringComparer.OrdinalIgnoreCase
                    );

                    for (int i = 0; i < columns.Count; i++)
                        map[columns[i]] = reader.GetValue(i);

                    var parent = new Parent(
                        ParseInt(Get(map, "SZULOAZON")),
                        ParseInt(Get(map, "MANKOAZON")),
                        ParseString(Get(map, "SZULONEV")),
                        ParseInt(Get(map, "IRSZ")),
                        ParseString(Get(map, "UTCA")),
                        ParseString(Get(map, "HSZ")),
                        ParseInt(Get(map, "TAJSZAM")),
                        ParseString(Get(map, "ANYJANEVE")),
                        ParseString(Get(map, "LEANYKORIN")),
                        ParseString(Get(map, "SZULIDO")),
                        ParseInt(Get(map, "SZULOTIPUS")),
                        ParseInt(Get(map, "OSSZEG")),
                        ParseInt(Get(map, "IKTATOSZAM")),
                        ParseInt(Get(map, "SZAMLASZAM")),
                        ParseShort(Get(map, "EGYEDULNEV")),
                        ParseInt(Get(map, "INTEZMENY")),
                        ParseString(Get(map, "FELULVIZSG")),
                        ParseInt(Get(map, "EGYFOREJUT")),
                        ParseShort(Get(map, "HH")),
                        ParseShort(Get(map, "HHJOG1")),
                        ParseShort(Get(map, "HHJOG2")),
                        ParseShort(Get(map, "HHJOG3"))
                    );

                    _parents.Add(parent);
                    rowIndex++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"HIBA a szülő DBF-ben!\n\n" +
                        $"Rekord index: {rowIndex}\n\n" +
                        $"{ex.GetType().Name}\n{ex.Message}",
                        "DBF rekord hiba",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
                }
            };
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"DBF betöltési hiba (szülők):\n\n{ex.GetType().Name}\n{ex.Message}",
                "DBF hiba",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
    private void LoadInstitutions()
    {
        _institutions = new List<Institution>();

        var path = Path.Combine(
            Program.Config.Settings.Database.DbfFolder,
            "intezmeny.dbf"
        );

        if (!File.Exists(path))
        {
            MessageBox.Show(
                $"Az intézmény DBF nem található:\n{path}",
                "DBF hiba",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return;
        }

        using var reader = new DbfDataReader.DbfDataReader(path);

        var columns = new List<string>();
        for (int i = 0; i < reader.FieldCount; i++)
            columns.Add(reader.GetName(i).Trim());

        while (reader.Read())
        {
            var map = new Dictionary<string, object?>(
                StringComparer.OrdinalIgnoreCase
            );

            for (int i = 0; i < columns.Count; i++)
                map[columns[i]] = reader.GetValue(i);

            var institution = new Institution
            {
                Id = ParseInt(Get(map, "INTEZMENYA")),
                Name = ParseString(Get(map, "INTEZMENYN"))
            };

            if (institution.Id == 0)
                continue;

            if (string.IsNullOrWhiteSpace(institution.Name))
                continue;

            _institutions.Add(institution);
        }
    }

}