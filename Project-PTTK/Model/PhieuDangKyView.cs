using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class PhieuDangKyView
    {
        public int MaPhieuDangKy { get; set; }
        public int MaKH { get; set; }
        public string? TenKH { get; set; }
        public string? LoaiKH { get; set; }
        public string? Email { get; set; }
        public DateOnly NgayTao { get; set; }
    }
}
