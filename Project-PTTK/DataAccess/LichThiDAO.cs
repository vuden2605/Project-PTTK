using System.Data;
using Microsoft.Data.SqlClient;
using Project_PTTK.Model;

namespace Project_PTTK.DataAccess
{
    public class LichThiDAO
    {
        public LichThi? LayTheoMa(int maLichThi)
        {
            LichThi? lichThi = null;
            try
            {
                const string query = "SELECT * FROM LichThi WHERE MaLichThi = @MaLichThi";
                SqlParameter[] parameters = { new SqlParameter("@MaLichThi", maLichThi) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    lichThi = new LichThi
                    {
                        MaLichThi = row.Field<int>("MaLichThi"),
                        NgayThi = row.Field<DateOnly>("NgayThi"),
                        GioThi = row.Field<TimeOnly>("GioThi"),
                        SoThiSinhDaDangKy = row.Field<int>("SoThiSinhDaDangKy"),
                        MaPhongThi = row.Field<int>("MaPhongThi"),
                        MaDichVu = row.Field<int>("MaDichVu"),
                        NhanVienLap = row.Field<int>("NhanVienLap")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lịch thi theo mã: ", ex);
            }
            return lichThi;
        }
        public List<LichThi> LayTheoMaDichVu(int maDichVu)
        {
            var lichThis = new List<LichThi>();
            try
            {
                const string query = "SELECT * FROM LichThi WHERE MaDichVu = @MaDichVu";
                SqlParameter[] parameters = { new SqlParameter("@MaDichVu", maDichVu) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    var lichThi = new LichThi
                    {
                        MaLichThi = row.Field<int>("MaLichThi"),
                        NgayThi = row.Field<DateOnly>("NgayThi"),
                        GioThi = row.Field<TimeOnly>("GioThi"),
                        SoThiSinhDaDangKy = row.Field<int>("SoThiSinhDaDangKy"),
                        MaPhongThi = row.Field<int>("MaPhongThi"),
                        MaDichVu = row.Field<int>("MaDichVu"),
                        NhanVienLap = row.Field<int>("NhanVienLap")
                    };
                    lichThis.Add(lichThi);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lịch thi theo mã dịch vụ: ", ex);
            }
            return lichThis;
        }
        public List<LichThi> LayDanhSach()
        {
            var lichThis = new List<LichThi>();
            try
            {
                const string query = "SELECT * FROM LichThi";
                using DataTable dt = DBHelper.ExecuteQuery(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    var lichThi = new LichThi
                    {
                        MaLichThi = row.Field<int>("MaLichThi"),
                        NgayThi = row.Field<DateOnly>("NgayThi"),
                        GioThi = row.Field<TimeOnly>("GioThi"),
                        SoThiSinhDaDangKy = row.Field<int>("SoThiSinhDaDangKy"),
                        MaPhongThi = row.Field<int>("MaPhongThi"),
                        MaDichVu = row.Field<int>("MaDichVu"),
                        NhanVienLap = row.Field<int>("NhanVienLap")
                    };
                    lichThis.Add(lichThi);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách lịch thi: ", ex);
            }
            return lichThis;
        }
        public void CapNhat(LichThi oldLT, LichThi newLT)
        {
            const string query = "UPDATE LichThi SET NgayThi = @NgayThi, GioThi = @GioThi, SoThiSinhDaDangKy = @SoThiSinhDaDangKy, MaPhongThi = @MaPhongThi, MaDichVu = @MaDichVu, NhanVienLap = @NhanVienLap WHERE MaLichThi = @MaLichThi";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NgayThi", newLT.NgayThi),
                new SqlParameter("@GioThi", newLT.GioThi),
                new SqlParameter("@SoThiSinhDaDangKy", newLT.SoThiSinhDaDangKy),
                new SqlParameter("@MaPhongThi", newLT.MaPhongThi),
                new SqlParameter("@MaDichVu", newLT.MaDichVu),
                new SqlParameter("@NhanVienLap", newLT.NhanVienLap),
                new SqlParameter("@MaLichThi", oldLT.MaLichThi)
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
                throw new Exception("Lỗi khi cập nhật lịch thi: ", ex);
            }
        }
        public void TangSoLuongThiSinhDangKy(int maLichThi)
        {
            const string query = @"
        UPDATE LichThi
        SET SoTSDaDangKy = SoTSDaDangKy + 1
        WHERE MaLichThi = @MaLichThi";

            SqlParameter[] parameters = {
        new SqlParameter("@MaLichThi", maLichThi)
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
                throw new Exception("Lỗi khi cập nhật số lượng thí sinh đã đăng ký: ", ex);
            }
        }

        public void Them(LichThi lichThi)
        {
            const string query = "INSERT INTO LichThi (NgayThi, GioThi, SoThiSinhDaDangKy, MaPhongThi, MaDichVu, NhanVienLap) VALUES (@NgayThi, @GioThi, @SoThiSinhDaDangKy, @MaPhongThi, @MaDichVu, @NhanVienLap)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NgayThi", lichThi.NgayThi),
                new SqlParameter("@GioThi", lichThi.GioThi),
                new SqlParameter("@SoThiSinhDaDangKy", lichThi.SoThiSinhDaDangKy),
                new SqlParameter("@MaPhongThi", lichThi.MaPhongThi),
                new SqlParameter("@MaDichVu", lichThi.MaDichVu),
                new SqlParameter("@NhanVienLap", lichThi.NhanVienLap)
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
                throw new Exception("Lỗi khi thêm lịch thi: ", ex);
            }
        }
    }
}
