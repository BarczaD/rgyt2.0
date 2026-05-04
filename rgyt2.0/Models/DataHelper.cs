using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace rgyt2._0.Models
{
    public class DataHelper
    {
        public static DateOnly? ParseDbfDate(object? value)
        {
            if (value == null)
                return null;

            // Ha már DateOnly
            if (value is DateOnly d)
                return d;

            // Ha DateTime
            if (value is DateTime dt)
                return DateOnly.FromDateTime(dt);

            var s = value.ToString()?.Trim();
            if (string.IsNullOrEmpty(s))
                return null;

            string[] formats =
            {
                "yy/MM/dd",
                "yyyy/MM/dd",
                "yyyy-MM-dd",
                "yyyy.MM.dd",
                "MM/dd/yyyy",
                "M/d/yyyy",
                "MM/dd/yyyy HH:mm:ss",
                "M/d/yyyy HH:mm:ss"
            };

            if (DateTime.TryParseExact(
                    s,
                    formats,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out var parsed))
            {
                return DateOnly.FromDateTime(parsed);
            }

            if (DateTime.TryParse(
                    s,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out parsed))
            {
                return DateOnly.FromDateTime(parsed);
            }

            // nincs használható dátum
            return null;
        }
    }
}
