using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-03
*/

namespace DogShowTrackerCL
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        
        /// <summary>
        /// Gets the data from the database 
        /// using the sql string and return with a DataTable
        /// </summary>
        /// <param name="sql">The sql string to querry with</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
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
        /// Gets the data from the database
        /// using the sql string and return an object
        /// form the first row and column returned
        /// </summary>
        /// <param name="sql">The sql string to querry with</param>
        /// <returns></returns>
        public static object ExecuteScaler(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                return cmd.ExecuteScalar();
            }
        }

        public static int SendData(string sql)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }

            return rowAffected;
        }

        /// <summary>
        /// Returns the first row returned from the database
        /// when querried using the sql string provided
        /// </summary>
        /// <param name="sql">The sql string to querry with</param>
        /// <returns></returns>
        public static DataRow GetDataRow(string sql)
        {
           return GetDataTable(sql).Rows[0];
        }
    }
}
