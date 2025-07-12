using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace Project_PTTK
{
    public static class DBHelper
    {
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=QuanLyChungChi;User Id=sa;Password=;TrustServerCertificate=True;";
        private static string masterConnectionString = @"Server=.\SQLEXPRESS;Database=master;User Id=sa;Password=;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public static int ExecuteNonQuery(string query, SqlParameter[]? parameters)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
        public static object ExecuteScalar(string query, SqlParameter[]? parameters)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            conn.Open();
            return cmd.ExecuteScalar() ?? DBNull.Value;
        }

        public static void RunBatch(string sqlFilePath)
        {
            // Read the SQL script
            string script = File.ReadAllText(sqlFilePath);

            // Split script by "GO" (case-insensitive, on its own line)
            var batches = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            // Execute each batch
            using SqlConnection conn = new SqlConnection(masterConnectionString);
            conn.Open();
            foreach (var batch in batches)
            {
                string trimmedBatch = batch.Trim();
                if (!string.IsNullOrEmpty(trimmedBatch))
                {
                    using SqlCommand cmd = new SqlCommand(trimmedBatch, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}