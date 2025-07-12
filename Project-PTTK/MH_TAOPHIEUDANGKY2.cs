using Project_PTTK.Business;
using Project_PTTK.DataAccess;
using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PTTK
{
    public partial class MH_TAOPHIEUDANGKY2 : Form
    {
        public MH_TAOPHIEUDANGKY2()
        {
            InitializeComponent();
            
        }
        public MH_TAOPHIEUDANGKY2(int maphieu, string loai, string ten, DateOnly ngaysinh, string email, string tendv, string diachi)
        {
            InitializeComponent();
            lblMaPhieuDangKy.Text = maphieu.ToString(); ;
            cmbLoaiKhachHang.Text = loai;
            txtTenKhachHang.Text = ten;
            txtEmail.Text = email;
            txtTenKhachHang.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cmbLoaiKhachHang.Enabled = false;
            
            LoadDichVuview(maphieu);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemThiSinh_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            MH_TAOPHIEUDANGKY3 form = new MH_TAOPHIEUDANGKY3();
            form.ShowDialog();
            PhieuDangKyBUS pdkBus = new PhieuDangKyBUS(new PhieuDangKyDAO());

        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDichVuview(int maphieu)
        {
            try
            {
                DichVuBUS dvBus = new DichVuBUS(new DichVuDAO());
                List<DichVuView> danhSach = dvBus.GetDichVuViews(maphieu);
                dgvDichVu.DataSource = danhSach;

                dgvDichVu.Columns["maLichThi"]!.HeaderText = "Mã lịch thi";
                dgvDichVu.Columns["tenDichVu"]!.HeaderText = "Tên dịch vụ";
                dgvDichVu.Columns["ngayThi"]!.HeaderText = "Ngày thi";
                dgvDichVu.Columns["gioThi"]!.HeaderText = "Giờ thi";
                dgvDichVu.Columns["phongThi"]!.HeaderText = "Phòng thi";
                dgvDichVu.Columns["soLuongTsDaDangKy"]!.HeaderText = "Số TS đã đăng ký";
                dgvDichVu.Columns["soLuongTsToiDa"]!.HeaderText = "Số TS tối đa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


    }
}
