using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTrackerCL
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        /// <summary>
        /// Gets the data from the database 
        /// using the SQL string and return with a DataTable
        /// </summary>
        /// <param name="sql">The SQL string to querry with</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            sql = SQLStringCleaner(sql);
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
        /// using the SQL string and return an object
        /// form the first row and column returned
        /// </summary>
        /// <param name="sql">The SQL string to querry with</param>
        /// <returns></returns>
        public static object ExecuteScaler(string sql)
        {
            sql = SQLStringCleaner(sql);
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
            sql = SQLStringCleaner(sql);
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
        /// when queried using the SQL string provided
        /// </summary>
        /// <param name="sql">The SQL string to querry with</param>
        /// <returns></returns>
        public static DataRow GetDataRow(string sql)
        {
            sql = SQLStringCleaner(sql);
            return GetDataTable(sql).Rows[0];
        }

        /// <summary>
        /// Removes all extra spaces and new lines from a SQL string
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string SQLStringCleaner(string sql)
        {
            sql.Trim();
            sql = sql.Replace("\t", " ");
            while (sql.Contains("  ")) sql = sql.Replace("  ", " ");
            return sql.Replace(Environment.NewLine, "");
        }

        /// <summary>
        /// Trims user input and fixes and escapes
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SanitizeUserInput(string str)
        {
            return str.Trim().Replace("'", "''");
        }

        /// <summary>
        /// Checks if any records exist where the fieldsToCheck is 
        /// equal to the valueToCheck in the tableToCheck
        /// </summary>
        /// <param name="fieldsToCheck">The field(s) to check it it is equal to the value</param>
        /// <param name="valueToCheck">The value to check for</param>
        /// <param name="tableToCheck">The table to check in</param>
        /// <returns></returns>
        public static bool ValueExists(string fieldsToCheck, string valueToCheck, string tableToCheck)
        {
            return 0 != Convert.ToInt32(ExecuteScaler($"SELECT COUNT(*) FROM {tableToCheck} WHERE {fieldsToCheck} = {valueToCheck}"));
        }

        public static bool ValueChanged(string fieldToCheck, string valueToCheck, string tableToCheck, string idColumn, string id)
        {

            return 0 == Convert.ToInt32(ExecuteScaler($"SELECT COUNT(*) FROM {tableToCheck} WHERE {idColumn} = {id} AND {fieldToCheck} = {valueToCheck}"));
        }
    }
}
