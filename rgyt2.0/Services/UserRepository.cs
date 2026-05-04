using rgyt2._0.Database;
using rgyt2._0.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rgyt2._0.Services
{


    public class UserRepository
    {
        private readonly SQLiteDbContext _db;

        public UserRepository(SQLiteDbContext db)
        {
            _db = db;
        }

        public List<User> GetAll()
        {
            var users = new List<User>();

            using var conn = _db.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = """
                SELECT Id, Username, IsAdmin, IsActive
                FROM Users
                ORDER BY Username
            """;

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    IsAdmin = reader.GetInt32(2) == 1,
                    IsActive = reader.GetInt32(3) == 1
                });
            }

            return users;
        }

        public void CreateUser(string username, string password, bool isAdmin, bool isActive)
        {
            using var conn = _db.CreateConnection();
            conn.Open();

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            using var cmd = conn.CreateCommand();
            cmd.CommandText = """
                INSERT INTO Users (Username, PasswordHash, IsAdmin, IsActive)
                VALUES (@username, @passwordHash, @isAdmin, @isActive)
            """;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
            cmd.Parameters.AddWithValue("@isAdmin", isAdmin ? 1 : 0);
            cmd.Parameters.AddWithValue("@isActive", isActive ? 1 : 0);

            cmd.ExecuteNonQuery();
        }

        public void UpdateFlags(int userId, bool isAdmin, bool isActive)
        {
            using var conn = _db.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = """
                UPDATE Users
                SET IsAdmin = @isAdmin,
                    IsActive = @isActive
                WHERE Id = @id
            """;

            cmd.Parameters.AddWithValue("@isAdmin", isAdmin ? 1 : 0);
            cmd.Parameters.AddWithValue("@isActive", isActive ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", userId);

            cmd.ExecuteNonQuery();
        }
    }
}
