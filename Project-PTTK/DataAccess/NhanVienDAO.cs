using Project_PTTK.Model;
using Microsoft.Data.SqlClient;
using System.Data;

//use hash library for password hashing
using Project_PTTK.Cryptography;

namespace Project_PTTK.DataAccess
{
    public class NhanVienDAO
    {
        public NhanVienDAO() { }
        public List<NhanVien> GetAllNhanVienInfo()
        {
            var nhanViens = new List<NhanVien>();
            const string query = "SELECT * FROM NhanVien";
            try
            {
                using DataTable dataTable = DBHelper.ExecuteQuery(query, null);
                foreach (DataRow row in dataTable.Rows)
                {
                    var nhanVien = new NhanVien
                    {
                        MaNV = row.Field<int>("MaNV"),
                        HoTen = row.Field<string>("Ten") ?? string.Empty,
                        SDT = row.Field<string>("SDT") ?? string.Empty,
                        Email = row.Field<string>("Email") ?? string.Empty,
                        VaiTro = row.Field<string>("VaiTro") ?? string.Empty,
                        Luong = row.Field<decimal>("Luong"),
                    };
                    nhanViens.Add(nhanVien);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: ", ex);
            }
            return nhanViens;
        }
        public NhanVien? GetNhanVienInfo(int id) {
            const string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", id) };
            try
            {
                var dataTable = DBHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new NhanVien
                    {
                        MaNV = row.Field<int>("MaNV"),
                        HoTen = row.Field<string>("Ten") ?? string.Empty,
                        SDT = row.Field<string>("SDT") ?? string.Empty,
                        Email = row.Field<string>("Email") ?? string.Empty,
                        VaiTro = row.Field<string>("VaiTro") ?? string.Empty,
                        Luong = row.Field<decimal>("Luong"),
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy nhân viên: ", ex);
            }
        }
        public int Authenticate(string email, string password) // Returns MaNV if authentication is successful, otherwise returns 0
        {
            const string query = "SELECT * FROM NhanVien WHERE Email = @Email";
            SqlParameter[] parameters = { new SqlParameter("@Email", email) };
            try
            {
                var dataTable = DBHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string hashedPassword = row.Field<string>("MatKhau") ?? string.Empty;
                    if (Cryptography.Cryptography.VerifyPassword(password, hashedPassword))
                        return row.Field<int>("MaNV");
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xác thực nhân viên: ", ex);
            }
        }
    }
}
