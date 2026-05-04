using System;
using System.Collections.Generic;
using System.Text;

namespace rgyt2._0.Models.Configuration
{
    public class AppConfig
    {
        public DatabaseConfig Database { get; set; } = new();
    }
}
