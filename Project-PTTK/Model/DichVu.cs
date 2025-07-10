using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class DichVu
    {
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; } = null!;
        public decimal Gia { get; set; }
    }

    public class PhongThi
    {
        public int MaPhongThi { get; set; }
        public string TenPhong { get; set; } = null!;
    }
}
