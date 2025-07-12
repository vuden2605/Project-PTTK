namespace Project_PTTK
{
    partial class MH_TAOPHIEUGIAHAN
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
            txtTenKH = new TextBox();
            label2 = new Label();
            txtMaPhieu = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnChonDichVu = new Button();
            dgvDichVuDaDK = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dgvLichThiMoi = new DataGridView();
            label4 = new Label();
            cmbLyDo = new ComboBox();
            label3 = new Label();
            btnTaoPhieuGiaHan = new Button();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVuDaDK).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichThiMoi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(608, 68);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phiếu Đăng Ký";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(431, 29);
            txtTenKH.Margin = new Padding(2);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(150, 27);
            txtTenKH.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(126, 27);
            txtMaPhieu.Margin = new Padding(2);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(150, 27);
            txtMaPhieu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChonDichVu);
            groupBox2.Controls.Add(dgvDichVuDaDK);
            groupBox2.Location = new Point(22, 111);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(608, 194);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn dịch vụ cần gia hạn";
            // 
            // btnChonDichVu
            // 
            btnChonDichVu.BackColor = Color.MediumSeaGreen;
            btnChonDichVu.FlatStyle = FlatStyle.Flat;
            btnChonDichVu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChonDichVu.ForeColor = Color.White;
            btnChonDichVu.Location = new Point(270, 152);
            btnChonDichVu.Name = "btnChonDichVu";
            btnChonDichVu.Size = new Size(68, 30);
            btnChonDichVu.TabIndex = 23;
            btnChonDichVu.Text = "Chọn";
            btnChonDichVu.UseVisualStyleBackColor = false;
            btnChonDichVu.Click += btnChonDichVu_Click;
            // 
            // dgvDichVuDaDK
            // 
            dgvDichVuDaDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVuDaDK.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvDichVuDaDK.Location = new Point(20, 25);
            dgvDichVuDaDK.Margin = new Padding(2);
            dgvDichVuDaDK.Name = "dgvDichVuDaDK";
            dgvDichVuDaDK.RowHeadersWidth = 82;
            dgvDichVuDaDK.Size = new Size(583, 116);
            dgvDichVuDaDK.TabIndex = 0;
            dgvDichVuDaDK.CellContentClick += dgvDichVuDaDK_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Mã dịch vụ";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên dịch vụ";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvLichThiMoi);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cmbLyDo);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(32, 356);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(608, 239);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin Phiếu gia hạn";
            // 
            // dgvLichThiMoi
            // 
            dgvLichThiMoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichThiMoi.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8 });
            dgvLichThiMoi.Location = new Point(20, 111);
            dgvLichThiMoi.Margin = new Padding(2);
            dgvLichThiMoi.Name = "dgvLichThiMoi";
            dgvLichThiMoi.RowHeadersWidth = 82;
            dgvLichThiMoi.Size = new Size(584, 117);
            dgvLichThiMoi.TabIndex = 7;
            dgvLichThiMoi.CellContentClick += dgvLichThiMoi_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 78);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 6;
            label4.Text = "Lịch thi mới:";
            // 
            // cmbLyDo
            // 
            cmbLyDo.FormattingEnabled = true;
            cmbLyDo.Items.AddRange(new object[] { "Đặc biệt", "Không đặc biệt" });
            cmbLyDo.Location = new Point(120, 28);
            cmbLyDo.Margin = new Padding(2);
            cmbLyDo.Name = "cmbLyDo";
            cmbLyDo.Size = new Size(150, 28);
            cmbLyDo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Lý do:";
            // 
            // btnTaoPhieuGiaHan
            // 
            btnTaoPhieuGiaHan.BackColor = Color.MediumSeaGreen;
            btnTaoPhieuGiaHan.FlatStyle = FlatStyle.Flat;
            btnTaoPhieuGiaHan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaoPhieuGiaHan.ForeColor = Color.White;
            btnTaoPhieuGiaHan.Location = new Point(224, 599);
            btnTaoPhieuGiaHan.Name = "btnTaoPhieuGiaHan";
            btnTaoPhieuGiaHan.Size = new Size(207, 45);
            btnTaoPhieuGiaHan.TabIndex = 21;
            btnTaoPhieuGiaHan.Text = "📝 Tạo phiếu gia hạn";
            btnTaoPhieuGiaHan.UseVisualStyleBackColor = false;
            btnTaoPhieuGiaHan.Click += btnTaoPhieuGiaHan_Click;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Mã lịch thi";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Ngày thi";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "Giờ thi";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // MH_TAOPHIEUGIAHAN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 659);
            Controls.Add(btnTaoPhieuGiaHan);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Location = new Point(32, 48);
            Margin = new Padding(2);
            Name = "MH_TAOPHIEUGIAHAN";
            Text = "MH_TAOPHIEUGIAHAN";
            Load += MH_TAOPHIEUGIAHAN_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDichVuDaDK).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichThiMoi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMaPhieu;
        private Label label1;
        private Label label2;
        private TextBox txtTenKH;
        private GroupBox groupBox2;
        private DataGridView dgvDichVuDaDK;
        private Button btnChonDichVu;
        private GroupBox groupBox3;
        private DataGridView dgvLichThiMoi;
        private Label label4;
        private ComboBox cmbLyDo;
        private Label label3;
        private Button btnTaoPhieuGiaHan;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}