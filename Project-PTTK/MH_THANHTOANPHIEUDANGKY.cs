using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_PTTK.Business;
using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.Model;

namespace Project_PTTK
{
    public partial class MH_THANHTOANPHIEUDANGKY : Form
    {
        private PhieuDangKyBUS phieuDangKyBUS;
        private ChiTietPhieuDangKyDAO chiTietPhieuDangKyDAO;

        public MH_THANHTOANPHIEUDANGKY(PhieuDangKyBUS phieuDangKyBUS)
        {
            this.phieuDangKyBUS = phieuDangKyBUS;
            InitializeComponent();
            MH_THANHTOANPHIEUDANGKY_Load();
            btnXacNhan.Click += btnXacNhan_click;
            btnXemChiTietPhieu.Click += btnXemChiTietPhieu_click;
        }
        private void MH_THANHTOANPHIEUDANGKY_Load()
        {
            List<PhieuDangKy> danhSachPhieuDangKy = phieuDangKyBUS.LayDanhSach();
            dgvPhieuDangKy.DataSource = danhSachPhieuDangKy;
        }

        private void btnXemChiTietPhieu_click(object sender, EventArgs e)
        {
            if (dgvPhieuDangKy.CurrentRow != null && dgvPhieuDangKy.CurrentRow.Cells["MaPhieuDangKy"].Value != null)
            {
                string maPhieuDangKy = dgvPhieuDangKy.CurrentRow.Cells["MaPhieuDangKy"].Value.ToString();
                if (maPhieuDangKy != null)
                {
                    List<ChiTietPhieuDangKy> chiTietPhieuDangKy = chiTietPhieuDangKyDAO.getByMaPhieu(int.Parse(maPhieuDangKy));
                    dgvChiTietPhieu.DataSource = chiTietPhieuDangKy;
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu đăng ký để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXacNhan_click(object sender, EventArgs e)
        {
            if (dgvPhieuDangKy.CurrentRow != null && dgvPhieuDangKy.CurrentRow.Cells["MaPhieuDangKy"].Value != null)
            {
                string maPhieuDangKy = dgvPhieuDangKy.CurrentRow.Cells["MaPhieuDangKy"].Value.ToString();
                if (maPhieuDangKy != null)
                {
                    phieuDangKyBUS.CapNhatTrangThaiPhieu(int.Parse(maPhieuDangKy));
                }
                else
                {
                    MessageBox.Show("Phiếu đăng kí không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
          

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu đăng ký để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
