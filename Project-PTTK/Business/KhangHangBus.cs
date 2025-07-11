using Project_PTTK.DataAccess;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class KhangHangBus
    {
        private readonly KhachHangDAO _khachhangDAO;
        public KhangHangBus(KhachHangDAO khachhangDAO)
        {
            _khachhangDAO = khachhangDAO;
        }
        public KhachHang? GetKhachHang(int maKH)
        {
            return _khachhangDAO.get(maKH);
        }
        public List<KhachHang> GetAllKhachHang()
        {
            return _khachhangDAO.getAll();
        }
        public int AddKhachHang(KhachHang khachHang)
        {
            return _khachhangDAO.add(khachHang);
        }

    }
}
