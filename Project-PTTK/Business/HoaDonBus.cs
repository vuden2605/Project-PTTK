using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.DataAccess;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class HoaDonBus
    {
        private readonly HoaDonDAO hoaDonDAO;
        public HoaDonBus(HoaDonDAO _hoaDonDAO)
        {
            this.hoaDonDAO = _hoaDonDAO;
        }
        public void ThemHoaDon(HoaDon hoadon)
        {
            
            hoaDonDAO.ThemHoaDon(hoadon);
        }


    }
    //public class HoaDonCreateModel
    //{
    //    public int MaPhieuGiaHan { get; set; }
    //    public float TongTien { get; set; }
    //    public int ChietKhau { get; set; }
    //    public String PhuongThucThanhToan { get; set; } = null!;
    //    public HoaDon toEntity()
    //    {
    //        HoaDon hoaDon = new HoaDon();
    //        hoaDon.MaPhieuGiaHan = this.MaPhieuGiaHan;
    //        hoaDon.TongTien = (int)this.TongTien;
    //        hoaDon.ChietKhau = this.ChietKhau;
    //        hoaDon.NgayTao = DateOnly.FromDateTime(DateTime.Now);
    //        return hoaDon;
    //    }
    //}
}
