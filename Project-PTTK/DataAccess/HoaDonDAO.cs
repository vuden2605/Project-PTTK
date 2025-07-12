using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
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
            string query = "INSERT INTO HOADON(TongTien, ChietKhau, PhuongThucThanhToan, Loai, NvLap, MaPhieuDangKy, MaPhieuGiaHan) " +
                           "VALUES (@TongTien, @ChietKhau, @PhuongThucThanhToan, @Loai, @NvLap, @MaPhieuDangKy, @MaPhieuGiaHan);";
                          

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TongTien", hoaDon.TongTien),
                new SqlParameter("@ChietKhau", hoaDon.ChietKhau),
                new SqlParameter("@PhuongThucThanhToan", hoaDon.PhuongThucThanhToan),
                new SqlParameter("@Loai", hoaDon.Loai),
                new SqlParameter("@NvLap", hoaDon.NhanVienLap),
                new SqlParameter("@MaPhieuDangKy", (object?)hoaDon.MaPhieuDangKy ?? DBNull.Value),
                new SqlParameter("@MaPhieuGiaHan", (object?)hoaDon.MaPhieuGiaHan ?? DBNull.Value)
        
            };

            try
            {
                DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện thêm hóa đơn", ex);
            }
        }

    }
}
