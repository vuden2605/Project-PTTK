using System;
using System.Data;
using System.Data.SqlClient;

namespace Project_PTTK
{
    public static class DBHelper
    {
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=QuanLyChungChi;User Id=sa;Password=;";

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
    }
}
