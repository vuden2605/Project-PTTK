using Project_PTTK.Model;
using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.DataAccess;

namespace Project_PTTK.Business
{
    public class PhieuDangKyBUS
    {
        private readonly PhieuDangKyDAO _phieuDangKyDAO;
        private readonly DichVuDAO _dichVuDAO;
        private readonly ChiTietPhieuDangKyDAO _chiTietPhieuDangKyDAO;
        public PhieuDangKyBUS(PhieuDangKyDAO phieuDangKyDAO)
        {
            _phieuDangKyDAO = phieuDangKyDAO;
            _dichVuDAO = new DichVuDAO();
            _chiTietPhieuDangKyDAO = new ChiTietPhieuDangKyDAO();
        }
        public List<PhieuDangKyView> LayDanhSachPDKV() => _phieuDangKyDAO.LayDanhSachPDKV();
        public PhieuDangKy? LayTheoMa(int maPhieuDangKy) => _phieuDangKyDAO.LayTheoMa(maPhieuDangKy);
        public void ThemPhieuDangKy(PhieuDangKy phieuDangKy) => _phieuDangKyDAO.add(phieuDangKy);
        public List<ThiSinh> getThiSinhByPhieuDangKy(int maPhieuDangKy)
        {
            return _phieuDangKyDAO.getThiSinhByPhieuDangKy(maPhieuDangKy);
        }
        public void TangSoLuongThiSinhDangKy(int maPhieu, int maLichThi)
        {
            try
            {
                _chiTietPhieuDangKyDAO.TangSoLuongThiSinh(maPhieu, maLichThi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tăng số lượng thí sinh đã đăng ký: ", ex);
            }
        }
    }
}
