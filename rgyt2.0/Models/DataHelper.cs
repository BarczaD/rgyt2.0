using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace rgyt2._0.Models
{
    public class DataHelper
    {
        public static DateOnly? ParseDbfDate(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            var s = value.Trim();

            string[] formats =
            {
                "dd/MM/yy",
                "d/M/yy",
                "dd/MM/yyyy",
                "d/M/yyyy",
                "yyyy.MM.dd",
                "yyyy-MM-dd",
                "yyyy/MM/dd"
            };

            if (DateOnly.TryParseExact(
                    s,
                    formats,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out var date))
            {
                return date;
            }

            if (DateTime.TryParse(s, out var dt))
                return DateOnly.FromDateTime(dt);

            return null;
        }
    }
}
