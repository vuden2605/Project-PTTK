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
        public List<DichVuView> getDichVuView(int maphieu)
        {
            var list = new List<DichVuView>();

            try
            {
                const string query = @"
                    SELECT * FROM ChiTietPhieu ctp
                    JOIN LichThi lt ON ctp.MaLichThi = lt.MaLichThi
                    JOIN DichVu dv ON dv.MaDichVu = lt.MaDichVu
                    JOIN PhongThi pt ON pt.MaPhongThi = lt.MaPhongThi
                    WHERE ctp.MaPhieuDangKy = @maphieu;
                ";

                SqlParameter[] parameters = {
                    new SqlParameter("@maphieu", maphieu)
                };

                DataTable dt = DBHelper.ExecuteQuery(query, parameters);

                foreach (DataRow row in dt.Rows)
                {
                    var dichVuView = new DichVuView
                    {
                        maLichThi = row.Field<int>("MaLichThi"),
                        maDichVu = row.Field<int>("MaDichVu"),
                        tenDichVu = row.Field<string>("TenDichVu") ?? string.Empty,
                        ngayThi = DateOnly.FromDateTime(row.Field<DateTime>("NgayThi")),
                        gioThi = TimeOnly.FromTimeSpan(row.Field<TimeSpan>("GioThi")),
                        phongThi = row.Field<string>("TenPhong") ?? string.Empty,
                        soLuongTsDaDangKy = row.Field<int>("SoTsDaDangKy"),
                        soLuongTsToiDa = row.Field<int>("SoThiSinhToiDa"),
                        soLuong = Convert.ToDecimal(row["SoLuong"]),
                        gia = Convert.ToDecimal(row["Gia"])
                    };

                    list.Add(dichVuView);
                }
            }
            catch (Exception ex)
            {
                string errorDetail =
                    $"Lỗi khi lấy danh sách phiếu đăng ký:\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}";
                Console.WriteLine(errorDetail);
                throw new Exception(errorDetail, ex);
            }

            return list;
        }
        public List<DichVuView> getDichVuHienCo()
        {
            var list = new List<DichVuView>();

            try
            {
                const string query = @"
             SELECT  * FROM 
                LichThi lt
                JOIN DichVu dv ON dv.MaDichVu = lt.MaDichVu
                JOIN PhongThi pt ON pt.MaPhongThi = lt.MaPhongThi
                WHERE lt.SoTsDaDangKy < pt.SoThiSinhToiDa;
            ";

                DataTable dt = DBHelper.ExecuteQuery(query, null); // không cần parameters

                foreach (DataRow row in dt.Rows)
                {
                    var dichVuView = new DichVuView
                    {
                        maLichThi = row.Field<int>("MaLichThi"),
                        maDichVu = row.Field<int>("MaDichVu"),
                        tenDichVu = row.Field<string>("TenDichVu") ?? string.Empty,
                        ngayThi = DateOnly.FromDateTime(row.Field<DateTime>("NgayThi")),
                        gioThi = TimeOnly.FromTimeSpan(row.Field<TimeSpan>("GioThi")),
                        phongThi = row.Field<string>("TenPhong") ?? string.Empty,
                        soLuongTsDaDangKy = row.Field<int>("SoTsDaDangKy"),
                        soLuongTsToiDa = row.Field<int>("SoThiSinhToiDa"),
                       
                    };

                    list.Add(dichVuView);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách dịch vụ hiện có: ", ex);
            }

            return list;
        }

    }
}
