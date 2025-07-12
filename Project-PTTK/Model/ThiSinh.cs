using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class ThiSinh
    {
        public int MaTS { get; set; }
        public string HoTen { get; set; } = null!;
        public DateOnly NgaySinh { get; set; }
        public string CCCD { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public string TrangThaiPhatHanhPhieuDuThi { get; set; } = null!;
        public int MaLichThi { get; set; }

        public ThiSinh(string hoTen, DateOnly ngaySinh, string cccd, string gioiTinh, string trangThaiPhatHanhPhieuDuThi, int maLichThi)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            CCCD = cccd;
            GioiTinh = gioiTinh;
            TrangThaiPhatHanhPhieuDuThi = trangThaiPhatHanhPhieuDuThi;
            MaLichThi = maLichThi;
        }
        public ThiSinh () { }
    }

    public class ChungChi
    {
        public int MaChungChi { get; set; }
        public DateOnly NgayCap { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string TrangThai { get; set; } = "CHƯA CẤP";
        public decimal KetQua { get; set; }
        public int MaTS { get; set; }
        public int NhanVienLap { get; set; }
    }
}
