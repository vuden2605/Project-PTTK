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
using Project_PTTK.DataAccess;
using Project_PTTK.Business;
using Project_PTTK.DataAccess.Phieu;

namespace Project_PTTK
{
    public partial class MH_TAOPHIEUDANGKY1 : Form
    {

        private PhieuDangKyBUS pdkBus = new PhieuDangKyBUS(new PhieuDangKyDAO());

        public MH_TAOPHIEUDANGKY1()
        {
            InitializeComponent();
            LoadPhieuDangKy();
        }

        private void btnTaoPhieuDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuDangKy_Click_1(object sender, EventArgs e)
        {
            string? loai = cmbLoaiKhachHang.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(loai))
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang kh = new KhachHang(loai, email);
            KhangHangBus khbus = new KhangHangBus(new KhachHangDAO());
            int maKH = khbus.AddKhachHang(kh);
            if (loai == "Tự do")
            {
                string tenkh = txtTenKhachHang.Text.Trim();
                DateOnly ngaysinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                KhachHangTuDo khTuDo = new KhachHangTuDo(maKH, tenkh, ngaysinh);
                //khTuDo.MaKH = maKH; // Gán mã khách hàng đã tạo
                KhachHangTuDoBus khtdBus = new KhachHangTuDoBus(new KhachHangTuDoDAO());
                khtdBus.AddKhachHangTuDo(khTuDo);

            }
            else if (loai == "Đơn vị")
            {
                string tendv = txtTenDonVi.Text.Trim();
                string diachi = txtDiaChiDonVi.Text.Trim();
                KhachHangDonVi khDonVi = new KhachHangDonVi(maKH, tendv, diachi);
                //khDonVi.MaKH = maKH; // Gán mã khách hàng đã tạo
                KhachHangDonViBus khdvBus = new KhachHangDonViBus(new KhachHangDonViDAO());
                khdvBus.AddKhachHangDonVi(khDonVi);
            }
            PhieuDangKy phieuDangKy = new PhieuDangKy(maKH);
            pdkBus.ThemPhieuDangKy(phieuDangKy);
            MessageBox.Show("Đã tạo phiếu đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPhieuDangKy();
        }

        private void dgvPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPhieuDangKy()
        {
            try
            {
                PhieuDangKyBUS pdkBus = new PhieuDangKyBUS(new PhieuDangKyDAO());
                List<PhieuDangKyView> danhSach = pdkBus.LayDanhSach();
                dgvPhieuDangKy.DataSource = danhSach;
                dgvPhieuDangKy.Columns["MaPhieuDangKy"]!.HeaderText = "Mã phiếu";
                dgvPhieuDangKy.Columns["MaKH"]!.HeaderText = "Mã KH";
                dgvPhieuDangKy.Columns["TenKH"]!.HeaderText = "Tên khách hàng";
                dgvPhieuDangKy.Columns["LoaiKH"]!.HeaderText = "Loại khách hàng";
                dgvPhieuDangKy.Columns["Email"]!.HeaderText = "Email";
                dgvPhieuDangKy.Columns["NgayTao"]!.HeaderText = "Ngày tạo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: ", ex.Message);
            }
        }

        private void cmbLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cmbLoaiKhachHang.SelectedItem?.ToString()??string.Empty;

            if (loai == "Tự do")
            {
                // Enable các trường của khách tự do
                txtTenKhachHang.Enabled = true;
                dtpNgaySinh.Enabled = true;

                // Disable + clear các trường của khách đơn vị
                txtTenDonVi.Enabled = false;
                txtDiaChiDonVi.Enabled = false;
                txtTenDonVi.Text = string.Empty;
                txtDiaChiDonVi.Text = string.Empty;
            }
            else if (loai == "Đơn vị")
            {
                txtTenDonVi.Enabled = true;
                txtDiaChiDonVi.Enabled = true;

                txtTenKhachHang.Enabled = false;
                dtpNgaySinh.Enabled = false;
                txtTenKhachHang.Text = string.Empty;
            }
        }
    }
}
