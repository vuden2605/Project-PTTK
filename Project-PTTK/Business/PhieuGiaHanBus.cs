using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.DataAccess;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class PhieuGiaHanBus
    {
        private readonly PhieuGiaHanDAO phieuGiaHanDAO;
        public PhieuGiaHanBus(PhieuGiaHanDAO _phieuGiaHanDAO)
        {
            phieuGiaHanDAO = _phieuGiaHanDAO;
        }
        public int TinhSoTien(String LyDo)
        {
            return phieuGiaHanDAO.TinhSoTien(LyDo);
        }
        public void CapNhatTrangThaiPhieuGH(PhieuGiaHanModel phieuGiaHan)
        {
            
            phieuGiaHanDAO.CapNhatTrangThaiPhieuGH(phieuGiaHan.mapToEntity());
        }
        public List<PhieuGiaHanModel> LoadDSPhieuGH()
        {
            List<PhieuGiaHan> phieuGiaHans = phieuGiaHanDAO.LoadDSPhieuGH();
            return [.. phieuGiaHans.Select(PhieuGiaHanModel.mapFromEntity)];
        }
        public PhieuGiaHanModel LoadThongTinPhieuGH(int maPhieuGiaHan)
        {
            PhieuGiaHan phieuGiaHan = phieuGiaHanDAO.LoadThongTinPhieuGH(maPhieuGiaHan);
            return PhieuGiaHanModel.mapFromEntity(phieuGiaHan);
        }
        public void ThemPhieuGiaHan (PhieuGiaHan phieuGiaHan)
        {
            phieuGiaHanDAO.ThemPhieuGiaHan(phieuGiaHan);
        }
    }

    public class PhieuGiaHanModel
    {
        public int MaPhieuDangKy { get; set; }
        public int MaPhieuGiaHan { get; set; }
        public int MaKhachHang { get; set; }
        public int MaLichThi { get; set; }
        public String LyDo { get; set; } = null!;
        public String TrangThaiThanhToan { get; set; } = null!;

        public PhieuGiaHan mapToEntity()
        {
            PhieuGiaHan phieuGiaHan = new PhieuGiaHan();
            phieuGiaHan.MaPhieuDangKy = this.MaPhieuDangKy;
            phieuGiaHan.MaPhieuGiaHan = this.MaPhieuGiaHan;
            phieuGiaHan.LyDo = this.LyDo;
            phieuGiaHan.TrangThaiThanhToan = this.TrangThaiThanhToan;
            phieuGiaHan.NgayTao = DateOnly.FromDateTime(DateTime.Now);
            return phieuGiaHan;
        }
        public static PhieuGiaHanModel mapFromEntity(PhieuGiaHan phieuGiaHan)
        {
            PhieuGiaHanModel model = new PhieuGiaHanModel();
            model.MaPhieuDangKy = phieuGiaHan.MaPhieuDangKy;
            model.MaPhieuGiaHan = phieuGiaHan.MaPhieuGiaHan;
            model.MaKhachHang = phieuGiaHan.MaKhachHang; 
            model.MaLichThi = phieuGiaHan.MaLichThi;
            model.LyDo = phieuGiaHan.LyDo;
            model.TrangThaiThanhToan = phieuGiaHan.TrangThaiThanhToan;
            return model;
        }

    }
}
