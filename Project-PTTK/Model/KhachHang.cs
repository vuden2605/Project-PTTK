using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class KhachHang()
    {
        public int MaKH { get; set; }
        public string LoaiKhachHang { get; set; } = null!;
        public required string Email { get; set; } = null!;
    }

    public class KhachHangTuDo : KhachHang
    {
        public string Ten { get; set; } = null!;
        public DateOnly NgaySinh { get; set; }
    }

    public class KhachHangDonVi: KhachHang
    {
        public string TenDichVu { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
    }
}