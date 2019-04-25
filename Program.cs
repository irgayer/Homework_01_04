using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["appConnection"].ConnectionString;
            using(var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(@"CREATE TABLE [group]([id] [int] IDENTITY(1,1) PRIMARY KEY, name NVARCHAR(max) NOT NULL)", connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
