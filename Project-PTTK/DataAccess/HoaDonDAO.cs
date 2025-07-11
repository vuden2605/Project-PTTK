using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;

namespace Project_PTTK.DataAccess
{
    public class HoaDonDAO
    {
        public void ThemHoaDon(HoaDon hoaDon)
        {
            String query = "INSERT INTO HOA_DON(TongTien, ChietKhau, NgayTao, Loai, NvLap, MaPhieuDangKi, MaPhieuGiaHan) " +
                           "VALUES (@TongTien, @ChietKhau, @NgayTao, @Loai, @NvLap, @MaPhieuDangKi, @MaPhieuGiaHan);" +
                           "SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TongTien", hoaDon.TongTien),
                new SqlParameter("@ChietKhau", hoaDon.ChietKhau),
                new SqlParameter("@NgayTao", hoaDon.NgayTao),
                new SqlParameter("@Loai", hoaDon.Loai),
                new SqlParameter("@NvLap", hoaDon.NhanVienLap),
                new SqlParameter("@MaPhieuDangKi", hoaDon.MaPhieuDangKy),
                new SqlParameter("@MaPhieuGiaHan", hoaDon.MaPhieuGiaHan)
            };
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                int maHoaDon = dt.MinimumCapacity > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện thêm hóa đơn", ex);
            }
        }
    }
}
