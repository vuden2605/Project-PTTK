namespace Project_PTTK
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
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
            btnXemChiTietPhieu.Location = new Point(915, 907);
            btnXemChiTietPhieu.Margin = new Padding(5, 5, 5, 5);
            btnXemChiTietPhieu.Name = "btnXemChiTietPhieu";
            btnXemChiTietPhieu.Size = new Size(273, 72);
            btnXemChiTietPhieu.TabIndex = 22;
            btnXemChiTietPhieu.Text = "Xem chi tiết phiếu";
            btnXemChiTietPhieu.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPhieuDangKy);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(55, 403);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 494);
            panel1.TabIndex = 21;
            // 
            // dgvPhieuDangKy
            // 
            dgvPhieuDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuDangKy.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dgvPhieuDangKy.Location = new Point(32, 54);
            dgvPhieuDangKy.Margin = new Padding(5, 5, 5, 5);
            dgvPhieuDangKy.Name = "dgvPhieuDangKy";
            dgvPhieuDangKy.RowHeadersWidth = 51;
            dgvPhieuDangKy.Size = new Size(1100, 440);
            dgvPhieuDangKy.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(5, -2);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 32);
            label2.TabIndex = 0;
            label2.Text = "DANH SÁCH PHIẾU ĐĂNG KÝ";
            // 
            // btnTaoPhieuDangKy
            // 
            btnTaoPhieuDangKy.BackColor = Color.MediumSeaGreen;
            btnTaoPhieuDangKy.FlatStyle = FlatStyle.Flat;
            btnTaoPhieuDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaoPhieuDangKy.ForeColor = Color.White;
            btnTaoPhieuDangKy.Location = new Point(505, 285);
            btnTaoPhieuDangKy.Margin = new Padding(5, 5, 5, 5);
            btnTaoPhieuDangKy.Name = "btnTaoPhieuDangKy";
            btnTaoPhieuDangKy.Size = new Size(336, 72);
            btnTaoPhieuDangKy.TabIndex = 20;
            btnTaoPhieuDangKy.Text = "📝 Tạo phiếu đăng ký";
            btnTaoPhieuDangKy.UseVisualStyleBackColor = false;
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
            groupKhachHang.Location = new Point(55, 19);
            groupKhachHang.Margin = new Padding(5, 5, 5, 5);
            groupKhachHang.Name = "groupKhachHang";
            groupKhachHang.Padding = new Padding(5, 5, 5, 5);
            groupKhachHang.Size = new Size(1170, 256);
            groupKhachHang.TabIndex = 19;
            groupKhachHang.TabStop = false;
            groupKhachHang.Text = "Thông tin khách hàng";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(260, 168);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 39);
            txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 173);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 10;
            label1.Text = "Email:";
            // 
            // lblNgaySinhKH
            // 
            lblNgaySinhKH.Location = new Point(601, 45);
            lblNgaySinhKH.Margin = new Padding(5, 0, 5, 0);
            lblNgaySinhKH.Name = "lblNgaySinhKH";
            lblNgaySinhKH.Size = new Size(138, 37);
            lblNgaySinhKH.TabIndex = 4;
            lblNgaySinhKH.Text = "Ngày sinh:";
            // 
            // lblLoaiKH
            // 
            lblLoaiKH.Location = new Point(32, 48);
            lblLoaiKH.Margin = new Padding(5, 0, 5, 0);
            lblLoaiKH.Name = "lblLoaiKH";
            lblLoaiKH.Size = new Size(218, 37);
            lblLoaiKH.TabIndex = 0;
            lblLoaiKH.Text = "Loại khách hàng:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(796, 40);
            dtpNgaySinh.Margin = new Padding(5, 5, 5, 5);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(290, 39);
            dtpNgaySinh.TabIndex = 5;
            // 
            // cmbLoaiKhachHang
            // 
            cmbLoaiKhachHang.Location = new Point(260, 45);
            cmbLoaiKhachHang.Margin = new Padding(5, 5, 5, 5);
            cmbLoaiKhachHang.Name = "cmbLoaiKhachHang";
            cmbLoaiKhachHang.Size = new Size(290, 40);
            cmbLoaiKhachHang.TabIndex = 1;
            // 
            // lblTenKH
            // 
            lblTenKH.Location = new Point(32, 110);
            lblTenKH.Margin = new Padding(5, 0, 5, 0);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(185, 37);
            lblTenKH.TabIndex = 2;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(260, 101);
            txtTenKhachHang.Margin = new Padding(5, 5, 5, 5);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(290, 39);
            txtTenKhachHang.TabIndex = 3;
            // 
            // lblTenDV
            // 
            lblTenDV.Location = new Point(601, 110);
            lblTenDV.Margin = new Padding(5, 0, 5, 0);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Size = new Size(162, 37);
            lblTenDV.TabIndex = 6;
            lblTenDV.Text = "Tên đơn vị:";
            // 
            // txtTenDonVi
            // 
            txtTenDonVi.Location = new Point(796, 104);
            txtTenDonVi.Margin = new Padding(5, 5, 5, 5);
            txtTenDonVi.Name = "txtTenDonVi";
            txtTenDonVi.Size = new Size(290, 39);
            txtTenDonVi.TabIndex = 7;
            // 
            // lblDiaChiDV
            // 
            lblDiaChiDV.Location = new Point(601, 178);
            lblDiaChiDV.Margin = new Padding(5, 0, 5, 0);
            lblDiaChiDV.Name = "lblDiaChiDV";
            lblDiaChiDV.Size = new Size(185, 37);
            lblDiaChiDV.TabIndex = 8;
            lblDiaChiDV.Text = "Địa chỉ đơn vị:";
            // 
            // txtDiaChiDonVi
            // 
            txtDiaChiDonVi.Location = new Point(796, 173);
            txtDiaChiDonVi.Margin = new Padding(5, 5, 5, 5);
            txtDiaChiDonVi.Name = "txtDiaChiDonVi";
            txtDiaChiDonVi.Size = new Size(290, 39);
            txtDiaChiDonVi.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã phiếu đăng ký";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên khách hàng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 230;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày tạo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 230;
            // 
            // MH_TAOPHIEUDANGKY1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 998);
            Controls.Add(btnXemChiTietPhieu);
            Controls.Add(panel1);
            Controls.Add(btnTaoPhieuDangKy);
            Controls.Add(groupKhachHang);
            Margin = new Padding(5, 5, 5, 5);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}