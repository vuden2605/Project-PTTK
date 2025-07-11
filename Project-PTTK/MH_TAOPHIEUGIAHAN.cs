using Project_PTTK.Business;
using Project_PTTK.DataAccess.Phieu;

namespace Project_PTTK
{
    public partial class MH_TAOPHIEUGIAHAN : Form
    {
        private PhieuGiaHanBUS phieuGiaHanBUS = new PhieuGiaHanBUS(new PhieuGiaHanDAO(), new PhieuDangKyDAO());
        public MH_TAOPHIEUGIAHAN()
        {
            InitializeComponent();
        }

        private void MH_TAOPHIEUGIAHAN_Load(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
