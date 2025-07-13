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
        public int MaPhieuDangKy { get; set; }
        public override string ToString()
        {
            return $"Mã TS: {MaTS}, Họ tên: {HoTen}, Mã phiếu: {MaPhieuDangKy}, Ngày sinh: {NgaySinh}";
        }

        public ThiSinh(string hoTen, DateOnly ngaySinh, string cccd, string gioiTinh, string trangThaiPhatHanhPhieuDuThi, int maLichThi, int maPhieuDangKy)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            CCCD = cccd;
            GioiTinh = gioiTinh;
            TrangThaiPhatHanhPhieuDuThi = trangThaiPhatHanhPhieuDuThi;
            MaLichThi = maLichThi;
            MaPhieuDangKy = maPhieuDangKy;
        }
        public ThiSinh () { }
    }

    public class ChungChi
    {
        public int MaChungChi { get; set; }
        public int MaTS { get; set; }
        public DateOnly NgayCap { get; set; } 
        public string TrangThai { get; set; } = "Đã cấp";
        public decimal KetQua { get; set; }
        
        public int NhanVienLap { get; set; }
        
    }
}
