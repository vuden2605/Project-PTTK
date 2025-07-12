using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class KhachHang
    {
        public int MaKH { get; set; }
        public string LoaiKhachHang { get; set; } = null!;
        public  string Email { get; set; } = null!;
        public KhachHang() { }
        public KhachHang(string loaiKhachHang, string email)
        {
            LoaiKhachHang = loaiKhachHang;
            Email = email;
        }
    }

    public class KhachHangTuDo : KhachHang
    {
        public string Ten { get; set; } = null!;
        public DateOnly NgaySinh { get; set; }
        public KhachHangTuDo (int MaKH,string ten, DateOnly ngaySinh) 
        {
            this.MaKH = MaKH;
            Ten = ten;
            NgaySinh = ngaySinh;
        }
        public KhachHangTuDo() { }
    }

    public class KhachHangDonVi: KhachHang
    {
        public string TenDonVi { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public KhachHangDonVi(int MaKH,string tenDonVi, string diaChi)
        {
            this.MaKH = MaKH;
            TenDonVi = tenDonVi;
            DiaChi = diaChi;
        }
        public KhachHangDonVi() { } // Constructor mặc định để sử dụng trong các thao tác khác

    }
}