using Project_PTTK.Business;
using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.Model;
using System.Security.AccessControl;

namespace Project_PTTK
{
    public partial class MH_TAOPHIEUGIAHAN : Form
    {
        private PhieuGiaHanBUS phieuGiaHanBUS = new PhieuGiaHanBUS(new PhieuGiaHanDAO(), new PhieuDangKyDAO());
        private PhieuDangKyBUS phieuDangKyBUS = new PhieuDangKyBUS(new PhieuDangKyDAO());
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private DichVuBus = new DichVuBUS();
        public MH_TAOPHIEUGIAHAN()
        {
            InitializeComponent();
        }

        private void MH_TAOPHIEUGIAHAN_Load(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            var phieuDangKy = phieuDangKyBUS.LayTheoMa(int.Parse(txtMaPhieu.Text));
            if (phieuDangKy != null)
            {
                var maKhachHang = phieuDangKy.MaKH;
                var khachHang = khachHangBUS.LayTheoMa(maKhachHang);
                if (khachHang != null && khachHang.LoaiKhachHang == "Tự do")
                {
                    txtTenKH.Text = khachHang. 

                }
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
