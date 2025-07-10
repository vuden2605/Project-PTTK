using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string MatKhau { get; set; } = null!;
        public string HoTen { get; set; } = null!;
        public string SDT { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string VaiTro { get; set; } = null!;
        public decimal Luong { get; set; }
    }
}
