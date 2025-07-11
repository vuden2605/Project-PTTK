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
    public class DichVuDAO
    {
        public DichVu? get(int MaDichVu)
        {
            DichVu? dichVu = null;
            try
            {
                const string query = "SELECT * FROM DichVu WHERE MaDichVu = @MaDichVu";
                SqlParameter[] parameters = { new SqlParameter("@MaDichVu", MaDichVu) };
                using DataTable dt = DBHelper.ExecuteQuery(query,parameters);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    dichVu = new DichVu
                    {
                        MaDichVu = row.Field<int>("MaDichVu"),
                        TenDichVu = row.Field<string>("TenDichVu") ?? string.Empty,
                        Gia = row.Field<decimal>("Gia")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dịch vụ: ",ex);
            }
            return dichVu;
        }

        public List<DichVu> getByTen(string tenDichVu)
        {
            var list = new List<DichVu>();
            try
            {
                const string query = "SELECT * FROM DichVu WHERE TenDichVu LIKE @TenDichVu";
                SqlParameter[] parameters = { new SqlParameter("@TenDichVu", "%" + tenDichVu + "%") };
                using DataTable dt = DBHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    var dichVu = new DichVu
                    {
                        MaDichVu = row.Field<int>("MaDichVu"),
                        TenDichVu = row.Field<string>("TenDichVu") ?? string.Empty,
                        Gia = row.Field<decimal>("Gia")
                    };
                    list.Add(dichVu);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm dịch vụ: ",ex);
            }
            return list;
        }

        public List<DichVu> getAll()
        {
            var list = new List<DichVu>();
            try
            {
                const string query = "SELECT * FROM DichVu";
                using DataTable dt = DBHelper.ExecuteQuery(query, null);
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
