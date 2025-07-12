using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;
using System.Data;
using Microsoft.Data.SqlClient;
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
            const string query = "INSERT INTO ChiTietPhieu VALUES (@MaPhieuDangKy, @MaLichThi, @SoLuong)";
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
        public void TangSoLuongThiSinh(int maPhieuDangKy, int maLichThi)
        {
            const string query = @"
        UPDATE ChiTietPhieu
        SET SoLuong = SoLuong + 1
        WHERE MaPhieuDangKy = @MaPhieuDangKy AND MaLichThi = @MaLichThi";

            SqlParameter[] parameters =
            {
        new SqlParameter("@MaPhieuDangKy", maPhieuDangKy),
        new SqlParameter("@MaLichThi", maLichThi)
    };

            try
            {
                int rows = DBHelper.ExecuteNonQuery(query, parameters);
                if (rows == 0)
                {
                    throw new Exception("Không tìm thấy dòng phù hợp để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tăng số lượng thí sinh trong chi tiết phiếu: ", ex);
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
        public List<PhieuDangKy> LayDanhSach()
        {
            var list = new List<PhieuDangKy>();
            const string query = "SELECT * FROM PhieuDangKy";
            try
            {
                using DataTable dt = DBHelper.ExecuteQuery(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    var phieuDangKy = new PhieuDangKy
                    {
                        MaPhieu = row.Field<int>("MaPhieu"),
                        NgayTao = row.Field<DateOnly>("NgayTao"),
                        TrangThaiThanhToan = row.Field<string>("TrangThaiThanhToan") ?? string.Empty,
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
        public List<PhieuDangKyView> LayDanhSachPDKV()
        {
            var list = new List<PhieuDangKyView>();

            try
            {
                const string query = @"
                    SELECT * 
                    FROM PhieuDangKy pdk
                    JOIN KhachHang kh ON kh.MaKH = pdk.MaKH
                    LEFT JOIN KhachHangDonVi khdv ON khdv.MaKH = kh.MaKH
                    LEFT JOIN KhachHangTuDo khtd ON khtd.MaKH = kh.MaKH
                    ORDER BY pdk.MaPhieuDangKy DESC
                ";
                DataTable dt = DBHelper.ExecuteQuery(query, null);

                foreach (DataRow row in dt.Rows)
                {
                    var phieuDangKyView = new PhieuDangKyView
                    {
                        MaPhieuDangKy = row.Field<int>("MaPhieuDangKy"),
                        // Chuyển DateTime -> DateOnly
                        NgayTao = DateOnly.FromDateTime(row.Field<DateTime>("NgayTao")),
     
                        MaKH = row.Field<int>("MaKH"),
                        Email = row.Field<string>("Email") ?? string.Empty,
                        LoaiKH = row.Field<string>("LoaiKhachHang") ?? string.Empty,
                        TenKH = row.Field<string>("HoTen") ?? row.Field<string>("TenDV")
                    };

                    list.Add(phieuDangKyView);
                }
            }
            catch (Exception ex)
            {
                string errorDetail =
                    $"Lỗi khi lấy danh sách phiếu đăng ký:\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}";
                Console.WriteLine(errorDetail);
                throw new Exception(errorDetail, ex);
            }

            return list;
        }

        public void add(PhieuDangKy phieuDangKy)
        {
            const string query = "INSERT INTO PhieuDangKy VALUES (@NgayTao, @TrangThaiThanhToan, @MaKH, @NhanVienLap)";
            SqlParameter[] parameters = {
                new SqlParameter("@NgayTao", phieuDangKy.NgayTao),
                new SqlParameter("@TrangThaiThanhToan", phieuDangKy.TrangThaiThanhToan),
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
        public List<ThiSinh> getThiSinhByPhieuDangKy(int maphieu)
        {
            var list = new List<ThiSinh>();
            try
            {
                const string query = @"
            SELECT ts.MaTS, ts.HoTen, ts.NgaySinh, ts.CCCD, ts.GioiTinh, 
                   ts.TrangThaiPhatHanhPhieuDuThi, ts.MaLichThi 
            FROM ThiSinh ts 
            JOIN ChiTietPhieu ctpdk ON ts.MaLichThi = ctpdk.MaLichThi
            WHERE ctpdk.MaPhieuDangKy = @MaPhieuDangKy";

                SqlParameter[] parameters = { new SqlParameter("@MaPhieuDangKy", maphieu) };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);

                foreach (DataRow row in dt.Rows)
                {
                    var thiSinh = new ThiSinh
                    {
                        MaTS = row.Field<int>("MaTS"),
                        HoTen = row.Field<string>("HoTen") ?? string.Empty,
                        NgaySinh = DateOnly.FromDateTime(row.Field<DateTime>("NgaySinh")), // ✅ sửa chỗ này
                        CCCD = row.Field<string>("CCCD") ?? string.Empty,
                        GioiTinh = row.Field<string>("GioiTinh") ?? string.Empty,
                        TrangThaiPhatHanhPhieuDuThi = row.Field<string>("TrangThaiPhatHanhPhieuDuThi") ?? string.Empty,
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
        public void CapNhatTrangThaiPhieu (int maphieu)
        {
            const string query = "UPDATE PhieuDangKy SET TrangThaiThanhToan = 'Đã thanh toán' WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters = { new SqlParameter("@MaPhieu", maphieu) };
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
                throw new Exception("Lỗi khi cập nhật trạng thái phiếu đăng ký: ", ex);
            }
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
