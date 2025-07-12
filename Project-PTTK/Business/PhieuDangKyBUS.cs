using Project_PTTK.Model;
using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.DataAccess;

namespace Project_PTTK.Business
{
    public class PhieuDangKyBUS
    {
        private readonly PhieuDangKyDAO _phieuDangKyDAO;
        private readonly DichVuDAO _dichVuDAO;
        public PhieuDangKyBUS(PhieuDangKyDAO phieuDangKyDAO)
        {
            _phieuDangKyDAO = phieuDangKyDAO;
            _dichVuDAO = new DichVuDAO();
        }
        public List<PhieuDangKyView> LayDanhSach() => _phieuDangKyDAO.LayDanhSach();
        public PhieuDangKy? LayTheoMa(int maPhieuDangKy) => _phieuDangKyDAO.LayTheoMa(maPhieuDangKy);


        public void CapNhatTrangThaiPhieu(int maPhieuDangKy)
        {
            PhieuDangKy? phieuDangKy = LayTheoMa(maPhieuDangKy);
            if (phieuDangKy != null)
            {
                phieuDangKy.TrangThaiThanhToan = "Đã thanh toán";
                _phieuDangKyDAO.update(phieuDangKy,phieuDangKy);
            }
        }

        public void ThemPhieuDangKy(PhieuDangKy phieuDangKy) => _phieuDangKyDAO.add(phieuDangKy);
    }
}
