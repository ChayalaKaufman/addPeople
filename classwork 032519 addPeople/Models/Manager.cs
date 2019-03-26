using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace classwork_032519_addPeople.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
    }

    public class Manager
    {
        private string _connectionString;

        public Manager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Person> GetPeople()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM People";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Person> ppl = new List<Person>();
            while (reader.Read())
            {
                ppl.Add(new Person
                {
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Age = (int)reader["Age"],
                    Id = (int)reader["Id"]
                });
            }

            return ppl;
        }

        public void Add(List<Person> ppl)
        {
            foreach (Person p in ppl)
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO People VALUES (@firstName,@lastName,@age)";
                cmd.Parameters.AddWithValue("@firstName", p.FirstName);
                cmd.Parameters.AddWithValue("@lastName", p.LastName);
                cmd.Parameters.AddWithValue("@age", p.Age);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
            }
        }

    }
}