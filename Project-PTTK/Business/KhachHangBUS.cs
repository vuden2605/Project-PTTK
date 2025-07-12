using Project_PTTK.DataAccess;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class KhachHangBUS
    {
        private readonly KhachHangDAO _khachHangDAO = new KhachHangDAO();
        public KhachHang? LayTheoMa(int maKH) => _khachHangDAO.get(maKH);
        public List<KhachHang> LayDanhSach() => _khachHangDAO.getAll();
    }
}
