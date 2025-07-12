using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{
    public class DichVuView
    {
        public string? tenDichVu { get; set; }
        public int? maLichThi { get; set; }
        public DateOnly? ngayThi { get; set; }
        public TimeOnly? gioThi { get; set; }
        public string? phongThi { get; set; }
        public int? soLuongTsToiDa { get; set; }
        public int? soLuongTsDaDangKy { get; set; }


    }
}
