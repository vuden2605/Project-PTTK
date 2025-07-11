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
    public class ThiSinhDAO
    {
        public ThiSinh loadThongTinThiSinh(int maThiSinh){
            String query = "SELECT * FROM THISINH";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaTS", maThiSinh),
            };
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                return DataTableUtils.ToList<ThiSinh>(dt).FirstOrDefault() 
                    ?? throw new Exception("Không tìm thấy thông tin thí sinh với mã: " + maThiSinh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện lấy thông tin thí sinh",ex);
            }
            
        }
    }
}
