using System;
using System.Collections.Generic;
using System.Text;

namespace rgyt2._0.Models
{

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

    }

}
