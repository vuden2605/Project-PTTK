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
            LoadDsThiSinhByPhieuDangKy(maphieu);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemThiSinh_Click(object sender, EventArgs e)
        {
            int maLichThi = dgvDichVu.CurrentRow?.Cells["maLichThi"]?.Value is int m ? m : 0;
            string hoten = txtHoTenThiSinh.Text.Trim();
            string cmnd = txtCCCD.Text.Trim();
            DateOnly ngaysinh = DateOnly.FromDateTime(dtpNgaySinhTS.Value); // sửa đoạn này
            string gioitinh = cmbGioiTinh.Text.Trim();
            int maphieu = Convert.ToInt32(lblMaPhieuDangKy.Text);
            ThiSinhBus tsBus = new ThiSinhBus(new ThiSinhDAO());

            ThiSinh thiSinh = new ThiSinh(hoten, ngaysinh, cmnd, gioitinh, "CHƯA PHÁT HÀNH", maLichThi, maphieu);

            tsBus.add(thiSinh);
            MessageBox.Show("Thêm thí sinh thành công!");
            // Cập nhật lại danh sách thí sinh
            LichThiBus ltBus = new LichThiBus(new LichThiDAO());
            ltBus.tangSoLuongTs(maLichThi);

            // Cập nhật chi tiết phiếu đăng ký
            PhieuDangKyBUS pdkBus = new PhieuDangKyBUS(new PhieuDangKyDAO());
            pdkBus.TangSoLuongThiSinhDangKy(maphieu, maLichThi);
            LoadDsThiSinhByPhieuDangKy(maphieu);
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            int maphieu = Convert.ToInt32(lblMaPhieuDangKy.Text);
            MH_TAOPHIEUDANGKY3 form = new MH_TAOPHIEUDANGKY3(maphieu);
            this.Hide();
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
        public void LoadDsThiSinhByPhieuDangKy(int maphieu)
        {
            try
            {
                PhieuDangKyBUS pdkBus = new PhieuDangKyBUS(new PhieuDangKyDAO());
                List<ThiSinh> danhSach = pdkBus.getThiSinhByPhieuDangKy(maphieu);
                dgvThiSinh.DataSource = danhSach;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvThiSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {

        }
    }
}
