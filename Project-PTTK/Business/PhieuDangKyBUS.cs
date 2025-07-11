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
        public List<PhieuDangKy> LayDanhSach() => _phieuDangKyDAO.LayDanhSach();
        public PhieuDangKy? LayTheoMa(int maPhieuDangKy) => _phieuDangKyDAO.LayTheoMa(maPhieuDangKy);
        public string LayTenDichVu(int maPhieuDangKy)
        {
            var phieuDangKy = _phieuDangKyDAO.LayTheoMa(maPhieuDangKy);
            if (phieuDangKy == null) return string.Empty;
            var dichVu = _dichVuDAO.get(phieuDangKy.Ma);
        }
    }
}
