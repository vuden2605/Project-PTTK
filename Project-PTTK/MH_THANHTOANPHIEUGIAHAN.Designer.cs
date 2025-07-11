namespace Project_PTTK
{
    partial class MH_THANHTOANPHIEUGIAHAN
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
            groupBox1 = new GroupBox();
            btnChon = new Button();
            dgvPhieuGiaHan = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtMaPhieuGiaHan = new TextBox();
            txtMaPhieuDangKy = new TextBox();
            label3 = new Label();
            txtMaLichThi = new TextBox();
            label4 = new Label();
            txtLyDo = new TextBox();
            label5 = new Label();
            txtMaKhachHang = new TextBox();
            label6 = new Label();
            groupHoaDon = new GroupBox();
            lblPhuongThuc = new Label();
            cbmPhuongThuc = new ComboBox();
            lblSoTien = new Label();
            nudSoTien = new NumericUpDown();
            lblChietKhau = new Label();
            nudChietKhau = new NumericUpDown();
            lblTongTien = new Label();
            nudTongTien = new NumericUpDown();
            btnXacNhan = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuGiaHan).BeginInit();
            groupHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLyDo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaLichThi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaPhieuDangKy);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaPhieuGiaHan);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(42, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1281, 245);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu gia hạn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnChon
            // 
            btnChon.BackColor = Color.MediumSeaGreen;
            btnChon.FlatStyle = FlatStyle.Flat;
            btnChon.ForeColor = Color.White;
            btnChon.Location = new Point(1179, 214);
            btnChon.Margin = new Padding(5);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(131, 64);
            btnChon.TabIndex = 10;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = false;
            // 
            // dgvPhieuGiaHan
            // 
            dgvPhieuGiaHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuGiaHan.Location = new Point(84, 138);
            dgvPhieuGiaHan.Name = "dgvPhieuGiaHan";
            dgvPhieuGiaHan.RowHeadersWidth = 82;
            dgvPhieuGiaHan.Size = new Size(1063, 250);
            dgvPhieuGiaHan.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 85);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 8;
            label1.Text = "Danh sách phiếu gia hạn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 48);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu gia hạn:";
            // 
            // txtMaPhieuGiaHan
            // 
            txtMaPhieuGiaHan.Location = new Point(266, 38);
            txtMaPhieuGiaHan.Name = "txtMaPhieuGiaHan";
            txtMaPhieuGiaHan.ReadOnly = true;
            txtMaPhieuGiaHan.Size = new Size(241, 39);
            txtMaPhieuGiaHan.TabIndex = 1;
            // 
            // txtMaPhieuDangKy
            // 
            txtMaPhieuDangKy.Location = new Point(266, 108);
            txtMaPhieuDangKy.Name = "txtMaPhieuDangKy";
            txtMaPhieuDangKy.ReadOnly = true;
            txtMaPhieuDangKy.Size = new Size(241, 39);
            txtMaPhieuDangKy.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 118);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 2;
            label3.Text = "Mã phiếu đăng ký:";
            // 
            // txtMaLichThi
            // 
            txtMaLichThi.Location = new Point(266, 188);
            txtMaLichThi.Name = "txtMaLichThi";
            txtMaLichThi.ReadOnly = true;
            txtMaLichThi.Size = new Size(241, 39);
            txtMaLichThi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 191);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 4;
            label4.Text = "Mã lịch thi:";
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(812, 38);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.ReadOnly = true;
            txtLyDo.Size = new Size(241, 39);
            txtLyDo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 48);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 6;
            label5.Text = "Lý do:";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(812, 108);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(241, 39);
            txtMaKhachHang.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(578, 118);
            label6.Name = "label6";
            label6.Size = new Size(184, 32);
            label6.TabIndex = 8;
            label6.Text = "Mã khách hàng:";
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
            groupHoaDon.Location = new Point(42, 703);
            groupHoaDon.Margin = new Padding(5);
            groupHoaDon.Name = "groupHoaDon";
            groupHoaDon.Padding = new Padding(5);
            groupHoaDon.Size = new Size(1300, 160);
            groupHoaDon.TabIndex = 12;
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
            cbmPhuongThuc.Location = new Point(275, 40);
            cbmPhuongThuc.Margin = new Padding(5);
            cbmPhuongThuc.Name = "cbmPhuongThuc";
            cbmPhuongThuc.Size = new Size(290, 40);
            cbmPhuongThuc.TabIndex = 1;
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
            nudTongTien.Location = new Point(930, 101);
            nudTongTien.Margin = new Padding(5);
            nudTongTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudTongTien.Name = "nudTongTien";
            nudTongTien.ReadOnly = true;
            nudTongTien.Size = new Size(195, 39);
            nudTongTien.TabIndex = 7;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSeaGreen;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(505, 926);
            btnXacNhan.Margin = new Padding(5);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(358, 64);
            btnXacNhan.TabIndex = 14;
            btnXacNhan.Text = "✅ Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // MH_THANHTOANPHIEUGIAHAN
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 1068);
            Controls.Add(btnXacNhan);
            Controls.Add(groupHoaDon);
            Controls.Add(groupBox1);
            Controls.Add(btnChon);
            Controls.Add(dgvPhieuGiaHan);
            Controls.Add(label1);
            Name = "MH_THANHTOANPHIEUGIAHAN";
            Text = "MH_THANHTOANPHIEUGIAHAN";
            Load += MH_THANHTOANPHIEUGIAHAN_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuGiaHan).EndInit();
            groupHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnChon;
        private DataGridView dgvPhieuGiaHan;
        private Label label1;
        private TextBox txtMaKhachHang;
        private Label label6;
        private TextBox txtLyDo;
        private Label label5;
        private TextBox txtMaLichThi;
        private Label label4;
        private TextBox txtMaPhieuDangKy;
        private Label label3;
        private TextBox txtMaPhieuGiaHan;
        private Label label2;
        private GroupBox groupHoaDon;
        private Label lblPhuongThuc;
        private ComboBox cbmPhuongThuc;
        private Label lblSoTien;
        private NumericUpDown nudSoTien;
        private Label lblChietKhau;
        private NumericUpDown nudChietKhau;
        private Label lblTongTien;
        private NumericUpDown nudTongTien;
        private Button btnXacNhan;
    }
}