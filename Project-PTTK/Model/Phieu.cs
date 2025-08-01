﻿using System;
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
        
        public int MaKH { get; set; }
        public int NhanVienLap { get; set; }
        public PhieuDangKy (int maKH)
        {
            MaKH = maKH;
            NgayTao = DateOnly.FromDateTime(DateTime.Now);
            TrangThaiThanhToan = "Chưa thanh toán";
            NhanVienLap = Session.MaNV; 
        }
        //public PhieuDangKy (int maphieu, DateOnly NgayTao, string TrangThaiThanhToan, int MaKH,int NhanVienLap) {
        //    MaPhieu = maphieu;
        //    NgayTao = NgayTao;
        //    TrangThaiThanhToan = TrangThaiThanhToan;
        //    MaKH = MaKH;
        //    NhanVienLap = NhanVienLap;
        //}
        public PhieuDangKy() { } // Constructor mặc định để sử dụng trong các thao tác khác
    }

    public class ChiTietPhieuDangKy
    {
        public int MaPhieu { get; set; }
        public int MaLichThi { get; set; }
        public int SoLuong { get; set; }
        public ChiTietPhieuDangKy(int maPhieu, int maLichThi, int soLuong)
        {
            MaPhieu = maPhieu;
            MaLichThi = maLichThi;
            SoLuong = soLuong;
        }
        public ChiTietPhieuDangKy() { }

    }
    public class PhieuGiaHan
    {
        public int MaPhieuGiaHan { get; set; }
        public DateOnly NgayTao { get; set; }
        public string? LyDo { get; set; } 
        public string TrangThaiThanhToan { get; set; } = null!;
        public int MaNV { get; set; }

        public int MaPhieuDangKy { get; set; }
        public int MaLichThi { get; set; }
    }
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public decimal TongTien { get; set; }
        public decimal ChietKhau { get; set; }
        public string ? PhuongThucThanhToan { get; set; } = null!;
        public DateOnly NgayTao { get; set; }
        public string Loai { get; set; } = null!;
        public int NhanVienLap { get; set; }
        public int? MaPhieuDangKy { get; set; }
        public int? MaPhieuGiaHan { get; set; }
    }
}