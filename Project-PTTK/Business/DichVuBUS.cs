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
        private readonly DichVuDAO _dichVuDAO ;
        public DichVuBUS(DichVuDAO dichVuDAO)
        {
            _dichVuDAO = dichVuDAO;
        }
        public List<DichVu> LayDanhSach() => _dichVuDAO.getAll();
        public List<DichVuView> GetDichVuViews(int maphieu) => _dichVuDAO.getDichVuView(maphieu);
        public List<DichVuView> getDichVuHienCo () => _dichVuDAO.getDichVuHienCo();
    }
}
