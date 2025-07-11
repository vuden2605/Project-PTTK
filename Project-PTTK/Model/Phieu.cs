using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class PhieuDangKy
    {
        public int MaPhieu { get; set; }
        public DateOnly NgayTao { get; set; }
        public string TrangThaiThanhToan { get; set; } = null!;
        public string PhuongThucThanhToan { get; set; } = null!;
        public int MaKH { get; set; }
        public int NhanVienLap { get; set; }
    }

    public class ChiTietPhieuDangKy
    {
        public int MaPhieu { get; set; }
        public int SoLuong { get; set; }
    }
    public class PhieuGiaHan
    {
        public int MaPhie { get; set; }
        public DateOnly NgayTao { get; set; }
        public string LyDo { get; set; } = null!;
        public string TrangThaiThanhToan { get; set; } = null!;
        public int MaPhieuDangKy { get; set; }
    }
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public decimal TongTien { get; set; }
        public decimal ChietKhau { get; set; }
        public DateOnly NgayTao { get; set; }
        public string Loai { get; set; } = null!;
        public int NhanVienLap { get; set; }
        public int? MaPhieuDangKy { get; set; }
        public int? MaPhieuGiaHan { get; set; }
    }
}