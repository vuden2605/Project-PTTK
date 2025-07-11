using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class PhieuGiaHanBUS
    {
        private readonly PhieuGiaHanDAO _phieuGiaHanDAO;
        private readonly PhieuDangKyDAO _phieuDangKyDAO;

        public PhieuGiaHanBUS(PhieuGiaHanDAO phieuGiaHanDAO, PhieuDangKyDAO phieuDangKyDAO)
        {
            _phieuGiaHanDAO = phieuGiaHanDAO;
            _phieuDangKyDAO = phieuDangKyDAO;
        }

        public List<PhieuGiaHan> LayDanhSach() => _phieuGiaHanDAO.LayDanhSach();

        public PhieuGiaHan? LayTheoMa(int maPhieuGiaHan) => _phieuGiaHanDAO.LayTheoMa(maPhieuGiaHan);

        public void TaoPhieu(PhieuGiaHan phieuGiaHan)
        {
            if (phieuGiaHan == null)
                throw new ArgumentNullException(nameof(phieuGiaHan));

            if (string.IsNullOrWhiteSpace(phieuGiaHan.LyDo))
                throw new ArgumentException("Lý do không được để trống.", nameof(phieuGiaHan.LyDo));

            if (_phieuDangKyDAO.LayTheoMa(phieuGiaHan.MaPhieuDangKy) == null)
                throw new ArgumentException("Phiếu đăng ký không tồn tại.", nameof(phieuGiaHan.MaPhieuDangKy));

            _phieuGiaHanDAO.Them(phieuGiaHan);
        }
    }
}
