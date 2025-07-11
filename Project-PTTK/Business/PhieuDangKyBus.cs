using Project_PTTK.Model;
using Project_PTTK.DataAccess.Phieu;

namespace Project_PTTK.Business
{
    public class PhieuDangKyBUS
    {
        private readonly PhieuDangKyDAO _phieuDangKyDAO;
        public PhieuDangKyBUS(PhieuDangKyDAO phieuDangKyDAO)
        {
            _phieuDangKyDAO = phieuDangKyDAO;
        }
        public List<PhieuDangKy> LayDanhSach() => _phieuDangKyDAO.LayDanhSach();
        public PhieuDangKy? LayTheoMa(int maPhieuDangKy) => _phieuDangKyDAO.LayTheoMa(maPhieuDangKy);
    }
}
