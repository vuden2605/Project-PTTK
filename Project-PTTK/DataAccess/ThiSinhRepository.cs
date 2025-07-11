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
                        MaKH = row.Field<int>("MaKH"),
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
            const string query = "INSERT INTO ThiSinh VALUES (@TenThiSinh, @NgaySinh, @CCCD, @GioiTinh, @TrangThaiPhatHanhPhieuDuThi, @MaKhoaHoc, @MaLichThi)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenThiSinh", TS.HoTen),
                new SqlParameter("@NgaySinh", TS.NgaySinh),
                new SqlParameter("@CCCD", TS.CCCD),
                new SqlParameter("@GioiTinh", TS.GioiTinh),
                new SqlParameter("@TrangThaiPhatHanhPhieuDuThi", TS.TrangThaiPhatHanhPhieuDuThi),
                new SqlParameter("@MaKhoaHoc", TS.MaKH),
                new SqlParameter("@MaLichThi", TS.MaLichThi)
            };
            try
            {
                DBHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thí sinh: ", ex);
            }
        }
    }
}
