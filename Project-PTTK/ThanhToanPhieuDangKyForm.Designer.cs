using System.Windows.Forms;
using System.Drawing;

namespace Project_PTTK
{
    partial class ThanhToanPhieuDangKyForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvPhieuChuaThanhToan;
        private GroupBox groupPhieu, groupHoaDon, groupThanhToan;
        private Label lblMaPhieu, lblTenKH, lblDichVu, lblLichThi, lblPhuongThuc, lblSoTien, lblChietKhau, lblTongTien;
        private TextBox txtMaPhieu, txtTenKH, txtDichVu, txtLichThi;
        private ComboBox cboPhuongThuc;
        private NumericUpDown nudSoTien, nudChietKhau, nudTongTien;
        private Button btnXacNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPhieuChuaThanhToan = new DataGridView();
            groupPhieu = new GroupBox();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblDichVu = new Label();
            txtDichVu = new TextBox();
            lblLichThi = new Label();
            txtLichThi = new TextBox();
            groupHoaDon = new GroupBox();
            lblPhuongThuc = new Label();
            cboPhuongThuc = new ComboBox();
            lblSoTien = new Label();
            nudSoTien = new NumericUpDown();
            lblChietKhau = new Label();
            nudChietKhau = new NumericUpDown();
            lblTongTien = new Label();
            nudTongTien = new NumericUpDown();
            groupThanhToan = new GroupBox();
            btnXacNhan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChuaThanhToan).BeginInit();
            groupPhieu.SuspendLayout();
            groupHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).BeginInit();
            SuspendLayout();
            // 
            // dgvPhieuChuaThanhToan
            // 
            dgvPhieuChuaThanhToan.ColumnHeadersHeight = 29;
            dgvPhieuChuaThanhToan.Location = new Point(20, 20);
            dgvPhieuChuaThanhToan.Name = "dgvPhieuChuaThanhToan";
            dgvPhieuChuaThanhToan.ReadOnly = true;
            dgvPhieuChuaThanhToan.RowHeadersWidth = 51;
            dgvPhieuChuaThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuChuaThanhToan.Size = new Size(950, 150);
            dgvPhieuChuaThanhToan.TabIndex = 0;
            // 
            // groupPhieu
            // 
            groupPhieu.Controls.Add(lblMaPhieu);
            groupPhieu.Controls.Add(txtMaPhieu);
            groupPhieu.Controls.Add(lblTenKH);
            groupPhieu.Controls.Add(txtTenKH);
            groupPhieu.Controls.Add(lblDichVu);
            groupPhieu.Controls.Add(txtDichVu);
            groupPhieu.Controls.Add(lblLichThi);
            groupPhieu.Controls.Add(txtLichThi);
            groupPhieu.Location = new Point(20, 180);
            groupPhieu.Name = "groupPhieu";
            groupPhieu.Size = new Size(950, 100);
            groupPhieu.TabIndex = 1;
            groupPhieu.TabStop = false;
            groupPhieu.Text = "Thông tin Phiếu Đăng Ký";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.Location = new Point(20, 30);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(100, 23);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(126, 27);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(150, 30);
            txtMaPhieu.TabIndex = 1;
            // 
            // lblTenKH
            // 
            lblTenKH.Location = new Point(300, 30);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(100, 23);
            lblTenKH.TabIndex = 2;
            lblTenKH.Text = "Khách hàng:";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(400, 29);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(200, 30);
            txtTenKH.TabIndex = 3;
            // 
            // lblDichVu
            // 
            lblDichVu.Location = new Point(20, 65);
            lblDichVu.Name = "lblDichVu";
            lblDichVu.Size = new Size(100, 23);
            lblDichVu.TabIndex = 4;
            lblDichVu.Text = "Dịch vụ:";
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(126, 64);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.ReadOnly = true;
            txtDichVu.Size = new Size(150, 30);
            txtDichVu.TabIndex = 5;
            // 
            // lblLichThi
            // 
            lblLichThi.Location = new Point(300, 65);
            lblLichThi.Name = "lblLichThi";
            lblLichThi.Size = new Size(100, 23);
            lblLichThi.TabIndex = 6;
            lblLichThi.Text = "Lịch thi:";
            // 
            // txtLichThi
            // 
            txtLichThi.Location = new Point(400, 63);
            txtLichThi.Name = "txtLichThi";
            txtLichThi.ReadOnly = true;
            txtLichThi.Size = new Size(200, 30);
            txtLichThi.TabIndex = 7;
            // 
            // groupHoaDon
            // 
            groupHoaDon.Controls.Add(lblPhuongThuc);
            groupHoaDon.Controls.Add(cboPhuongThuc);
            groupHoaDon.Controls.Add(lblSoTien);
            groupHoaDon.Controls.Add(nudSoTien);
            groupHoaDon.Controls.Add(lblChietKhau);
            groupHoaDon.Controls.Add(nudChietKhau);
            groupHoaDon.Controls.Add(lblTongTien);
            groupHoaDon.Controls.Add(nudTongTien);
            groupHoaDon.Location = new Point(20, 290);
            groupHoaDon.Name = "groupHoaDon";
            groupHoaDon.Size = new Size(950, 100);
            groupHoaDon.TabIndex = 2;
            groupHoaDon.TabStop = false;
            groupHoaDon.Text = "Hóa Đơn";
            // 
            // lblPhuongThuc
            // 
            lblPhuongThuc.Location = new Point(20, 30);
            lblPhuongThuc.Name = "lblPhuongThuc";
            lblPhuongThuc.Size = new Size(100, 23);
            lblPhuongThuc.TabIndex = 0;
            lblPhuongThuc.Text = "Phương thức:";
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.Location = new Point(130, 28);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(180, 31);
            cboPhuongThuc.TabIndex = 1;
            // 
            // lblSoTien
            // 
            lblSoTien.Location = new Point(350, 30);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(100, 23);
            lblSoTien.TabIndex = 2;
            lblSoTien.Text = "Số tiền:";
            // 
            // nudSoTien
            // 
            nudSoTien.Location = new Point(456, 30);
            nudSoTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudSoTien.Name = "nudSoTien";
            nudSoTien.Size = new Size(120, 30);
            nudSoTien.TabIndex = 3;
            // 
            // lblChietKhau
            // 
            lblChietKhau.Location = new Point(20, 65);
            lblChietKhau.Name = "lblChietKhau";
            lblChietKhau.Size = new Size(100, 23);
            lblChietKhau.TabIndex = 4;
            lblChietKhau.Text = "Chiết khấu (%):";
            // 
            // nudChietKhau
            // 
            nudChietKhau.Location = new Point(130, 63);
            nudChietKhau.Name = "nudChietKhau";
            nudChietKhau.Size = new Size(120, 30);
            nudChietKhau.TabIndex = 5;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(350, 65);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(100, 23);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // nudTongTien
            // 
            nudTongTien.Location = new Point(456, 63);
            nudTongTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudTongTien.Name = "nudTongTien";
            nudTongTien.ReadOnly = true;
            nudTongTien.Size = new Size(120, 30);
            nudTongTien.TabIndex = 7;
            // 
            // groupThanhToan
            // 
            groupThanhToan.Location = new Point(0, 0);
            groupThanhToan.Name = "groupThanhToan";
            groupThanhToan.Size = new Size(200, 100);
            groupThanhToan.TabIndex = 0;
            groupThanhToan.TabStop = false;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSeaGreen;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(400, 410);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(220, 40);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "✅ Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // ThanhToanPhieuDangKyForm
            // 
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvPhieuChuaThanhToan);
            Controls.Add(groupPhieu);
            Controls.Add(groupHoaDon);
            Controls.Add(btnXacNhan);
            Font = new Font("Segoe UI", 10F);
            Name = "ThanhToanPhieuDangKyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán Phiếu Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChuaThanhToan).EndInit();
            groupPhieu.ResumeLayout(false);
            groupPhieu.PerformLayout();
            groupHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).EndInit();
            ResumeLayout(false);
        }
    }
}