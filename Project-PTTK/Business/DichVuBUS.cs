using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.DataAccess;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class DichVuBUS
    {
        private readonly DichVuDAO _dichVuDAO = new DichVuDAO();
        public DichVuBUS(DichVuDAO dichVuDAO)
        {
            _dichVuDAO = dichVuDAO;
        }
        public List<DichVu> LayDanhSach() => _dichVuDAO.getAll();
    }
}
