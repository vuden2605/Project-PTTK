﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Model
{   public class LichThi
    {
        public int MaLichThi { get; set; }
        public DateOnly NgayThi { get; set; }
        public TimeOnly GioThi { get; set; }
        public int SoThiSinhDaDangKy { get; set; }
        public int MaPhongThi { get; set; }
        public int MaDichVu { get; set; }
        public int NhanVienLap { get; set; }
    }
}
