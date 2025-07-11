using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Project_PTTK.DataAccess.Phieu
{
    public class ChiTietPhieuDangKyDAO
    {

        public List<ChiTietPhieuDangKy> getAll()
        {
            var list = new List<ChiTietPhieuDangKy>();
            try
            {
                const string query = "SELECT * FROM ChiTietPhieuDangKy";
                using DataTable dt = DBHelper.ExecuteQuery(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    var chiTietPhieuDangKy = new ChiTietPhieuDangKy
                    {
                        MaPhieu = row.Field<int>("MaPhieuDangKy"),
                        MaLichThi = row.Field<int>("MaLichThi"),
                        SoLuong = row.Field<int>("SoLuong")
                    };
                    list.Add(chiTietPhieuDangKy);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách chi tiết phiếu đăng ký: ", ex);
            }
            return list;
        }
        public List<ChiTietPhieuDangKy> getByMaPhieu(int maPhieu)
        {
            var list = new List<ChiTietPhieuDangKy>();
            try
            {
                const string query = "SELECT * FROM ChiTietPhieuDangKy WHERE MaPhieuDangKy = @MaPhieuDangKy";
                SqlParameter[] parameters = { new SqlParameter("@MaPhieuDangKy", maPhieu) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    var chiTietPhieuDangKy = new ChiTietPhieuDangKy
                    {
                        MaPhieu = row.Field<int>("MaPhieuDangKy"),
                        MaLichThi = row.Field<int>("MaLichThi"),
                        SoLuong = row.Field<int>("SoLuong")
                    };
                    list.Add(chiTietPhieuDangKy);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy chi tiết phiếu đăng ký theo mã phiếu: ", ex);
            }
            return list;
        }
        public void add(ChiTietPhieuDangKy chiTietPhieuDangKy)
        {
            const string query = "INSERT INTO ChiTietPhieuDangKy VALUES (@MaPhieuDangKy, @MaLichThi, @SoLuong)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhieuDangKy", chiTietPhieuDangKy.MaPhieu),
                new SqlParameter("@MaLichThi", chiTietPhieuDangKy.MaLichThi),
                new SqlParameter("@SoLuong", chiTietPhieuDangKy.SoLuong)
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
                throw new Exception("Lỗi khi thêm chi tiết phiếu đăng ký: ", ex);
            }
        }
        public void delete(int maPhieu, int maLichThi)
        {
            const string query = "DELETE FROM ChiTietPhieuDangKy WHERE MaPhieuDangKy = @MaPhieuDangKy AND MaLichThi = @MaLichThi";
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhieuDangKy", maPhieu),
                new SqlParameter("@MaLichThi", maLichThi)
            };
            try
            {
                int rows = DBHelper.ExecuteNonQuery(query, parameters);
                if (rows == 0)
                {
                    throw new Exception("Không có bản ghi nào được xóa.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa chi tiết phiếu đăng ký: ", ex);
            }
        }
        public void update(ChiTietPhieuDangKy oldP, ChiTietPhieuDangKy newP)
        {
            const string query = "UPDATE ChiTietPhieuDangKy SET SoLuong = @SoLuong WHERE MaPhieuDangKy = @MaPhieuDangKy AND MaLichThi = @MaLichThi";
            SqlParameter[] parameters = {
                new SqlParameter("@SoLuong", newP.SoLuong),
                new SqlParameter("@MaLichThi", oldP.MaLichThi),
                new SqlParameter("@MaPhieuDangKy", oldP.MaPhieu),
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
                throw new Exception("Lỗi khi cập nhật chi tiết phiếu đăng ký: ", ex);
            }
        }
    }

    public class PhieuDangKyDAO
    {
        public PhieuDangKy? LayTheoMa(int maPhieu)
        {
            PhieuDangKy? phieuDangKy = null;
            try
            {
                const string query = "SELECT * FROM PhieuDangKy WHERE MaPhieu = @MaPhieu";
                SqlParameter[] parameters = { new SqlParameter("@MaPhieu", maPhieu) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    phieuDangKy = new PhieuDangKy
                    {
                        MaPhieu = row.Field<int>("MaPhieu"),
                        NgayTao = row.Field<DateOnly>("NgayTao"),
                        TrangThaiThanhToan = row.Field<string>("TrangThaiThanhToan") ?? string.Empty,
                        PhuongThucThanhToan = row.Field<string>("PhuongThucThanhToan") ?? string.Empty,
                        MaKH = row.Field<int>("MaKH"),
                        NhanVienLap = row.Field<int>("NhanVienLap")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy phiếu đăng ký: ", ex);
            }
            return phieuDangKy;
        }
        public List<PhieuDangKy> getAll()
        {
            var list = new List<PhieuDangKy>();
            try
            {
                const string query = "SELECT * FROM PhieuDangKy";
                using DataTable dt = DBHelper.ExecuteQuery(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    var phieuDangKy = new PhieuDangKy
                    {
                        MaPhieu = row.Field<int>("MaPhieu"),
                        NgayTao = row.Field<DateOnly>("NgayTao"),
                        TrangThaiThanhToan = row.Field<string>("TrangThaiThanhToan") ?? string.Empty,
                        PhuongThucThanhToan = row.Field<string>("PhuongThucThanhToan") ?? string.Empty,
                        MaKH = row.Field<int>("MaKH"),
                        NhanVienLap = row.Field<int>("NhanVienLap")
                    };
                    list.Add(phieuDangKy);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách phiếu đăng ký: ", ex);
            }
            return list;
        }
        public void add(PhieuDangKy phieuDangKy)
        {
            const string query = "INSERT INTO PhieuDangKy VALUES (@NgayTao, @TrangThaiThanhToan, @PhuongThucThanhToan, @MaKH, @NhanVienLap)";
            SqlParameter[] parameters = {
                new SqlParameter("@NgayTao", phieuDangKy.NgayTao),
                new SqlParameter("@TrangThaiThanhToan", phieuDangKy.TrangThaiThanhToan),
                new SqlParameter("@PhuongThucThanhToan", phieuDangKy.PhuongThucThanhToan),
                new SqlParameter("@MaKH", phieuDangKy.MaKH),
                new SqlParameter("@NhanVienLap", phieuDangKy.NhanVienLap)
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
                throw new Exception("Lỗi khi thêm phiếu đăng ký: ", ex);
            }
        }
        public void delete(int maPhieu)
        {
            const string query = "DELETE FROM PhieuDangKy WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters = { new SqlParameter("@MaPhieu", maPhieu) };
            try
            {
                int rows = DBHelper.ExecuteNonQuery(query, parameters);
                if (rows == 0)
                {
                    throw new Exception("Không có bản ghi nào được xóa.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa phiếu đăng ký: ", ex);
            }
        }
        public void update(PhieuDangKy oldP, PhieuDangKy newP)
        {
            const string query = "UPDATE PhieuDangKy SET NgayTao = @NgayTao, TrangThaiThanhToan = @TrangThaiThanhToan, PhuongThucThanhToan = @PhuongThucThanhToan, MaKH = @MaKH, NhanVienLap = @NhanVienLap WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters = {
                new SqlParameter("@NgayTao", newP.NgayTao),
                new SqlParameter("@TrangThaiThanhToan", newP.TrangThaiThanhToan),
                new SqlParameter("@PhuongThucThanhToan", newP.PhuongThucThanhToan),
                new SqlParameter("@MaKH", newP.MaKH),
                new SqlParameter("@NhanVienLap", newP.NhanVienLap),
                new SqlParameter("@MaPhieu", oldP.MaPhieu)
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
                throw new Exception("Lỗi khi cập nhật phiếu đăng ký: ", ex);
            }
        }
        public PhieuDangKy? get(int maPhieu)
        {
            PhieuDangKy? phieuDangKy = null;
            try
            {
                const string query = "SELECT * FROM PhieuDangKy WHERE MaPhieu = @MaPhieu";
                SqlParameter[] parameters = { new SqlParameter("@MaPhieu", maPhieu) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    phieuDangKy = new PhieuDangKy
                    {
                        MaPhieu = row.Field<int>("MaPhieu"),
                        NgayTao = row.Field<DateOnly>("NgayTao"),
                        TrangThaiThanhToan = row.Field<string>("TrangThaiThanhToan") ?? string.Empty,
                        PhuongThucThanhToan = row.Field<string>("PhuongThucThanhToan") ?? string.Empty,
                        MaKH = row.Field<int>("MaKH"),
                        NhanVienLap = row.Field<int>("NhanVienLap")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy phiếu đăng ký: ", ex);
            }
            return phieuDangKy;
        }
        public List<PhieuDangKy> getByTrangThai(string TrangThai)
        {
            List<PhieuDangKy> list = new List<PhieuDangKy>();
            try
            {
                const string query = "SELECT * FROM PhieuDangKy WHERE TrangThaiThanhToan = @TrangThaiThanhToan";
                SqlParameter[] parameters = { new SqlParameter("@TrangThaiThanhToan", TrangThai) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new PhieuDangKy
                    {
                        MaPhieu = dr.Field<int>("MaPhieu"),
                        NgayTao = dr.Field<DateOnly>("NgayTao"),
                        TrangThaiThanhToan = dr.Field<string>("TrangThaiThanhToan") ?? string.Empty,
                        PhuongThucThanhToan = dr.Field<string>("PhuongThucThanhToan") ?? string.Empty,
                        MaKH = dr.Field<int>("MaKH"),
                        NhanVienLap = dr.Field<int>("NhanVienLap")
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách phiếu đăng ký theo trạng thái: ", ex);
            }
            return list;
        }
    }

    public class PhieuGiaHanDAO
    {
        public PhieuGiaHan? LayTheoMa(int MaPhieu)
        {
            PhieuGiaHan? phieuGiaHan = null;
            const string query = "SELECT * FROM PhieuGiaHan WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters = { new SqlParameter("@MaPhieu", MaPhieu) };
            try
            {
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    phieuGiaHan = new PhieuGiaHan
                    {
                        MaPhieuGiaHan = row.Field<int>("MaPhieu"),
                        NgayTao = row.Field<DateOnly>("NgayTao"),
                        LyDo = row.Field<string>("LyDo") ?? string.Empty,
                        TrangThaiThanhToan = row.Field<string>("TrangThaiThanhToan") ?? string.Empty,
                        MaPhieuDangKy = row.Field<int>("MaPhieuDangKy")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy phiếu gia hạn: ", ex);
            }
            return phieuGiaHan;
        }
        public List<PhieuGiaHan> LayDanhSach()
        {
            var list = new List<PhieuGiaHan>();
            const string query = "SELECT * FROM PhieuGiaHan";
            try
            {
                using DataTable dt = DBHelper.ExecuteQuery(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    var phieuGiaHan = new PhieuGiaHan
                    {
                        MaPhieuGiaHan = row.Field<int>("MaPhieu"),
                        NgayTao = row.Field<DateOnly>("NgayTao"),
                        LyDo = row.Field<string>("LyDo") ?? string.Empty,
                        TrangThaiThanhToan = row.Field<string>("TrangThaiThanhToan") ?? string.Empty,
                        MaPhieuDangKy = row.Field<int>("MaPhieuDangKy")
                    };
                    list.Add(phieuGiaHan);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách phiếu gia hạn: ", ex);
            }
            return list;
        }
        public void Them(PhieuGiaHan phieuGiaHan)
        {
            const string query = "INSERT INTO PhieuGiaHan (NgayTao, LyDo, TrangThaiThanhToan, MaPhieuDangKy) VALUES (@NgayTao, @LyDo, @TrangThaiThanhToan, @MaPhieuDangKy)";
            SqlParameter[] parameters = {
                new SqlParameter("@NgayTao", phieuGiaHan.NgayTao),
                new SqlParameter("@LyDo", phieuGiaHan.LyDo),
                new SqlParameter("@TrangThaiThanhToan", phieuGiaHan.TrangThaiThanhToan),
                new SqlParameter("@MaPhieuDangKy", phieuGiaHan.MaPhieuDangKy)
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
                throw new Exception("Lỗi khi thêm phiếu gia hạn: ", ex);
            }
        }
    }
}
