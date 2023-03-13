using System;
using System.Data.SqlClient;

namespace ZadSQLZad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft SQL Server");
            Console.WriteLine(new string('-',25));
            SqlConnection dbConn = new SqlConnection
                (
                  "Server =.;Database=master;Intergrated Security=true"

                );
            dbConn.Open();

            using (dbConn)
            {
                SqlCommand command1 = new SqlCommand
                    (
                    "CREATE DATABASE Minions", dbConn
                    );
                command1.ExecuteNonQuery();
            }
        }
    }
}
