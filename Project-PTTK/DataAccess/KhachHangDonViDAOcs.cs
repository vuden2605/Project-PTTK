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
        public KhachHangDonVi? get(int MaKH)
        {
            try
            {
                string query = "SELECT * FROM KhachHangDonVi WHERE MaKH = @MaKH";
                SqlParameter[] parameters = { new SqlParameter("@MaKH", MaKH) };
                DataTable dataTable = DBHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new KhachHangDonVi
                    {
                        MaKH = row.Field<int>("MaKH"),
                        TenDonVi = row.Field<string>("TenDV") ?? string.Empty,
                        DiaChi = row.Field<string>("DiaChi") ?? string.Empty,
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy khách hàng: ", ex);
            }
        }
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
