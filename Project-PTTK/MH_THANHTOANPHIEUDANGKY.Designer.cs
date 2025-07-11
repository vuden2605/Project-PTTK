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
            dgvPhieuChuaThanhToan = new DataGridView();
            groupPhieu = new GroupBox();
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
            groupBox1 = new GroupBox();
            dgvChiTietPhieu = new DataGridView();
            lblMaPhieu = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            btnXemChiTietPhieu = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnXacNhanThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChuaThanhToan).BeginInit();
            groupPhieu.SuspendLayout();
            groupHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            SuspendLayout();
            // 
            // dgvPhieuChuaThanhToan
            // 
            dgvPhieuChuaThanhToan.ColumnHeadersHeight = 29;
            dgvPhieuChuaThanhToan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvPhieuChuaThanhToan.Location = new Point(58, 26);
            dgvPhieuChuaThanhToan.Name = "dgvPhieuChuaThanhToan";
            dgvPhieuChuaThanhToan.ReadOnly = true;
            dgvPhieuChuaThanhToan.RowHeadersWidth = 51;
            dgvPhieuChuaThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuChuaThanhToan.Size = new Size(598, 205);
            dgvPhieuChuaThanhToan.TabIndex = 4;
            // 
            // groupPhieu
            // 
            groupPhieu.Controls.Add(lblMaPhieu);
            groupPhieu.Controls.Add(dgvChiTietPhieu);
            groupPhieu.Location = new Point(73, 255);
            groupPhieu.Name = "groupPhieu";
            groupPhieu.Size = new Size(800, 254);
            groupPhieu.TabIndex = 5;
            groupPhieu.TabStop = false;
            groupPhieu.Text = "Thông tin Phiếu Đăng Ký";
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
            groupHoaDon.Location = new Point(73, 531);
            groupHoaDon.Name = "groupHoaDon";
            groupHoaDon.Size = new Size(800, 100);
            groupHoaDon.TabIndex = 6;
            groupHoaDon.TabStop = false;
            groupHoaDon.Text = "Hóa Đơn";
            // 
            // lblPhuongThuc
            // 
            lblPhuongThuc.Location = new Point(59, 27);
            lblPhuongThuc.Name = "lblPhuongThuc";
            lblPhuongThuc.Size = new Size(100, 23);
            lblPhuongThuc.TabIndex = 0;
            lblPhuongThuc.Text = "Phương thức:";
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.Location = new Point(169, 25);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(180, 28);
            cboPhuongThuc.TabIndex = 1;
            // 
            // lblSoTien
            // 
            lblSoTien.Location = new Point(466, 30);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(100, 23);
            lblSoTien.TabIndex = 2;
            lblSoTien.Text = "Số tiền:";
            // 
            // nudSoTien
            // 
            nudSoTien.Location = new Point(572, 30);
            nudSoTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudSoTien.Name = "nudSoTien";
            nudSoTien.Size = new Size(120, 27);
            nudSoTien.TabIndex = 3;
            // 
            // lblChietKhau
            // 
            lblChietKhau.Location = new Point(59, 62);
            lblChietKhau.Name = "lblChietKhau";
            lblChietKhau.Size = new Size(100, 23);
            lblChietKhau.TabIndex = 4;
            lblChietKhau.Text = "Chiết khấu (%):";
            // 
            // nudChietKhau
            // 
            nudChietKhau.Location = new Point(169, 60);
            nudChietKhau.Name = "nudChietKhau";
            nudChietKhau.Size = new Size(120, 27);
            nudChietKhau.TabIndex = 5;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(466, 65);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(100, 23);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // nudTongTien
            // 
            nudTongTien.Location = new Point(572, 63);
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
            btnXacNhan.Location = new Point(404, 780);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(220, 40);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "✅ Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXemChiTietPhieu);
            groupBox1.Controls.Add(dgvPhieuChuaThanhToan);
            groupBox1.Location = new Point(73, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 237);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu đăng ký cần thanh toán";
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieu.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            dgvChiTietPhieu.Location = new Point(58, 38);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.RowHeadersWidth = 51;
            dgvChiTietPhieu.Size = new Size(701, 188);
            dgvChiTietPhieu.TabIndex = 0;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaPhieu.Location = new Point(185, -3);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(48, 28);
            lblMaPhieu.TabIndex = 1;
            lblMaPhieu.Text = "001";
            // 
            // Column5
            // 
            Column5.HeaderText = "Mã dịch vụ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tên dịch vụ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Giá";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Số lượng thí sinh";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Thành tiền";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // btnXemChiTietPhieu
            // 
            btnXemChiTietPhieu.BackColor = Color.MediumSeaGreen;
            btnXemChiTietPhieu.FlatStyle = FlatStyle.Flat;
            btnXemChiTietPhieu.ForeColor = Color.White;
            btnXemChiTietPhieu.Location = new Point(671, 99);
            btnXemChiTietPhieu.Name = "btnXemChiTietPhieu";
            btnXemChiTietPhieu.Size = new Size(113, 40);
            btnXemChiTietPhieu.TabIndex = 5;
            btnXemChiTietPhieu.Text = "Xem chi tiết";
            btnXemChiTietPhieu.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã phiếu đăng ký";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày tạo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Loại khách hàng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // btnXacNhanThanhToan
            // 
            btnXacNhanThanhToan.BackColor = Color.MediumSeaGreen;
            btnXacNhanThanhToan.FlatStyle = FlatStyle.Flat;
            btnXacNhanThanhToan.ForeColor = Color.White;
            btnXacNhanThanhToan.Location = new Point(645, 671);
            btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            btnXacNhanThanhToan.Size = new Size(220, 40);
            btnXacNhanThanhToan.TabIndex = 9;
            btnXacNhanThanhToan.Text = "✅ Xác nhận thanh toán";
            btnXacNhanThanhToan.UseVisualStyleBackColor = false;
            // 
            // MH_THANHTOANPHIEUDANGKY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 736);
            Controls.Add(btnXacNhanThanhToan);
            Controls.Add(groupBox1);
            Controls.Add(groupPhieu);
            Controls.Add(groupHoaDon);
            Controls.Add(btnXacNhan);
            Name = "MH_THANHTOANPHIEUDANGKY";
            Text = "MH_THANHTOANPHIEUDANGKY";
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChuaThanhToan).EndInit();
            groupPhieu.ResumeLayout(false);
            groupPhieu.PerformLayout();
            groupHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPhieuChuaThanhToan;
        private GroupBox groupPhieu;
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
        private Label lblMaPhieu;
        private DataGridView dgvChiTietPhieu;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnXemChiTietPhieu;
        private Button btnXacNhanThanhToan;
    }
}