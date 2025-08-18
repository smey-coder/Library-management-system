using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    
    internal class Database
    {
        
        private readonly string connectionString = "Data Source=DESKTOP-3MCTVIH;Persist Security Info=True;User ID=sa;Initial Catalog=Library management system;Password=hello";

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    Console.WriteLine("Database connection successful!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection failed: " + ex.Message);
                return false;
            }
        }

    }
}
