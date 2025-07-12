using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Project_PTTK.DataAccess
{
    public class KhachHangDonViDAO 
    {
        public List<KhachHangDonVi> getAll()
        {
            try
            {
                string query = "SELECT * FROM KhachHangDonVi";
                DataTable dataTable = DBHelper.ExecuteQuery(query, null);
                List<KhachHangDonVi> khachHangs = new List<KhachHangDonVi>();
                foreach (DataRow row in dataTable.Rows)
                {
                    KhachHangDonVi khachHang = new KhachHangDonVi
                    {
                        MaKH = row.Field<int>("MaKH"),
                        TenDonVi = row.Field<string>("TenDV"),
                        DiaChi = row.Field<string>("DiaChi")
                    };
                    khachHangs.Add(khachHang);
                }
                return khachHangs;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng: ", ex);
            }
        }
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
