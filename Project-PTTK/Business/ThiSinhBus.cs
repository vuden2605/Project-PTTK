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
        public ThiSinhModel loadThongTinTS(int maTS)
        {
            ThiSinh thiSinh = thiSinhDAO.loadThongTinThiSinh(maTS);
            return ThiSinhModel.mapFromEntity(thiSinh);
        }

    }
    public class ThiSinhModel
    {
        public int MaTS { get; set; }
        public String HoTen { get; set; }
        public DateOnly NgaySinh { get; set; }
        public ThiSinhModel(int maTS, string hoTen, DateOnly ngaySinh)
        {
            MaTS = maTS;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        public static ThiSinhModel mapFromEntity(ThiSinh thiSinh)
        {
            return new ThiSinhModel(thiSinh.MaTS, thiSinh.HoTen, thiSinh.NgaySinh);
        }
    }
}
