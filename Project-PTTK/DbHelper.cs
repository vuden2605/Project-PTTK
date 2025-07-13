using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace Project_PTTK
{
    public static class DBHelper
    {
        private static string connectionString = @"Server=.\SQLEXPRESS01;Database=QuanLyChungChi;User Id=sa;Password=1;TrustServerCertificate=True;";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
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

        
    }
}