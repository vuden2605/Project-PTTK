using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_PTTK.Model;

namespace Project_PTTK.DataAccess
{
    public class ThiSinhRepository
    {
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
    }
}
