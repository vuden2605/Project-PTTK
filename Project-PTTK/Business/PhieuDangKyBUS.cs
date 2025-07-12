using Project_PTTK.DataAccess;
using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.Model;
using System.Data;

namespace Project_PTTK.Business
{
    public class PhieuDangKyBUS
    {
        private readonly PhieuDangKyDAO _phieuDangKyDAO;
        private readonly DichVuDAO _dichVuDAO;
        private readonly KhachHangDAO _khachHangDAO;
        private readonly KhachHangDonViDAO _khachHangDonViDAO;
        private readonly KhachHangTuDoDAO _khachHangTuDoDAO;
        public PhieuDangKyBUS()
        {
            _phieuDangKyDAO = new PhieuDangKyDAO();
            _dichVuDAO = new DichVuDAO();
            _khachHangDAO = new KhachHangDAO();
            _khachHangDonViDAO = new KhachHangDonViDAO();
            _khachHangTuDoDAO = new KhachHangTuDoDAO();
        }
        public List<PhieuDangKy> LayDanhSach() => _phieuDangKyDAO.LayDanhSach();
        public PhieuDangKy? LayTheoMa(int maPhieuDangKy) => _phieuDangKyDAO.LayTheoMa(maPhieuDangKy);
        public void ThemPhieuDangKy(PhieuDangKy phieuDangKy) => _phieuDangKyDAO.add(phieuDangKy);
        public List<PhieuDangKyView> LayDanhSachCoTenKhachHang()
        {
            var list = new List<PhieuDangKyView>();
            _phieuDangKyDAO.LayDanhSach().ForEach(phieu =>
            {
                var khachHang = _khachHangDAO.get(phieu.MaKH);
                //Convert to khachHangTuDo if LoaiKhachHang is "Tự do"
                if (khachHang != null)
                {
                    if (khachHang.LoaiKhachHang == "Tự do")
                    {
                        var khachHangTuDo = _khachHangTuDoDAO.get(phieu.MaKH);
                        if (khachHangTuDo != null)
                        {
                            list.Add(new PhieuDangKyView
                            {
                                MaPhieuDangKy = phieu.MaPhieu,
                                MaKH = khachHangTuDo.MaKH,
                                TenKH = khachHangTuDo.Ten,
                                LoaiKH = khachHang.LoaiKhachHang,
                                NgayTao = phieu.NgayTao,
                                Email = phieu.TrangThaiThanhToan
                            });
                        }
                    }
                    else if (khachHang.LoaiKhachHang == "Đơn vị")
                    {
                        var khachHangDonVi = _khachHangDonViDAO.get(phieu.MaKH);
                        if (khachHangDonVi != null)
                        {
                            list.Add(new PhieuDangKyView
                            {
                                MaPhieuDangKy = phieu.MaPhieu,
                                MaKH = khachHangDonVi.MaKH,
                                TenKH = khachHangDonVi.TenDonVi,
                                LoaiKH = khachHang.LoaiKhachHang,
                                NgayTao = phieu.NgayTao,
                                Email = khachHangDonVi.Email,
                            });
                        }
                    }
                }
            });

            return list;
        }
    }
}
