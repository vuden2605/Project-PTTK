using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;
using Project_PTTK.Utils;

namespace Project_PTTK.DataAccess
{
    public class PhieuGiaHanDAO
    {
        public int TinhSoTien(String LyDo)
        {
            if ("Y".Equals(LyDo)) return 0;
            return 100000;
        }

        public void CapNhatTrangThaiPhieuGH(PhieuGiaHan phieuGiaHan)
        {
            String query = "UPDATE PHIEU_GIA_HAN SET TrangThai = @TrangThai WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TrangThai", phieuGiaHan.TrangThaiThanhToan),
                new SqlParameter("@MaPhieu", phieuGiaHan.MaPhieuGiaHan)
            };
            try
            {
                DBHelper.ExecuteNonQuery(query, parameters);
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái phiếu gia hạn", ex);
            }
        }

        public List<PhieuGiaHan> LoadDSPhieuGH()
        {
            String query = "SELECT * FROM PHIEU_GIA_HAN WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters = new SqlParameter[]{};
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                return DataTableUtils.ToList<PhieuGiaHan>(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái phiếu gia hạn", ex);
            }
        }

        public PhieuGiaHan LoadThongTinPhieuGH(int maPhieuGiaHan)
        {
            String query = "SELECT * FROM PHIEU_GIA_HAN WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maPhieuGiaHan)
            };
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                return DataTableUtils.ToList<PhieuGiaHan>(dt).FirstOrDefault()
                    ?? throw new Exception("Không tìm thấy thông tin phiếu gia hạn với mã: " + maPhieuGiaHan);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái phiếu gia hạn", ex);
            }

        }


    }
}
