﻿namespace Project_PTTK
{
    partial class MH_TAOPHIEUDANGKY1
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
            btnXemChiTietPhieu = new Button();
            panel1 = new Panel();
            dgvPhieuDangKy = new DataGridView();
            label2 = new Label();
            btnTaoPhieuDangKy = new Button();
            groupKhachHang = new GroupBox();
            txtEmail = new TextBox();
            label1 = new Label();
            lblNgaySinhKH = new Label();
            lblLoaiKH = new Label();
            dtpNgaySinh = new DateTimePicker();
            cmbLoaiKhachHang = new ComboBox();
            lblTenKH = new Label();
            txtTenKhachHang = new TextBox();
            lblTenDV = new Label();
            txtTenDonVi = new TextBox();
            lblDiaChiDV = new Label();
            txtDiaChiDonVi = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDangKy).BeginInit();
            groupKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // btnXemChiTietPhieu
            // 
            btnXemChiTietPhieu.BackColor = Color.MediumSeaGreen;
            btnXemChiTietPhieu.FlatStyle = FlatStyle.Flat;
            btnXemChiTietPhieu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXemChiTietPhieu.ForeColor = Color.White;
            btnXemChiTietPhieu.Location = new Point(563, 567);
            btnXemChiTietPhieu.Name = "btnXemChiTietPhieu";
            btnXemChiTietPhieu.Size = new Size(168, 45);
            btnXemChiTietPhieu.TabIndex = 22;
            btnXemChiTietPhieu.Text = "Xem chi tiết phiếu";
            btnXemChiTietPhieu.UseVisualStyleBackColor = false;
            btnXemChiTietPhieu.Click += btnXemChiTietPhieu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPhieuDangKy);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(34, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 309);
            panel1.TabIndex = 21;
            // 
            // dgvPhieuDangKy
            // 
            dgvPhieuDangKy.AllowUserToAddRows = false;
            dgvPhieuDangKy.AllowUserToDeleteRows = false;
            dgvPhieuDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuDangKy.Location = new Point(20, 34);
            dgvPhieuDangKy.Name = "dgvPhieuDangKy";
            dgvPhieuDangKy.ReadOnly = true;
            dgvPhieuDangKy.RowHeadersWidth = 51;
            dgvPhieuDangKy.Size = new Size(677, 275);
            dgvPhieuDangKy.TabIndex = 0;
            dgvPhieuDangKy.CellContentClick += dgvPhieuDangKy_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, -1);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 0;
            label2.Text = "DANH SÁCH PHIẾU ĐĂNG KÝ";
            // 
            // btnTaoPhieuDangKy
            // 
            btnTaoPhieuDangKy.BackColor = Color.MediumSeaGreen;
            btnTaoPhieuDangKy.FlatStyle = FlatStyle.Flat;
            btnTaoPhieuDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaoPhieuDangKy.ForeColor = Color.White;
            btnTaoPhieuDangKy.Location = new Point(311, 178);
            btnTaoPhieuDangKy.Name = "btnTaoPhieuDangKy";
            btnTaoPhieuDangKy.Size = new Size(207, 45);
            btnTaoPhieuDangKy.TabIndex = 20;
            btnTaoPhieuDangKy.Text = "📝 Tạo phiếu đăng ký";
            btnTaoPhieuDangKy.UseVisualStyleBackColor = false;
            btnTaoPhieuDangKy.Click += btnTaoPhieuDangKy_Click_1;
            // 
            // groupKhachHang
            // 
            groupKhachHang.Controls.Add(txtEmail);
            groupKhachHang.Controls.Add(label1);
            groupKhachHang.Controls.Add(lblNgaySinhKH);
            groupKhachHang.Controls.Add(lblLoaiKH);
            groupKhachHang.Controls.Add(dtpNgaySinh);
            groupKhachHang.Controls.Add(cmbLoaiKhachHang);
            groupKhachHang.Controls.Add(lblTenKH);
            groupKhachHang.Controls.Add(txtTenKhachHang);
            groupKhachHang.Controls.Add(lblTenDV);
            groupKhachHang.Controls.Add(txtTenDonVi);
            groupKhachHang.Controls.Add(lblDiaChiDV);
            groupKhachHang.Controls.Add(txtDiaChiDonVi);
            groupKhachHang.Location = new Point(34, 12);
            groupKhachHang.Name = "groupKhachHang";
            groupKhachHang.Size = new Size(720, 160);
            groupKhachHang.TabIndex = 19;
            groupKhachHang.TabStop = false;
            groupKhachHang.Text = "Thông tin khách hàng";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 108);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Email:";
            // 
            // lblNgaySinhKH
            // 
            lblNgaySinhKH.Location = new Point(370, 28);
            lblNgaySinhKH.Name = "lblNgaySinhKH";
            lblNgaySinhKH.Size = new Size(85, 23);
            lblNgaySinhKH.TabIndex = 4;
            lblNgaySinhKH.Text = "Ngày sinh:";
            // 
            // lblLoaiKH
            // 
            lblLoaiKH.Location = new Point(20, 30);
            lblLoaiKH.Name = "lblLoaiKH";
            lblLoaiKH.Size = new Size(134, 23);
            lblLoaiKH.TabIndex = 0;
            lblLoaiKH.Text = "Loại khách hàng:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(490, 25);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(180, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // cmbLoaiKhachHang
            // 
            cmbLoaiKhachHang.Items.AddRange(new object[] { "Đơn vị", "Tự do" });
            cmbLoaiKhachHang.Location = new Point(160, 28);
            cmbLoaiKhachHang.Name = "cmbLoaiKhachHang";
            cmbLoaiKhachHang.Size = new Size(180, 28);
            cmbLoaiKhachHang.TabIndex = 1;
            cmbLoaiKhachHang.SelectedIndexChanged += cmbLoaiKhachHang_SelectedIndexChanged;
            // 
            // lblTenKH
            // 
            lblTenKH.Location = new Point(20, 69);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(114, 23);
            lblTenKH.TabIndex = 2;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(160, 63);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(180, 27);
            txtTenKhachHang.TabIndex = 3;
            // 
            // lblTenDV
            // 
            lblTenDV.Location = new Point(370, 69);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Size = new Size(100, 23);
            lblTenDV.TabIndex = 6;
            lblTenDV.Text = "Tên đơn vị:";
            // 
            // txtTenDonVi
            // 
            txtTenDonVi.Location = new Point(490, 65);
            txtTenDonVi.Name = "txtTenDonVi";
            txtTenDonVi.Size = new Size(180, 27);
            txtTenDonVi.TabIndex = 7;
            // 
            // lblDiaChiDV
            // 
            lblDiaChiDV.Location = new Point(370, 111);
            lblDiaChiDV.Name = "lblDiaChiDV";
            lblDiaChiDV.Size = new Size(114, 23);
            lblDiaChiDV.TabIndex = 8;
            lblDiaChiDV.Text = "Địa chỉ đơn vị:";
            // 
            // txtDiaChiDonVi
            // 
            txtDiaChiDonVi.Location = new Point(490, 108);
            txtDiaChiDonVi.Name = "txtDiaChiDonVi";
            txtDiaChiDonVi.Size = new Size(180, 27);
            txtDiaChiDonVi.TabIndex = 9;
            // 
            // MH_TAOPHIEUDANGKY1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 624);
            Controls.Add(btnXemChiTietPhieu);
            Controls.Add(panel1);
            Controls.Add(btnTaoPhieuDangKy);
            Controls.Add(groupKhachHang);
            Name = "MH_TAOPHIEUDANGKY1";
            Text = "MH_TAOPHIEUDANGKY1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDangKy).EndInit();
            groupKhachHang.ResumeLayout(false);
            groupKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnXemChiTietPhieu;
        private Panel panel1;
        private DataGridView dgvPhieuDangKy;
        private Label label2;
        private Button btnTaoPhieuDangKy;
        private GroupBox groupKhachHang;
        private TextBox txtEmail;
        private Label label1;
        private Label lblNgaySinhKH;
        private Label lblLoaiKH;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cmbLoaiKhachHang;
        private Label lblTenKH;
        private TextBox txtTenKhachHang;
        private Label lblTenDV;
        private TextBox txtTenDonVi;
        private Label lblDiaChiDV;
        private TextBox txtDiaChiDonVi;
    }
}