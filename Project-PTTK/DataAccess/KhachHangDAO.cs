using Project_PTTK.Model;
using System.Data;
using System.Data.SqlClient;
{
    
}

namespace Project_PTTK.DataAccess
{
    public class KhachHangDAO
    {
        public KhachHang? get(int MaKH)
        {
            KhachHang? khachHang = null;
            try
            {
                string query = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
                SqlParameter[] parameters = { new SqlParameter("@MaKH", MaKH) };
                DataTable dataTable = DBHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    khachHang = new KhachHang
                    {
                        MaKH = row.Field<int>("MaKH"),
                        LoaiKhachHang = row.Field<string>("LoaiKhachHang") ?? string.Empty,
                        Email = row.Field<string>("Email") ?? string.Empty
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy khách hàng: ", ex);
            }
            return khachHang;
        }
        public List<KhachHang> getAll()
        {
            try
            {
                string query = "SELECT * FROM KhachHang";
                DataTable dataTable = DBHelper.ExecuteQuery(query,null);
                List<KhachHang> khachHangs = new List<KhachHang>();
                foreach (DataRow row in dataTable.Rows)
                {
                    KhachHang khachHang = new KhachHang
                    {
                        MaKH = row.Field<int>("MaKH"),
                        LoaiKhachHang = row.Field<string>("LoaiKhachHang"),
                        Email = row.Field<string>("Email")
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
        public void add(KhachHang khachHang)
        {
            try
            {
                string query = "INSERT INTO KhachHang (LoaiKhachHang, Email) VALUES (@LoaiKhachHang, @Email)";
                SqlParameter[] parameters = {
                    new SqlParameter("@LoaiKhachHang", khachHang.LoaiKhachHang),
                    new SqlParameter("@Email", khachHang.Email)
                };
                int row = DBHelper.ExecuteNonQuery(query, parameters);
                if (row <= 0)
                {
                    throw new Exception("Không thể thêm khách hàng");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: ", ex);
            }
        }
    }
}
