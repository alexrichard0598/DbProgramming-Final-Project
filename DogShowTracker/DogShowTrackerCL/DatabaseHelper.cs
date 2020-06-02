using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogShowTrackerCL
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        /// <summary>
        /// Gets the data from the MusicDB database 
        /// using the sql string and return with a DataTable
        /// </summary>
        /// <param name="sql">The sql string to querry with</param>
        /// <returns></returns>
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);
            }

            return dt;
        }

        /// <summary>
        /// Gets the data from the Music DB database
        /// using the sql string and return an object
        /// form the first row and column returned
        /// </summary>
        /// <param name="sql">The sql string to querry with</param>
        /// <returns></returns>
        public static object ExecuteScaler(string sql)
        {
            object obj;
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                obj = cmd.ExecuteScalar();
            }

            return obj;
        }
    }
}
