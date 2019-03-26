using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace library_032519
{
    public class DBManager
    {
        private string _connectionString;

        public DBManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Person> GetPeople()
        {
            SqlConnection
        }
    }
}
