namespace Project_PTTK
{
    partial class MH_THANHTOANPHIEUDANGKY
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
            btnXacNhan = new Button();
            groupBox1 = new GroupBox();
            dgvPhieuDangKy = new DataGridView();
            btnXemChiTietPhieu = new Button();
            groupPhieu = new GroupBox();
            lblMaPhieu = new Label();
            dgvChiTietPhieu = new DataGridView();
            groupHoaDon = new GroupBox();
            lblPhuongThuc = new Label();
            cbmPhuongThuc = new ComboBox();
            lblSoTien = new Label();
            nudSoTien = new NumericUpDown();
            lblChietKhau = new Label();
            nudChietKhau = new NumericUpDown();
            lblTongTien = new Label();
            nudTongTien = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDangKy).BeginInit();
            groupPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            groupHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).BeginInit();
            SuspendLayout();
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSeaGreen;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(1050, 1085);
            btnXacNhan.Margin = new Padding(5);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(358, 64);
            btnXacNhan.TabIndex = 13;
            btnXacNhan.Text = "✅ Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPhieuDangKy);
            groupBox1.Controls.Add(btnXemChiTietPhieu);
            groupBox1.Location = new Point(120, 30);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1300, 379);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu đăng ký cần thanh toán";
            // 
            // dgvPhieuDangKy
            // 
            dgvPhieuDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuDangKy.Location = new Point(94, 61);
            dgvPhieuDangKy.Name = "dgvPhieuDangKy";
            dgvPhieuDangKy.RowHeadersWidth = 82;
            dgvPhieuDangKy.Size = new Size(964, 318);
            dgvPhieuDangKy.TabIndex = 6;
            dgvPhieuDangKy.CellContentClick += dgvPhieuDangKy_CellContentClick;
            // 
            // btnXemChiTietPhieu
            // 
            btnXemChiTietPhieu.BackColor = Color.MediumSeaGreen;
            btnXemChiTietPhieu.FlatStyle = FlatStyle.Flat;
            btnXemChiTietPhieu.ForeColor = Color.White;
            btnXemChiTietPhieu.Location = new Point(1090, 158);
            btnXemChiTietPhieu.Margin = new Padding(5);
            btnXemChiTietPhieu.Name = "btnXemChiTietPhieu";
            btnXemChiTietPhieu.Size = new Size(184, 64);
            btnXemChiTietPhieu.TabIndex = 5;
            btnXemChiTietPhieu.Text = "Xem chi tiết";
            btnXemChiTietPhieu.UseVisualStyleBackColor = false;
            btnXemChiTietPhieu.Click += btnXemChiTietPhieu_Click_1;
            // 
            // groupPhieu
            // 
            groupPhieu.Controls.Add(lblMaPhieu);
            groupPhieu.Controls.Add(dgvChiTietPhieu);
            groupPhieu.Location = new Point(120, 419);
            groupPhieu.Margin = new Padding(5);
            groupPhieu.Name = "groupPhieu";
            groupPhieu.Padding = new Padding(5);
            groupPhieu.Size = new Size(1300, 406);
            groupPhieu.TabIndex = 10;
            groupPhieu.TabStop = false;
            groupPhieu.Text = "Thông tin Phiếu Đăng Ký";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaPhieu.Location = new Point(302, -3);
            lblMaPhieu.Margin = new Padding(5, 0, 5, 0);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(74, 45);
            lblMaPhieu.TabIndex = 1;
            lblMaPhieu.Text = "001";
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieu.Location = new Point(94, 61);
            dgvChiTietPhieu.Margin = new Padding(5);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.RowHeadersWidth = 51;
            dgvChiTietPhieu.Size = new Size(964, 301);
            dgvChiTietPhieu.TabIndex = 0;
            dgvChiTietPhieu.CellContentClick += dgvChiTietPhieu_CellContentClick;
            // 
            // groupHoaDon
            // 
            groupHoaDon.Controls.Add(lblPhuongThuc);
            groupHoaDon.Controls.Add(cbmPhuongThuc);
            groupHoaDon.Controls.Add(lblSoTien);
            groupHoaDon.Controls.Add(nudSoTien);
            groupHoaDon.Controls.Add(lblChietKhau);
            groupHoaDon.Controls.Add(nudChietKhau);
            groupHoaDon.Controls.Add(lblTongTien);
            groupHoaDon.Controls.Add(nudTongTien);
            groupHoaDon.Location = new Point(120, 861);
            groupHoaDon.Margin = new Padding(5);
            groupHoaDon.Name = "groupHoaDon";
            groupHoaDon.Padding = new Padding(5);
            groupHoaDon.Size = new Size(1300, 160);
            groupHoaDon.TabIndex = 11;
            groupHoaDon.TabStop = false;
            groupHoaDon.Text = "Hóa Đơn";
            // 
            // lblPhuongThuc
            // 
            lblPhuongThuc.Location = new Point(96, 43);
            lblPhuongThuc.Margin = new Padding(5, 0, 5, 0);
            lblPhuongThuc.Name = "lblPhuongThuc";
            lblPhuongThuc.Size = new Size(162, 37);
            lblPhuongThuc.TabIndex = 0;
            lblPhuongThuc.Text = "Phương thức:";
            // 
            // cbmPhuongThuc
            // 
            cbmPhuongThuc.Items.AddRange(new object[] { "Trực tiếp", "Chuyển khoản" });
            cbmPhuongThuc.Location = new Point(275, 40);
            cbmPhuongThuc.Margin = new Padding(5);
            cbmPhuongThuc.Name = "cbmPhuongThuc";
            cbmPhuongThuc.Size = new Size(290, 40);
            cbmPhuongThuc.TabIndex = 1;
            cbmPhuongThuc.Text = "Trực tiếp";
            // 
            // lblSoTien
            // 
            lblSoTien.Location = new Point(757, 48);
            lblSoTien.Margin = new Padding(5, 0, 5, 0);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(162, 37);
            lblSoTien.TabIndex = 2;
            lblSoTien.Text = "Số tiền:";
            // 
            // nudSoTien
            // 
            nudSoTien.Enabled = false;
            nudSoTien.Location = new Point(930, 48);
            nudSoTien.Margin = new Padding(5);
            nudSoTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudSoTien.Name = "nudSoTien";
            nudSoTien.Size = new Size(195, 39);
            nudSoTien.TabIndex = 3;
            // 
            // lblChietKhau
            // 
            lblChietKhau.Location = new Point(96, 99);
            lblChietKhau.Margin = new Padding(5, 0, 5, 0);
            lblChietKhau.Name = "lblChietKhau";
            lblChietKhau.Size = new Size(162, 37);
            lblChietKhau.TabIndex = 4;
            lblChietKhau.Text = "Chiết khấu (%):";
            // 
            // nudChietKhau
            // 
            nudChietKhau.Location = new Point(275, 96);
            nudChietKhau.Margin = new Padding(5);
            nudChietKhau.Name = "nudChietKhau";
            nudChietKhau.Size = new Size(195, 39);
            nudChietKhau.TabIndex = 5;
            nudChietKhau.ValueChanged += nudChietKhau_ValueChanged;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(757, 104);
            lblTongTien.Margin = new Padding(5, 0, 5, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(162, 37);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // nudTongTien
            // 
            nudTongTien.Enabled = false;
            nudTongTien.Location = new Point(930, 101);
            nudTongTien.Margin = new Padding(5);
            nudTongTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudTongTien.Name = "nudTongTien";
            nudTongTien.ReadOnly = true;
            nudTongTien.Size = new Size(195, 39);
            nudTongTien.TabIndex = 7;
            // 
            // MH_THANHTOANPHIEUDANGKY
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1632, 1155);
            Controls.Add(btnXacNhan);
            Controls.Add(groupBox1);
            Controls.Add(groupPhieu);
            Controls.Add(groupHoaDon);
            Name = "MH_THANHTOANPHIEUDANGKY";
            Text = " ";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDangKy).EndInit();
            groupPhieu.ResumeLayout(false);
            groupPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            groupHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnXacNhan;
        private GroupBox groupBox1;
        private Button btnXemChiTietPhieu;
        private GroupBox groupPhieu;
        private Label lblMaPhieu;
        private DataGridView dgvChiTietPhieu;
        private GroupBox groupHoaDon;
        private Label lblPhuongThuc;
        private ComboBox cbmPhuongThuc;
        private Label lblSoTien;
        private NumericUpDown nudSoTien;
        private Label lblChietKhau;
        private NumericUpDown nudChietKhau;
        private Label lblTongTien;
        private NumericUpDown nudTongTien;
        private DataGridView dgvPhieuDangKy;
    }
}