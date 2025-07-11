using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.Model;
using Project_PTTK.DataAccess;

namespace Project_PTTK.Business
{
    public class KhachHangDonViBus
    {
        private readonly KhachHangDonViDAO _khachhangdonviDAO;
        public KhachHangDonViBus(KhachHangDonViDAO khachhang)
        {
            _khachhangdonviDAO = khachhang;
        }
        public int AddKhachHangDonVi(KhachHangDonVi khachHang)
        {
            return _khachhangdonviDAO.add(khachHang);
        }

    }
}
