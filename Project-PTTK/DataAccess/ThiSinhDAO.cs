using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Project_PTTK.Model;

namespace Project_PTTK.DataAccess
{
    public class ThiSinhDAO
    {
        public List<ThiSinh> LayTheoPhieuDangKy(int maPhieuDangKy)
        {
            var list = new List<ThiSinh>();
            try
            {
                const string query = "SELECT * FROM ThiSinh WHERE MaPhieuDangKy = @MaPhieuDangKy";
                SqlParameter[] parameters = { new SqlParameter("@MaPhieuDangKy", maPhieuDangKy) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    var thiSinh = new ThiSinh
                    {
                        MaTS = row.Field<int>("MaTS"),
                        HoTen = row.Field<string>("TenThiSinh") ?? string.Empty,
                        NgaySinh = row.Field<DateOnly>("NgaySinh"),
                        CCCD = row.Field<string>("CCCD") ?? string.Empty,
                        GioiTinh = row.Field<string>("GioiTinh") ?? string.Empty,
                        TrangThaiPhatHanhPhieuDuThi = row.Field<string>("TrangThaiPhatHanhPhieuDuThi") ?? string.Empty,
                        MaPhieuDangKy = row.Field<int>("MaPhieuDangKy"),
                        MaLichThi = row.Field<int>("MaLichThi")
                    };
                    list.Add(thiSinh);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thí sinh theo phiếu đăng ký: ", ex);
            }
            return list;
        }
        public ThiSinh? loadThongTinThiSinh(int MaTS)
        {
            ThiSinh? thiSinh = null;
            try
            {
                const string query = "SELECT * FROM ThiSinh WHERE MaTS = @MaTS";
                SqlParameter[] parameters = { new SqlParameter("@MaTS", MaTS) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    thiSinh = new ThiSinh
                    {
                        MaTS = row.Field<int>("MaTS"),
                        HoTen = row.Field<string>("TenThiSinh") ?? string.Empty,
                        NgaySinh = row.Field<DateOnly>("NgaySinh"),
                        CCCD = row.Field<string>("CCCD") ?? string.Empty,
                        GioiTinh = row.Field<string>("GioiTinh") ?? string.Empty,
                        TrangThaiPhatHanhPhieuDuThi = row.Field<string>("TrangThaiPhatHanhPhieuDuThi") ?? string.Empty,
                        MaPhieuDangKy = row.Field<int>("MaPhieuDangKy"),
                        MaLichThi = row.Field<int>("MaLichThi")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thí sinh: ", ex);
            }
            return thiSinh;
        }
        public List<ThiSinh> getAll()
        {
            var list = new List<ThiSinh>();
            try
            {
                const string query = "SELECT * FROM ThiSinh";
                using DataTable dt = DBHelper.ExecuteQuery(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    var thiSinh = new ThiSinh
                    {
                        MaTS = row.Field<int>("MaTS"),
                        HoTen = row.Field<string>("TenThiSinh") ?? string.Empty,
                        NgaySinh = row.Field<DateOnly>("NgaySinh"),
                        CCCD = row.Field<string>("CCCD") ?? string.Empty,
                        GioiTinh = row.Field<string>("GioiTinh") ?? string.Empty,
                        TrangThaiPhatHanhPhieuDuThi = row.Field<string>("TrangThaiPhatHanhPhieuDuThi") ?? string.Empty,
                        MaPhieuDangKy = row.Field<int>("MaPhieuDangKy"),
                        MaLichThi = row.Field<int>("MaLichThi")
                    };
                    list.Add(thiSinh);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách thí sinh: ", ex);
            }
            return list;
        }
        public void add(ThiSinh TS)
        {
            const string query = "INSERT INTO ThiSinh VALUES (@TenThiSinh, @NgaySinh, @CCCD, @GioiTinh, @TrangThaiPhatHanhPhieuDuThi, @MaPhieuDangKy, @MaLichThi)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenThiSinh", TS.HoTen),
                new SqlParameter("@NgaySinh", TS.NgaySinh),
                new SqlParameter("@CCCD", TS.CCCD),
                new SqlParameter("@GioiTinh", TS.GioiTinh),
                new SqlParameter("@TrangThaiPhatHanhPhieuDuThi", TS.TrangThaiPhatHanhPhieuDuThi),
                new SqlParameter("@MaPhieuDangKy", TS.MaPhieuDangKy),
                new SqlParameter("@MaLichThi", TS.MaLichThi)
            };
            try
            {
                int rows = DBHelper.ExecuteNonQuery(query, parameters);
                if (rows == 0)
                {
                    throw new Exception("Không có bản ghi nào được thêm.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thí sinh: ", ex);
            }
        }
        public void update(ThiSinh oldTS, ThiSinh newTS)
        {
            const string query = "UPDATE ThiSinh SET TenThiSinh = @TenThiSinh, NgaySinh = @NgaySinh, CCCD = @CCCD, GioiTinh = @GioiTinh, TrangThaiPhatHanhPhieuDuThi = @TrangThaiPhatHanhPhieuDuThi, MaPhieuDangKy = @MaPhieuDangKy, MaLichThi = @MaLichThi WHERE MaTS = @MaTS";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MaTS", oldTS.MaTS),
                new SqlParameter("@TenThiSinh,", newTS.HoTen),
                new SqlParameter("@NgaySinh", newTS.NgaySinh),
                new SqlParameter("@CCCD", newTS.CCCD),
                new SqlParameter("@GioiTinh", newTS.GioiTinh),
                new SqlParameter("@TrangThaiPhatHanhPhieuDuThi", newTS.TrangThaiPhatHanhPhieuDuThi),
                new SqlParameter("@MaPhieuDangKy", newTS.MaPhieuDangKy),
                new SqlParameter("@MaLichThi", newTS.MaLichThi)
                };
            try
            {
                int rows = DBHelper.ExecuteNonQuery(query, parameters);
                if (rows == 0)
                {
                    throw new Exception("Không có bản ghi nào được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thí sinh: ", ex);
            }
        }
    }
}
