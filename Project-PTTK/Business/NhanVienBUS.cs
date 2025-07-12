using Project_PTTK.DataAccess;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAO _nhanVienDAO;
        public NhanVienBUS()
        {
            _nhanVienDAO = new NhanVienDAO();
        }
        public List<NhanVien> getAllNhanVienInfo() => _nhanVienDAO.GetAllNhanVienInfo();
        public NhanVien? GetNhanVienInfo(int id) => _nhanVienDAO.GetNhanVienInfo(id);
        public int Authenticate(string email, string password)
        {
            try
            {
                return _nhanVienDAO.Authenticate(email, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xác thực nhân viên: ", ex);
            }
        }
    }
}
