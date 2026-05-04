using BCrypt.Net;
using DocumentFormat.OpenXml.Math;
using rgyt2._0.Database;
using rgyt2._0.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rgyt2._0.Services
{


    public class AuthService
    {
        private readonly SQLiteDbContext _db;

        public AuthService(SQLiteDbContext db)
        {
            _db = db;
        }

        public User? Login(string username, string password, out string error)
        {
            error = "";

            using var conn = _db.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = """
                SELECT Id, Username, PasswordHash, IsAdmin, IsActive
                FROM Users
                WHERE Username = @username
            """;

            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                error = "Hibás felhasználónév vagy jelszó.";
                return null;
            }

            int id = reader.GetInt32(0);
            string dbUsername = reader.GetString(1);
            string passwordHash = reader.GetString(2);
            bool isAdmin = reader.GetInt32(3) == 1;
            bool isActive = reader.GetInt32(4) == 1;


            if (!BCrypt.Net.BCrypt.Verify(password, passwordHash))
            {
                error = "Hibás felhasználónév vagy jelszó.";
                return null;
            }

            if (!isActive)
            {
                error = "Inaktív felhasználó.";
                return null;
            }

            return new User
            {
                Id = id,
                Username = dbUsername,
                IsAdmin = isAdmin,
                IsActive = isActive
            };
        }
    }

}
