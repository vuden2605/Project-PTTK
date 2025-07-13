using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.DataAccess;
using Project_PTTK.Model;
using Microsoft.Data.SqlClient;

namespace Project_PTTK.Business
{
    public class ChungChiBus
    {
        private readonly ChungChiDAO chungChiDAO;
        public ChungChiBus(ChungChiDAO _chungChiDAO)
        {
            this.chungChiDAO = _chungChiDAO;
        }

        public void ThemChungChi(ChungChiCreateModel model)
        {
            ChungChi chungChi = model.toEntity();
            chungChiDAO.ThemChungChi(chungChi);
        }
        public bool KiemTraTonTaiChungChi(int maTS)
        {
            string query = "SELECT COUNT(*) FROM ChungChi WHERE MaTS = @MaTS";
            SqlParameter[] parameters = {
        new SqlParameter("@MaTS", maTS)
    };

            int count = (int)DBHelper.ExecuteScalar(query, parameters); // Giả sử bạn có lớp DBHelper
            return count > 0;
        }
    }
    public class ChungChiCreateModel
    {
        public int MaTS { get; set; }
        public int KetQua { get; set; }
        public int NvLap { get; set; }
        public ChungChiCreateModel(int maTS, int ketQua)
        {
            MaTS = maTS;
            KetQua = ketQua;
        }
        public ChungChi toEntity()
        {
            ChungChi chungChi = new ChungChi();
            chungChi.KetQua = this.KetQua;
            chungChi.NgayCap = DateOnly.FromDateTime(DateTime.Now);
            chungChi.TrangThai = "CHƯA CẤP";
            chungChi.MaTS = this.MaTS;
            chungChi.NhanVienLap = this.NvLap;
            return chungChi;
        }
    }
}
