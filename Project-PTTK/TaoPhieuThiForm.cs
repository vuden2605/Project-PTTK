using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_PTTK
{
    public partial class TaoPhieuDangKyForm : Form
    {
        public TaoPhieuDangKyForm()
        {
            InitializeComponent();
            this.Load += TaoPhieuDangKyForm_Load;
        }

        private void TaoPhieuDangKyForm_Load(object sender, EventArgs e)
        {
            // Gán Text cho label
            lblLoaiKH.Text = "Loại khách hàng:";
            lblTenKH.Text = "Tên khách hàng:";
            lblNgaySinhKH.Text = "Ngày sinh (KH):";
            lblTenDV.Text = "Tên đơn vị:";
            lblDiaChiDV.Text = "Địa chỉ đơn vị:";
            lblHoTenTS.Text = "Họ tên thí sinh:";
            lblNgaySinhTS.Text = "Ngày sinh (TS):";
            lblCMND.Text = "CMND/CCCD:";
            lblGioiTinh.Text = "Giới tính:";
            lblDichVu.Text = "Dịch vụ:";
            lblLichThi.Text = "Lịch thi:";

            // Khởi tạo dữ liệu ComboBox
            cboLoaiKH.Items.AddRange(new[] { "Tự do", "Đơn vị" });
            cboGioiTinh.Items.AddRange(new[] { "Nam", "Nữ" });
            cboLoaiKH.SelectedIndex = 0;

            // Gắn sự kiện
            cboLoaiKH.SelectedIndexChanged += cboLoaiKH_SelectedIndexChanged;
            cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;
            btnDangKy.Click += btnDangKy_Click;

            // Tải dịch vụ
            LoadDichVu();
        }

        private void cboLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isDonVi = cboLoaiKH.SelectedItem?.ToString() == "Đơn vị";
            txtTenKH.Visible = !isDonVi;
            dtpNgaySinhKH.Visible = !isDonVi;
            txtTenDV.Visible = isDonVi;
            txtDiaChiDV.Visible = isDonVi;
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboDichVu.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selected))
            {
                cboLichThi.Items.Clear();
                cboLichThi.Items.Add("01/08/2025 - Ca sáng");
                cboLichThi.Items.Add("05/08/2025 - Ca chiều");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboLichThi.SelectedItem?.ToString().Contains("Đủ") == true)
            {
                MessageBox.Show("Lịch thi này đã đủ số lượng thí sinh. Vui lòng chọn lịch khác.");
                return;
            }

            MessageBox.Show("✅ Đã tạo phiếu đăng ký thành công!");
        }

        private void LoadDichVu()
        {
            cboDichVu.Items.Add("Toeic");
            cboDichVu.Items.Add("Tin học");
        }

        private void lblTenKH_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDichVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
