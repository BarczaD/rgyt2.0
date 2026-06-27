using ClosedXML.Excel;
using System.Data;

namespace rgyt2._0.Forms
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void hQueryBtn_Click(object sender, EventArgs e)
        {
            var query =
                Program.DbfContext.GetChildren()
                    .Join(
                        Program.DbfContext.GetParents(),
                        gy => gy.Szuloazon,
                        sz => sz.Szuloazon,
                        (gy, sz) => new { gy, sz }
                    )
                    .Where(x => x.gy.Hh > 1)
                    .Where(x => x.sz.Szulotipus == 1);

            if (TryParseYearInterval(yearIntervalTextBox.Text, out int fromYear, out int toYear))
            {
                query = query.Where(x =>
                    x.gy.Szulido.HasValue &&
                    x.gy.Szulido.Value.Year >= fromYear &&
                    x.gy.Szulido.Value.Year <= toYear
                );
            }

            var queryResult = query
                .Select((x, index) => new
                {
                    Sorszám = index + 1,
                    Gyerek = x.gy.Gyereknev,
                    SzületésiIdő = x.gy.Szulido.HasValue
                        ? x.gy.Szulido.Value.ToString("yyyy.MM.dd")
                        : "",
                    Intézmény = x.gy.IntezmenyNev,
                    Szülő = x.sz.Szulonev,
                    Lakcím = $"{x.gy.Irsz} {x.gy.Utca} {x.gy.Hsz}",
                    HH = x.gy.Hh,
                    FelülvizsgálatDátuma = FormatDate(x.gy.Jogdatum),
                })
                .ToList();

            queryResultGridView.DataSource = queryResult;
        }


        private string FormatDate(DateOnly? date)
        {
            return date.HasValue
                ? date.Value.ToString("yyyy.MM.dd")
                : "";
        }

        private void rgykQueryBtn_Click(object sender, EventArgs e)
        {
            var query =
                Program.DbfContext.GetChildren()
                    .Join(
                        Program.DbfContext.GetParents(),
                        gy => gy.Szuloazon,
                        sz => sz.Szuloazon,
                        (gy, sz) => new { gy, sz }
                    )
                    .Where(x => x.gy.Hh == 1)
                    .Where(x => x.sz.Szulotipus == 1);

            if (TryParseYearInterval(yearIntervalTextBox.Text, out int fromYear, out int toYear))
            {
                query = query.Where(x =>
                    x.gy.Szulido.HasValue &&
                    x.gy.Szulido.Value.Year >= fromYear &&
                    x.gy.Szulido.Value.Year <= toYear
                );
            }

            var queryResult = query
                .Select((x, index) => new
                {
                    Sorszám = index + 1,
                    Gyerek = x.gy.Gyereknev,
                    SzületésiIdő = x.gy.Szulido.HasValue
                        ? x.gy.Szulido.Value.ToString("yyyy.MM.dd")
                        : "",
                    Szülő = x.sz.Szulonev,
                    Lakcím = $"{x.gy.Irsz} {x.gy.Utca} {x.gy.Hsz}",
                    HH = x.gy.Hh,
                    FelülvizsgálatDátuma = FormatDate(x.sz.Felulvizsg)
                })
                .ToList();

            queryResultGridView.DataSource = queryResult;
        }


        private void hChildSumQueryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var payout = int.Parse(payoutPerChildTextField.Text);

                var query =
                    Program.DbfContext.GetChildren()
                        .Join(
                            Program.DbfContext.GetParents(),
                            gy => gy.Szuloazon,
                            sz => sz.Szuloazon,
                            (gy, sz) => new { gy, sz }
                        )
                        .Where(x => x.gy.Hh > 1)
                        .Where(x => x.sz.Szulotipus == 1);

                if (TryParseYearInterval(yearIntervalTextBox.Text, out int fromYear, out int toYear))
                {
                    query = query.Where(x =>
                        x.gy.Szulido.HasValue &&
                        x.gy.Szulido.Value.Year >= fromYear &&
                        x.gy.Szulido.Value.Year <= toYear
                    );
                }

                var queryResult = query
                    .GroupBy(x => new
                    {
                        x.sz.Szuloazon,
                        x.sz.Szulonev,
                        x.sz.Utca,
                        x.sz.Hsz
                    })
                    .Select((g, index) => new
                    {
                        Sorszám = index + 1,
                        Szülő = g.Key.Szulonev,
                        Lakcím = $"{g.Key.Utca} {g.Key.Hsz}",
                        Gyerekszám = g.Count(),
                        KifizetésÖsszege = g.Count() * payout
                    })
                    .ToList();

                queryResultGridView.DataSource = queryResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kérlek ellenőrizd, hogy helyesen adtad-e meg a kifizetési összeget!");
                return;
            }
        }

        private void rgykChildSumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var payout = int.Parse(payoutPerChildTextField.Text);

                var query =
                    Program.DbfContext.GetChildren()
                        .Join(
                            Program.DbfContext.GetParents(),
                            gy => gy.Szuloazon,
                            sz => sz.Szuloazon,
                            (gy, sz) => new { gy, sz }
                        )
                        .Where(x => x.gy.Hh == 1)
                        .Where(x => x.sz.Szulotipus == 1);

                if (TryParseYearInterval(yearIntervalTextBox.Text, out int fromYear, out int toYear))
                {
                    query = query.Where(x =>
                        x.gy.Szulido.HasValue &&
                        x.gy.Szulido.Value.Year >= fromYear &&
                        x.gy.Szulido.Value.Year <= toYear
                    );
                }

                var queryResult = query
                    .GroupBy(x => new
                    {
                        x.sz.Szuloazon,
                        x.sz.Szulonev,
                        x.sz.Utca,
                        x.sz.Hsz
                    })
                    .Select((g, index) => new
                    {
                        Sorszám = index + 1,
                        Szülő = g.Key.Szulonev,
                        Lakcím = $"{g.Key.Utca} {g.Key.Hsz}",
                        Gyerekszám = g.Count(),
                        KifizetésÖsszege = g.Count() * payout
                    })
                    .ToList();

                queryResultGridView.DataSource = queryResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kérlek ellenőrizd, hogy helyesen adtad-e meg a kifizetési összeget!");
                return;
            }
        }

        private void adultChildQueryBtn_Click(object sender, EventArgs e)
        {

            var queryResult =
                    Program.DbfContext.GetParents()
                        .Where(sz => sz.Szulotipus == 2)
                        .Select((sz, index) => new
                        {
                            Sorszám = index + 1,
                            Szülő = sz.Szulonev,
                            Lakcím = $"{sz.Utca} {sz.Hsz}",
                            HH = sz.Hh
                        })
                        .ToList();

            queryResultGridView.DataSource = queryResult;
        }

        private bool TryParseYearInterval(string input, out int fromYear, out int toYear)
        {
            fromYear = 0;
            toYear = 0;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            var parts = input
                .Split('-', StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();

            if (parts.Length != 2)
                return false;

            if (!int.TryParse(parts[0], out fromYear))
                return false;

            if (!int.TryParse(parts[1], out toYear))
                return false;

            if (fromYear > toYear)
            {
                var temp = fromYear;
                fromYear = toYear;
                toYear = temp;
            }

            return true;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {


            if (queryResultGridView.DataSource == null || queryResultGridView.Rows.Count == 0)
            {
                MessageBox.Show("Nincs exportálható adat.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "Excel fájl (*.xlsx)|*.xlsx",
                Title = "Excel exportálás",
                FileName = "export.xlsx",
                DefaultExt = "xlsx",
                AddExtension = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToExcel(queryResultGridView, sfd.FileName);
                MessageBox.Show("Excel export elkészült.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private static void ExportDataGridViewToExcel(DataGridView grid, string filePath)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Adatok");

            int colIndex = 1;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (!col.Visible) continue;

                worksheet.Cell(1, colIndex).Value = col.HeaderText;
                worksheet.Cell(1, colIndex).Style.Font.Bold = true;
                colIndex++;
            }

            int rowIndex = 2;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                colIndex = 1;

                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (!col.Visible) continue;

                    var value = row.Cells[col.Index].Value;


                    worksheet.Cell(rowIndex, colIndex)
                             .SetValue(value?.ToString() ?? "");

                    colIndex++;
                }

                rowIndex++;
            }

            worksheet.Columns().AdjustToContents();
            workbook.SaveAs(filePath);
        }

        private void resultClearBtn_Click(object sender, EventArgs e)
        {
            queryResultGridView.DataSource = null;
            queryResultGridView.Rows.Clear();

            payoutPerChildTextField.Text = "Kifizetés összege";
            yearIntervalTextBox.Text = "Születési év (pl. 2012 - 2020)";

        }
    }
}
