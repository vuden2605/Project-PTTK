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
    public class ChungChiDAO
    {
        public void ThemChungChi(ChungChi chungChi)
        {
            String query = "INSERT INTO CHUNG_CHI(NgayCap, TrangThai, KetQua, MaTS, NvLap) " +
                           "VALUES (@NgayCap, @TrangThai, @KetQua, @MaTS, @NhanVienLap);" +
                           "SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NgayCap", chungChi.NgayCap),
                new SqlParameter("@TrangThai", chungChi.TrangThai),
                new SqlParameter("@KetQua", chungChi.KetQua),
                new SqlParameter("@MaTS", chungChi.MaTS),
                new SqlParameter("@NhanVienLap", chungChi.NhanVienLap),
            };
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                int maChungChi = Convert.ToInt32(dt.Rows[0][0]);
                chungChi.MaChungChi = maChungChi;
            }
            catch(Exception ex) { 
                throw new Exception("Lỗi khi thực hiện thêm chứng chỉ", ex);
            }
        }
    }
}
