using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DbConnection
    {
        private static SqlConnection _connection; // Single instance
        private static readonly object _lock = new object(); // Thread safety

        private DbConnection() { }

        public static SqlConnection GetConnection()
        {
            // If connection is not created or closed, initialize it
            if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
            {
                lock (_lock) // Ensure thread safety
                {
                    if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
                    {
                        string connectionString = @"Data Source=SOHAIB-IKRAM\SQLEXPRESS;Initial Catalog=C:\USERS\HUZAI\ONEDRIVE\DOCUMENTS\BOOKSHOPDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

                        _connection = new SqlConnection(connectionString);
                        _connection.Open(); // Open the connection once
                    }
                }
            }
            return _connection; // Return the single instance
        }
    }
}
