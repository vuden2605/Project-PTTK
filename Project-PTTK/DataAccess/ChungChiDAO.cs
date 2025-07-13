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
            String query = "INSERT INTO CHUNGCHI( MaTS, NvLap, NgayCap, TrangThai, KetQua ) " +
                           "VALUES (@MaTS, @NhanVienLap, @NgayCap, @TrangThai, @KetQua);";
                           
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
                
            }
            catch(Exception ex) { 
                throw new Exception("Lỗi khi thực hiện thêm chứng chỉ", ex);
            }
        }
    }
}
