﻿namespace Project_PTTK
{
    partial class MH_TAOPHIEUDANGKY2
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
            groupBox3 = new GroupBox();
            dgvThiSinh = new DataGridView();
            groupBox2 = new GroupBox();
            lblHoTenTS = new Label();
            txtHoTenThiSinh = new TextBox();
            lblNgaySinhTS = new Label();
            dtpNgaySinhTS = new DateTimePicker();
            lblCMND = new Label();
            txtCCCD = new TextBox();
            lblGioiTinh = new Label();
            cmbGioiTinh = new ComboBox();
            btnThemThiSinh = new Button();
            groupBox1 = new GroupBox();
            btnThemDichVu = new Button();
            dgvDichVu = new DataGridView();
            btnLuuLai = new Button();
            txtTenKhachHang = new TextBox();
            lblTenKH = new Label();
            cmbLoaiKhachHang = new ComboBox();
            lblLoaiKH = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            lblMaPhieuDangKy = new Label();
            groupKhachHang = new GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThiSinh).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            groupKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvThiSinh);
            groupBox3.Location = new Point(58, 765);
            groupBox3.Margin = new Padding(5, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 5, 5, 5);
            groupBox3.Size = new Size(1466, 498);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách thí sinh của phiếu đăng ký";
            // 
            // dgvThiSinh
            // 
            dgvThiSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThiSinh.Location = new Point(32, 62);
            dgvThiSinh.Margin = new Padding(5, 5, 5, 5);
            dgvThiSinh.Name = "dgvThiSinh";
            dgvThiSinh.RowHeadersWidth = 51;
            dgvThiSinh.Size = new Size(1424, 352);
            dgvThiSinh.TabIndex = 0;
            dgvThiSinh.CellContentClick += dgvThiSinh_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblHoTenTS);
            groupBox2.Controls.Add(txtHoTenThiSinh);
            groupBox2.Controls.Add(lblNgaySinhTS);
            groupBox2.Controls.Add(dtpNgaySinhTS);
            groupBox2.Controls.Add(lblCMND);
            groupBox2.Controls.Add(txtCCCD);
            groupBox2.Controls.Add(lblGioiTinh);
            groupBox2.Controls.Add(cmbGioiTinh);
            groupBox2.Controls.Add(btnThemThiSinh);
            groupBox2.Location = new Point(959, 230);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(566, 523);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thí sinh";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblHoTenTS
            // 
            lblHoTenTS.Location = new Point(29, 64);
            lblHoTenTS.Margin = new Padding(5, 0, 5, 0);
            lblHoTenTS.Name = "lblHoTenTS";
            lblHoTenTS.Size = new Size(190, 37);
            lblHoTenTS.TabIndex = 13;
            lblHoTenTS.Text = "Họ tên thí sinh:";
            // 
            // txtHoTenThiSinh
            // 
            txtHoTenThiSinh.Location = new Point(252, 58);
            txtHoTenThiSinh.Margin = new Padding(5, 5, 5, 5);
            txtHoTenThiSinh.Name = "txtHoTenThiSinh";
            txtHoTenThiSinh.Size = new Size(290, 39);
            txtHoTenThiSinh.TabIndex = 14;
            // 
            // lblNgaySinhTS
            // 
            lblNgaySinhTS.Location = new Point(29, 253);
            lblNgaySinhTS.Margin = new Padding(5, 0, 5, 0);
            lblNgaySinhTS.Name = "lblNgaySinhTS";
            lblNgaySinhTS.Size = new Size(185, 37);
            lblNgaySinhTS.TabIndex = 15;
            lblNgaySinhTS.Text = "Ngày sinh (TS):";
            // 
            // dtpNgaySinhTS
            // 
            dtpNgaySinhTS.Format = DateTimePickerFormat.Short;
            dtpNgaySinhTS.Location = new Point(252, 253);
            dtpNgaySinhTS.Margin = new Padding(5, 5, 5, 5);
            dtpNgaySinhTS.Name = "dtpNgaySinhTS";
            dtpNgaySinhTS.Size = new Size(290, 39);
            dtpNgaySinhTS.TabIndex = 16;
            // 
            // lblCMND
            // 
            lblCMND.Location = new Point(29, 157);
            lblCMND.Margin = new Padding(5, 0, 5, 0);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(162, 37);
            lblCMND.TabIndex = 17;
            lblCMND.Text = "CMND/CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(252, 157);
            txtCCCD.Margin = new Padding(5, 5, 5, 5);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(290, 39);
            txtCCCD.TabIndex = 18;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(29, 350);
            lblGioiTinh.Margin = new Padding(5, 0, 5, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(185, 37);
            lblGioiTinh.TabIndex = 19;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGioiTinh.Location = new Point(252, 350);
            cmbGioiTinh.Margin = new Padding(5, 5, 5, 5);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(290, 40);
            cmbGioiTinh.TabIndex = 20;
            // 
            // btnThemThiSinh
            // 
            btnThemThiSinh.BackColor = Color.MediumSeaGreen;
            btnThemThiSinh.FlatStyle = FlatStyle.Flat;
            btnThemThiSinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThemThiSinh.ForeColor = Color.White;
            btnThemThiSinh.Location = new Point(335, 440);
            btnThemThiSinh.Margin = new Padding(5, 5, 5, 5);
            btnThemThiSinh.Name = "btnThemThiSinh";
            btnThemThiSinh.Size = new Size(210, 64);
            btnThemThiSinh.TabIndex = 12;
            btnThemThiSinh.Text = "Thêm thí sinh";
            btnThemThiSinh.UseVisualStyleBackColor = false;
            btnThemThiSinh.Click += btnThemThiSinh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThemDichVu);
            groupBox1.Controls.Add(dgvDichVu);
            groupBox1.Location = new Point(58, 230);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(890, 523);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách dich vụ đã đăng ký";
            // 
            // btnThemDichVu
            // 
            btnThemDichVu.BackColor = Color.MediumSeaGreen;
            btnThemDichVu.FlatStyle = FlatStyle.Flat;
            btnThemDichVu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThemDichVu.ForeColor = Color.White;
            btnThemDichVu.Location = new Point(32, 440);
            btnThemDichVu.Margin = new Padding(5, 5, 5, 5);
            btnThemDichVu.Name = "btnThemDichVu";
            btnThemDichVu.Size = new Size(210, 64);
            btnThemDichVu.TabIndex = 11;
            btnThemDichVu.Text = "Thêm dịch vụ";
            btnThemDichVu.UseVisualStyleBackColor = false;
            btnThemDichVu.Click += btnThemDichVu_Click;
            // 
            // dgvDichVu
            // 
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Location = new Point(18, 62);
            dgvDichVu.Margin = new Padding(5, 5, 5, 5);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.RowHeadersWidth = 51;
            dgvDichVu.Size = new Size(863, 352);
            dgvDichVu.TabIndex = 0;
            dgvDichVu.CellContentClick += dgvDichVu_CellContentClick;
            // 
            // btnLuuLai
            // 
            btnLuuLai.BackColor = Color.MediumSeaGreen;
            btnLuuLai.FlatStyle = FlatStyle.Flat;
            btnLuuLai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuuLai.ForeColor = Color.White;
            btnLuuLai.Location = new Point(1263, 1290);
            btnLuuLai.Margin = new Padding(5, 5, 5, 5);
            btnLuuLai.Name = "btnLuuLai";
            btnLuuLai.Size = new Size(260, 72);
            btnLuuLai.TabIndex = 16;
            btnLuuLai.Text = "📝 Lưu lại";
            btnLuuLai.UseVisualStyleBackColor = false;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(775, 69);
            txtTenKhachHang.Margin = new Padding(5, 5, 5, 5);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(290, 39);
            txtTenKhachHang.TabIndex = 3;
            // 
            // lblTenKH
            // 
            lblTenKH.Location = new Point(580, 75);
            lblTenKH.Margin = new Padding(5, 0, 5, 0);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(185, 37);
            lblTenKH.TabIndex = 2;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // cmbLoaiKhachHang
            // 
            cmbLoaiKhachHang.Location = new Point(252, 70);
            cmbLoaiKhachHang.Margin = new Padding(5, 5, 5, 5);
            cmbLoaiKhachHang.Name = "cmbLoaiKhachHang";
            cmbLoaiKhachHang.Size = new Size(290, 40);
            cmbLoaiKhachHang.TabIndex = 1;
            // 
            // lblLoaiKH
            // 
            lblLoaiKH.Location = new Point(32, 78);
            lblLoaiKH.Margin = new Padding(5, 0, 5, 0);
            lblLoaiKH.Name = "lblLoaiKH";
            lblLoaiKH.Size = new Size(210, 37);
            lblLoaiKH.TabIndex = 0;
            lblLoaiKH.Text = "Loại khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1092, 75);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 10;
            label1.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1180, 72);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 39);
            txtEmail.TabIndex = 11;
            // 
            // lblMaPhieuDangKy
            // 
            lblMaPhieuDangKy.AutoSize = true;
            lblMaPhieuDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaPhieuDangKy.Location = new Point(304, -3);
            lblMaPhieuDangKy.Margin = new Padding(5, 0, 5, 0);
            lblMaPhieuDangKy.Name = "lblMaPhieuDangKy";

            lblMaPhieuDangKy.Size = new Size(74, 45);

            lblMaPhieuDangKy.TabIndex = 12;
            lblMaPhieuDangKy.Text = "1";
            // 
            // groupKhachHang
            // 
            groupKhachHang.Controls.Add(lblMaPhieuDangKy);
            groupKhachHang.Controls.Add(txtEmail);
            groupKhachHang.Controls.Add(label1);
            groupKhachHang.Controls.Add(lblLoaiKH);
            groupKhachHang.Controls.Add(cmbLoaiKhachHang);
            groupKhachHang.Controls.Add(lblTenKH);
            groupKhachHang.Controls.Add(txtTenKhachHang);
            groupKhachHang.Location = new Point(42, 18);
            groupKhachHang.Margin = new Padding(5, 5, 5, 5);
            groupKhachHang.Name = "groupKhachHang";
            groupKhachHang.Padding = new Padding(5, 5, 5, 5);
            groupKhachHang.Size = new Size(1495, 203);
            groupKhachHang.TabIndex = 15;
            groupKhachHang.TabStop = false;
            groupKhachHang.Text = "Thông tin phiếu đăng ký";
            // 
            // MH_TAOPHIEUDANGKY2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 1258);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupKhachHang);
            Controls.Add(btnLuuLai);
            Name = "MH_TAOPHIEUDANGKY2";
            Text = "gig";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThiSinh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            groupKhachHang.ResumeLayout(false);
            groupKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dgvThiSinh;
        private GroupBox groupBox2;
        private Label lblHoTenTS;
        private TextBox txtHoTenThiSinh;
        private Label lblNgaySinhTS;
        private DateTimePicker dtpNgaySinhTS;
        private Label lblCMND;
        private TextBox txtCCCD;
        private Label lblGioiTinh;
        private ComboBox cmbGioiTinh;
        private Button btnThemThiSinh;
        private GroupBox groupBox1;
        private Button btnThemDichVu;
        private DataGridView dgvDichVu;
        private Button btnLuuLai;
        //private Label lblDiaChiDV;
        private TextBox txtTenKhachHang;
        private Label lblTenKH;
        private ComboBox cmbLoaiKhachHang;
        private Label lblLoaiKH;
        private Label label1;
        private TextBox txtEmail;
        private Label lblMaPhieuDangKy;
        private GroupBox groupKhachHang;
    }
}