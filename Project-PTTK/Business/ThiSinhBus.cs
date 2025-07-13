using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PTTK.DataAccess;
using Project_PTTK.Model;

namespace Project_PTTK.Business
{
    public class ThiSinhBus
    {
        private readonly ThiSinhDAO thiSinhDAO;
        public ThiSinhBus(ThiSinhDAO _thiSinhDAO)
        {
            this.thiSinhDAO = _thiSinhDAO;
        }
        public ThiSinh? LoadThongTinTS(int maTS)
        {
            return thiSinhDAO.loadThongTinThiSinh(maTS);
        }


        public void add(ThiSinh thiSinh)
        {
            thiSinhDAO.add(thiSinh);
        }

    }
    public class ThiSinhGetModel
    {
        public int MaTS { get; set; }
        public String HoTen { get; set; }
        public DateOnly NgaySinh { get; set; }
        public ThiSinhGetModel(int maTS, string hoTen, DateOnly ngaySinh)
        {
            MaTS = maTS;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        public static ThiSinhGetModel mapFromEntity(ThiSinh thiSinh)
        {
            return new ThiSinhGetModel(thiSinh.MaTS, thiSinh.HoTen, thiSinh.NgaySinh);
        }
    }
}
