using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;
using Microsoft.Data.SqlClient;

namespace Project_PTTK.DataAccess
{
    public class KhachHangDonViDAO 
    {
        public int add(KhachHangDonVi khachHang)
        {
            try
            {
                string query = "INSERT INTO KhachHangDonVi (MaKH,TenDV, DiaChi) OUTPUT INSERTED.MaKH  VALUES (@MaKH,@TenDV, @DiaChi)";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaKH", khachHang.MaKH),
                    new SqlParameter("@TenDV", khachHang.TenDonVi),
                    new SqlParameter("@DiaChi", khachHang.DiaChi)
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
