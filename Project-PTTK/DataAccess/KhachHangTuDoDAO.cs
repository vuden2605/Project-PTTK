using Project_PTTK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Project_PTTK.DataAccess
{
    public class KhachHangTuDoDAO 
    {
        public int add(KhachHangTuDo khachHang)
        {
            try
            {
                string query = "INSERT INTO KhachHangTuDo (MaKH,HoTen, NgaySinh) VALUES (@MaKH,@HoTen, @NgaySinh)";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaKH", khachHang.MaKH),
                    new SqlParameter("@HoTen", khachHang.Ten),
                    new SqlParameter("@NgaySinh", khachHang.NgaySinh)
                };
                object id = DBHelper.ExecuteScalar(query, parameters);
                if (id != null && id != DBNull.Value)
                {
                    return Convert.ToInt32(id);
                }
                else
                {
                    throw new Exception("Không thể lấy ID của khách hàng mới.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: ", ex);
            }
        }
    }
}
