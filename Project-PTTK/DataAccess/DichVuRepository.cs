using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;

namespace Project_PTTK.DataAccess
{
    public class DichVuRepository
    {
        public DichVu? get(int MaDichVu)
        {
            DichVu? dichVu = null;
            try
            {
                const string query = "SELECT * FROM DichVu WHERE MaDichVu = @MaDichVu";
                SqlParameter[] parameters = { new SqlParameter("@MaDichVu", MaDichVu) };
                using DataTable dt = DBHelper.GetData(query,parameters);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    dichVu = new DichVu
                    {
                        MaDichVu = Convert.ToInt32(row["MaDichVu"]),
                        TenDichVu = row["TenDichVu"].ToString() ?? string.Empty,
                        Gia = Convert.ToDecimal(row["Gia"])
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dịch vụ: ",ex);
            }
            return dichVu;
        }

        public List<DichVu> getAll()
        {
            var list = new List<DichVu>();
            try
            {
                const string query = "SELECT * FROM DichVu";
                using DataTable dt = DBHelper.GetData(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    var dichVu = new DichVu
                    {
                        MaDichVu = Convert.ToInt32(row["MaDichVu"]),
                        TenDichVu = row["TenDichVu"].ToString() ?? string.Empty,
                        Gia = Convert.ToDecimal(row["Gia"])
                    };
                    list.Add(dichVu);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách dịch vụ: ",ex);
            }
            return list;
        }
    }
}
