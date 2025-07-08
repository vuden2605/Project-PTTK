using System;
using System.Windows.Forms;

namespace Project_PTTK
{
    public partial class ThanhToanPhieuDangKyForm : Form
    {
        public ThanhToanPhieuDangKyForm()
        {
            InitializeComponent();
            Load += ThanhToanPhieuDangKyForm_Load;
        }

        private void ThanhToanPhieuDangKyForm_Load(object sender, EventArgs e)
        {
            // Cấu hình DataGridView
            dgvPhieuChuaThanhToan.Columns.Add("MaPhieu", "Mã phiếu");
            dgvPhieuChuaThanhToan.Columns.Add("TenKhachHang", "Khách hàng");
            dgvPhieuChuaThanhToan.Columns.Add("DichVu", "Dịch vụ");
            dgvPhieuChuaThanhToan.Columns.Add("LichThi", "Lịch thi");
            dgvPhieuChuaThanhToan.Columns.Add("NgayTao", "Ngày tạo");

            dgvPhieuChuaThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuChuaThanhToan.BackgroundColor = System.Drawing.Color.White;

            // Dữ liệu mẫu
            dgvPhieuChuaThanhToan.Rows.Add("PDK001", "Nguyễn Văn A", "Tin học", "01/08/2025", "25/07/2025");
            dgvPhieuChuaThanhToan.Rows.Add("PDK002", "Công ty ABC", "TOEIC", "05/08/2025", "25/07/2025");

            // Sự kiện chọn dòng
            dgvPhieuChuaThanhToan.SelectionChanged += DgvPhieuChuaThanhToan_SelectionChanged;

            // Phương thức thanh toán
            cboPhuongThuc.Items.AddRange(new[] { "Tiền mặt", "Chuyển khoản", "VNPay", "Momo" });
            cboPhuongThuc.SelectedIndex = 0;

            // Sự kiện tính tổng tiền
            nudSoTien.ValueChanged += TinhTongTien;
            nudChietKhau.ValueChanged += TinhTongTien;
        }

        private void DgvPhieuChuaThanhToan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuChuaThanhToan.SelectedRows.Count > 0)
            {
                var row = dgvPhieuChuaThanhToan.SelectedRows[0];
                txtMaPhieu.Text = row.Cells["MaPhieu"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtDichVu.Text = row.Cells["DichVu"].Value?.ToString();
                txtLichThi.Text = row.Cells["LichThi"].Value?.ToString();

                // Gán giá trị mặc định
                nudSoTien.Value = 500000;
                nudChietKhau.Value = 0;
                TinhTongTien(null, null);
            }
        }

        private void TinhTongTien(object sender, EventArgs e)
        {
            decimal soTien = nudSoTien.Value;
            decimal chietKhau = nudChietKhau.Value;
            decimal tongTien = soTien * (1 - chietKhau / 100);
            nudTongTien.Value = tongTien;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu đăng ký để thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Ghi hóa đơn vào DB và cập nhật trạng thái

            MessageBox.Show("✅ Thanh toán thành công!\nHóa đơn đã được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật trạng thái hiển thị
            dgvPhieuChuaThanhToan.Rows.RemoveAt(dgvPhieuChuaThanhToan.SelectedRows[0].Index);
            txtMaPhieu.Text = txtTenKH.Text = txtDichVu.Text = txtLichThi.Text = "";
        }
    }
}