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
        private PhieuDangKyBUS pdkBus = new PhieuDangKyBUS(new PhieuDangKyDAO());
        private DichVuBUS dvBus = new DichVuBUS(new DataAccess.DichVuDAO());
        public MH_THANHTOANPHIEUDANGKY()
        {
            InitializeComponent();
            MH_THANHTOANPHIEUDANGKY_Load();
        }
        //public MH_THANHTOANPHIEUDANGKY(PhieuDangKyBUS phieuDangKyBUS)
        //{
        //    this.phieuDangKyBUS = phieuDangKyBUS;
        //    InitializeComponent();
        //    MH_THANHTOANPHIEUDANGKY_Load();
        //    btnXacNhan.Click += btnXacNhan_click;
        //    btnXemChiTietPhieu.Click += btnXemChiTietPhieu_click;
        //}
        private void MH_THANHTOANPHIEUDANGKY_Load()
        {
            List<PhieuDangKy> danhSachPhieuDangKy = pdkBus.LayDanhSach();
            dgvPhieuDangKy.DataSource = danhSachPhieuDangKy;
        }

        private void btnXemChiTietPhieu_click(object sender, EventArgs e)
        {

        }

        //private void btnXacNhan_click(object sender, EventArgs e)
        //{
        //    if (dgvPhieuDangKy.CurrentRow != null && dgvPhieuDangKy.CurrentRow.Cells["MaPhieuDangKy"].Value != null)
        //    {
        //        string maPhieuDangKy = dgvPhieuDangKy.CurrentRow.Cells["MaPhieuDangKy"].Value.ToString();
        //        if (maPhieuDangKy != null)
        //        {
        //            pdkBus.CapNhatTrangThaiPhieu(int.Parse(maPhieuDangKy));
        //        }
        //        else
        //        {
        //            MessageBox.Show("Phiếu đăng kí không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }


        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một phiếu đăng ký để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void dgvPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemChiTietPhieu_Click_1(object sender, EventArgs e)
        {
            if (dgvPhieuDangKy.CurrentRow != null && dgvPhieuDangKy.CurrentRow.Cells["MaPhieu"].Value != null)
            {
                string maPhieuDangKy = dgvPhieuDangKy.CurrentRow.Cells["MaPhieu"].Value.ToString();
                if (maPhieuDangKy != null)
                {
                    lblMaPhieu.Text = maPhieuDangKy;
                    List<DichVuView> chiTietPhieuDangKy =dvBus.GetDichVuViews(int.Parse(maPhieuDangKy));
                    dgvChiTietPhieu.DataSource = chiTietPhieuDangKy;
                    decimal tongThanhTien = 0;

                    foreach (DataGridViewRow row in dgvChiTietPhieu.Rows)
                    {
                        if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                        {
                            tongThanhTien += thanhTien;
                        }
                    }
                 
                    nudSoTien.Value = tongThanhTien;

                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu đăng ký để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
