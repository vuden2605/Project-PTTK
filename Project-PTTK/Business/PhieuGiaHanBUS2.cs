using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class PhieuGiaHanBUS2
    {
        private readonly PhieuGiaHanDAO phieuGiaHanDAO = new PhieuGiaHanDAO();
        public List<PhieuGiaHan> LayDanhSach()
        {
            List<PhieuGiaHan> phieuGiaHans = phieuGiaHanDAO.LayDanhSach();
            return phieuGiaHans;
        }
        public PhieuGiaHan? LayTheoMa(int maPhieuGiaHan)
        {
            PhieuGiaHan? phieuGiaHan = phieuGiaHanDAO.LayTheoMa(maPhieuGiaHan);
            return phieuGiaHan;
        }
        public void TaoPhieu(PhieuGiaHan phieuGiaHan)
        {
            phieuGiaHanDAO.Them(phieuGiaHan);
        }
        
    }
}
