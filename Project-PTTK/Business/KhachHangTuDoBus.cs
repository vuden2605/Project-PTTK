using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;
using Project_PTTK.DataAccess;
namespace Project_PTTK.Business
{
    public class KhachHangTuDoBus
    {
        private readonly KhachHangTuDoDAO _khachHangTuDoDAO;
        public KhachHangTuDoBus(KhachHangTuDoDAO khachHangTuDoDAO)
        {
            _khachHangTuDoDAO = khachHangTuDoDAO;
        }
        public int AddKhachHangTuDo(KhachHangTuDo khachHang)
        {
            return _khachHangTuDoDAO.add(khachHang);
        }
        public List<KhachHangTuDo> GetAllKhachHangTuDo()
        {
            return _khachHangTuDoDAO.getAll();
        }
    }
}
