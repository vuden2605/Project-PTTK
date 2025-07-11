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
        public int MaKH { get; set; }
        public int MaLichThi { get; set; }
    }

    public class ChungChi
    {
        public int MaChungChi { get; set; }
        public DateOnly NgayCap { get; set; }
        public string TrangThai { get; set; } = null!;
        public decimal KetQua { get; set; }
        public int MaTS { get; set; }
        public int NhanVienLap { get; set; }
    }
}
