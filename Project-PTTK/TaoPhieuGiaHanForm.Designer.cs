namespace Project_PTTK
{
    partial class TaoPhieuGiaHanForm
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
            groupPhieuDK = new GroupBox();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblDichVu = new Label();
            txtDichVu = new TextBox();
            lblLichThi = new Label();
            txtLichThi = new TextBox();
            groupPhieuGH = new GroupBox();
            cboLichThiMoi = new ComboBox();
            cboLyDo = new ComboBox();
            lblLyDo = new Label();
            lblLichThiMoi = new Label();
            btnGiaHan = new Button();
            groupPhieuDK.SuspendLayout();
            groupPhieuGH.SuspendLayout();
            SuspendLayout();
            // 
            // groupPhieuDK
            // 
            groupPhieuDK.Controls.Add(lblMaPhieu);
            groupPhieuDK.Controls.Add(txtMaPhieu);
            groupPhieuDK.Controls.Add(lblTenKH);
            groupPhieuDK.Controls.Add(txtTenKH);
            groupPhieuDK.Controls.Add(lblDichVu);
            groupPhieuDK.Controls.Add(txtDichVu);
            groupPhieuDK.Controls.Add(lblLichThi);
            groupPhieuDK.Controls.Add(txtLichThi);
            groupPhieuDK.Location = new Point(22, 12);
            groupPhieuDK.Name = "groupPhieuDK";
            groupPhieuDK.Size = new Size(608, 124);
            groupPhieuDK.TabIndex = 2;
            groupPhieuDK.TabStop = false;
            groupPhieuDK.Text = "Thông tin Phiếu Đăng Ký";
            groupPhieuDK.Enter += groupPhieu_Enter;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.Location = new Point(20, 30);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(100, 23);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã phiếu:";
            lblMaPhieu.Click += lblMaPhieu_Click;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.AllowDrop = true;
            txtMaPhieu.BackColor = SystemColors.Window;
            txtMaPhieu.Location = new Point(126, 27);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(150, 27);
            txtMaPhieu.TabIndex = 1;
            txtMaPhieu.TextChanged += txtMaPhieu_TextChanged;
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
            txtTenKH.Size = new Size(200, 27);
            txtTenKH.TabIndex = 3;
            txtTenKH.TextChanged += txtTenKH_TextChanged;
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
            txtDichVu.Size = new Size(150, 27);
            txtDichVu.TabIndex = 5;
            txtDichVu.TextChanged += txtDichVu_TextChanged;
            // 
            // lblLichThi
            // 
            lblLichThi.Location = new Point(300, 65);
            lblLichThi.Name = "lblLichThi";
            lblLichThi.Size = new Size(100, 23);
            lblLichThi.TabIndex = 6;
            lblLichThi.Text = "Lịch thi:";
            lblLichThi.Click += lblLichThi_Click;
            // 
            // txtLichThi
            // 
            txtLichThi.Location = new Point(400, 63);
            txtLichThi.Name = "txtLichThi";
            txtLichThi.ReadOnly = true;
            txtLichThi.Size = new Size(200, 27);
            txtLichThi.TabIndex = 7;
            txtLichThi.TextChanged += txtLichThi_TextChanged;
            // 
            // groupPhieuGH
            // 
            groupPhieuGH.Controls.Add(cboLichThiMoi);
            groupPhieuGH.Controls.Add(cboLyDo);
            groupPhieuGH.Controls.Add(lblLyDo);
            groupPhieuGH.Controls.Add(lblLichThiMoi);
            groupPhieuGH.Location = new Point(22, 163);
            groupPhieuGH.Name = "groupPhieuGH";
            groupPhieuGH.Size = new Size(608, 124);
            groupPhieuGH.TabIndex = 3;
            groupPhieuGH.TabStop = false;
            groupPhieuGH.Text = "Thông tin Phiếu gia hạn";
            groupPhieuGH.Enter += groupBox1_Enter;
            // 
            // cboLichThiMoi
            // 
            cboLichThiMoi.FormattingEnabled = true;
            cboLichThiMoi.Location = new Point(126, 71);
            cboLichThiMoi.Name = "cboLichThiMoi";
            cboLichThiMoi.Size = new Size(150, 28);
            cboLichThiMoi.TabIndex = 9;
            // 
            // cboLyDo
            // 
            cboLyDo.FormattingEnabled = true;
            cboLyDo.Items.AddRange(new object[] { "Đặc biệt", "Không đặc biệt" });
            cboLyDo.Location = new Point(126, 27);
            cboLyDo.Name = "cboLyDo";
            cboLyDo.Size = new Size(150, 28);
            cboLyDo.TabIndex = 8;
            cboLyDo.SelectedIndexChanged += cboLyDo_SelectedIndexChanged;
            // 
            // lblLyDo
            // 
            lblLyDo.Location = new Point(20, 30);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(100, 23);
            lblLyDo.TabIndex = 0;
            lblLyDo.Text = "Lý do:";
            lblLyDo.Click += label1_Click_1;
            // 
            // lblLichThiMoi
            // 
            lblLichThiMoi.Location = new Point(20, 74);
            lblLichThiMoi.Name = "lblLichThiMoi";
            lblLichThiMoi.Size = new Size(100, 23);
            lblLichThiMoi.TabIndex = 4;
            lblLichThiMoi.Text = "Lịch thi mới:";
            // 
            // btnGiaHan
            // 
            btnGiaHan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGiaHan.BackColor = Color.MediumSeaGreen;
            btnGiaHan.FlatStyle = FlatStyle.Flat;
            btnGiaHan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(226, 317);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(200, 45);
            btnGiaHan.TabIndex = 4;
            btnGiaHan.Text = "📝 Tạo Phiếu Gia Hạn";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // TaoPhieuGiaHanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 394);
            Controls.Add(btnGiaHan);
            Controls.Add(groupPhieuGH);
            Controls.Add(groupPhieuDK);
            Name = "TaoPhieuGiaHanForm";
            Text = "TaoPhieuGiaHanForm";
            Load += TaoPhieuGiaHanForm_Load;
            groupPhieuDK.ResumeLayout(false);
            groupPhieuDK.PerformLayout();
            groupPhieuGH.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupPhieuDK;
        private Label lblMaPhieu;
        private TextBox txtMaPhieu;
        private Label lblTenKH;
        private TextBox txtTenKH;
        private Label lblDichVu;
        private TextBox txtDichVu;
        private Label lblLichThi;
        private TextBox txtLichThi;
        private GroupBox groupPhieuGH;
        private Label lblLichThiMoi;
        private ComboBox cboLyDo;
        private Label lblLyDo;
        private ComboBox cboLichThiMoi;
        private Button btnGiaHan;
    }
}