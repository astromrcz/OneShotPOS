using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace OneShotPOS
{
    internal class LoadDatabase
    {
        private readonly string _connectionString;

        // Constructor: point to your OneShotDB file
        public LoadDatabase(string dbPath)
        {
            _connectionString = $"Data Source={dbPath};Version=3;";
        }

        // Generic method to load data into a DataTable
        public DataTable LoadData(string query)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        // Example: Load Users into a list of objects
        public List<User> LoadUsers()
        {
            var users = new List<User>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Username, FirstName, LastName, Age, ContactNumber FROM Users";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Username = reader["Username"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            ContactNumber = reader["ContactNumber"].ToString()
                        });
                    }
                }
            }

            return users;
        }
    }

    // Example User model (you can expand for Products, Customers, etc.)
    internal class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ContactNumber { get; set; }
    }
}
