namespace Project_PTTK
{
    partial class ThanhToanGiaHanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPhieuChuaThanhToan = new DataGridView();
            groupPhieu = new GroupBox();
            lblMaPhieuGiaHan = new Label();
            txtMaPhieuGiaHan = new TextBox();
            lblLyDo = new Label();
            txtLyDo = new TextBox();
            lblMaPhieuDangKy = new Label();
            txtMaPhieuDangKy = new TextBox();
            lblLichThi = new Label();
            txtLichThi = new TextBox();
            groupThiSinh = new GroupBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            txtNgaySinh = new TextBox();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblGioiTinh = new Label();
            txtGioiTinh = new TextBox();
            groupHoaDon = new GroupBox();
            lblPhuongThuc = new Label();
            cboPhuongThuc = new ComboBox();
            lblSoTien = new Label();
            nudSoTien = new NumericUpDown();
            lblChietKhau = new Label();
            nudChietKhau = new NumericUpDown();
            lblTongTien = new Label();
            nudTongTien = new NumericUpDown();
            btnXacNhan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChuaThanhToan).BeginInit();
            groupPhieu.SuspendLayout();
            groupThiSinh.SuspendLayout();
            groupHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).BeginInit();
            SuspendLayout();
            // 
            // dgvPhieuChuaThanhToan
            // 
            dgvPhieuChuaThanhToan.ColumnHeadersHeight = 29;
            dgvPhieuChuaThanhToan.Location = new Point(26, 34);
            dgvPhieuChuaThanhToan.Name = "dgvPhieuChuaThanhToan";
            dgvPhieuChuaThanhToan.ReadOnly = true;
            dgvPhieuChuaThanhToan.RowHeadersWidth = 51;
            dgvPhieuChuaThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuChuaThanhToan.Size = new Size(950, 150);
            dgvPhieuChuaThanhToan.TabIndex = 2;
            // 
            // groupPhieu
            // 
            groupPhieu.Controls.Add(lblMaPhieuGiaHan);
            groupPhieu.Controls.Add(txtMaPhieuGiaHan);
            groupPhieu.Controls.Add(lblLyDo);
            groupPhieu.Controls.Add(txtLyDo);
            groupPhieu.Controls.Add(lblMaPhieuDangKy);
            groupPhieu.Controls.Add(txtMaPhieuDangKy);
            groupPhieu.Controls.Add(lblLichThi);
            groupPhieu.Controls.Add(txtLichThi);
            groupPhieu.Location = new Point(26, 219);
            groupPhieu.Name = "groupPhieu";
            groupPhieu.Size = new Size(950, 100);
            groupPhieu.TabIndex = 3;
            groupPhieu.TabStop = false;
            groupPhieu.Text = "Thông tin Phiếu gia hạn";
            groupPhieu.Enter += groupPhieu_Enter;
            // 
            // lblMaPhieuGiaHan
            // 
            lblMaPhieuGiaHan.Location = new Point(20, 30);
            lblMaPhieuGiaHan.Name = "lblMaPhieuGiaHan";
            lblMaPhieuGiaHan.Size = new Size(131, 23);
            lblMaPhieuGiaHan.TabIndex = 0;
            lblMaPhieuGiaHan.Text = "Mã phiếu gia hạn:";
            // 
            // txtMaPhieuGiaHan
            // 
            txtMaPhieuGiaHan.BackColor = SystemColors.Window;
            txtMaPhieuGiaHan.Location = new Point(184, 26);
            txtMaPhieuGiaHan.Name = "txtMaPhieuGiaHan";
            txtMaPhieuGiaHan.Size = new Size(150, 27);
            txtMaPhieuGiaHan.TabIndex = 1;
            // 
            // lblLyDo
            // 
            lblLyDo.Location = new Point(435, 31);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(100, 23);
            lblLyDo.TabIndex = 2;
            lblLyDo.Text = "Lý do:";
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(535, 26);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.ReadOnly = true;
            txtLyDo.Size = new Size(200, 27);
            txtLyDo.TabIndex = 3;
            // 
            // lblMaPhieuDangKy
            // 
            lblMaPhieuDangKy.Location = new Point(20, 65);
            lblMaPhieuDangKy.Name = "lblMaPhieuDangKy";
            lblMaPhieuDangKy.Size = new Size(131, 23);
            lblMaPhieuDangKy.TabIndex = 4;
            lblMaPhieuDangKy.Text = "Mã phiếu đăng ký:";
            lblMaPhieuDangKy.Click += lblDichVu_Click;
            // 
            // txtMaPhieuDangKy
            // 
            txtMaPhieuDangKy.BackColor = SystemColors.Window;
            txtMaPhieuDangKy.Location = new Point(184, 63);
            txtMaPhieuDangKy.Name = "txtMaPhieuDangKy";
            txtMaPhieuDangKy.Size = new Size(150, 27);
            txtMaPhieuDangKy.TabIndex = 5;
            txtMaPhieuDangKy.TextChanged += txtDichVu_TextChanged;
            // 
            // lblLichThi
            // 
            lblLichThi.Location = new Point(435, 66);
            lblLichThi.Name = "lblLichThi";
            lblLichThi.Size = new Size(100, 23);
            lblLichThi.TabIndex = 6;
            lblLichThi.Text = "Lịch thi:";
            // 
            // txtLichThi
            // 
            txtLichThi.Location = new Point(535, 60);
            txtLichThi.Name = "txtLichThi";
            txtLichThi.ReadOnly = true;
            txtLichThi.Size = new Size(200, 27);
            txtLichThi.TabIndex = 7;
            // 
            // groupThiSinh
            // 
            groupThiSinh.Controls.Add(lblHoTen);
            groupThiSinh.Controls.Add(txtHoTen);
            groupThiSinh.Controls.Add(lblNgaySinh);
            groupThiSinh.Controls.Add(txtNgaySinh);
            groupThiSinh.Controls.Add(lblCCCD);
            groupThiSinh.Controls.Add(txtCCCD);
            groupThiSinh.Controls.Add(lblGioiTinh);
            groupThiSinh.Controls.Add(txtGioiTinh);
            groupThiSinh.Location = new Point(26, 341);
            groupThiSinh.Name = "groupThiSinh";
            groupThiSinh.Size = new Size(950, 100);
            groupThiSinh.TabIndex = 8;
            groupThiSinh.TabStop = false;
            groupThiSinh.Text = "Thông tin thí sinh";
            groupThiSinh.Enter += groupBox1_Enter;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(20, 30);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(131, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và Tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.Control;
            txtHoTen.Location = new Point(184, 26);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(150, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(435, 31);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(535, 30);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.ReadOnly = true;
            txtNgaySinh.Size = new Size(200, 27);
            txtNgaySinh.TabIndex = 3;
            // 
            // lblCCCD
            // 
            lblCCCD.Location = new Point(20, 65);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(131, 23);
            lblCCCD.TabIndex = 4;
            lblCCCD.Text = "CMND/CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = SystemColors.Control;
            txtCCCD.Location = new Point(184, 63);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.ReadOnly = true;
            txtCCCD.Size = new Size(150, 27);
            txtCCCD.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(435, 66);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(535, 64);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.Size = new Size(200, 27);
            txtGioiTinh.TabIndex = 7;
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
            groupHoaDon.Location = new Point(26, 469);
            groupHoaDon.Name = "groupHoaDon";
            groupHoaDon.Size = new Size(950, 100);
            groupHoaDon.TabIndex = 9;
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
            cboPhuongThuc.Size = new Size(180, 28);
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
            nudSoTien.Size = new Size(120, 27);
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
            nudChietKhau.Size = new Size(120, 27);
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
            nudTongTien.Size = new Size(120, 27);
            nudTongTien.TabIndex = 7;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSeaGreen;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(391, 617);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(220, 40);
            btnXacNhan.TabIndex = 10;
            btnXacNhan.Text = "✅ Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // ThanhToanGiaHanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 690);
            Controls.Add(btnXacNhan);
            Controls.Add(groupHoaDon);
            Controls.Add(groupThiSinh);
            Controls.Add(dgvPhieuChuaThanhToan);
            Controls.Add(groupPhieu);
            Name = "ThanhToanGiaHanForm";
            Text = "ThanhToanGiaHan";
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChuaThanhToan).EndInit();
            groupPhieu.ResumeLayout(false);
            groupPhieu.PerformLayout();
            groupThiSinh.ResumeLayout(false);
            groupThiSinh.PerformLayout();
            groupHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPhieuChuaThanhToan;
        private GroupBox groupPhieu;
        private Label lblMaPhieuGiaHan;
        private TextBox txtMaPhieuGiaHan;
        private Label lblLyDo;
        private TextBox txtLyDo;
        private Label lblMaPhieuDangKy;
        private TextBox txtMaPhieuDangKy;
        private Label lblLichThi;
        private TextBox txtLichThi;
        private GroupBox groupThiSinh;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private TextBox txtNgaySinh;
        private Label lblCCCD;
        private TextBox txtCCCD;
        private Label lblGioiTinh;
        private TextBox txtGioiTinh;
        private GroupBox groupHoaDon;
        private Label lblPhuongThuc;
        private ComboBox cboPhuongThuc;
        private Label lblSoTien;
        private NumericUpDown nudSoTien;
        private Label lblChietKhau;
        private NumericUpDown nudChietKhau;
        private Label lblTongTien;
        private NumericUpDown nudTongTien;
        private Button btnXacNhan;
    }
}