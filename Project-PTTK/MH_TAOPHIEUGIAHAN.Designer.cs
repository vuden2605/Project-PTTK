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
            groupBox3 = new GroupBox();
            dgvLichThiMoi = new DataGridView();
            label4 = new Label();
            cmbLyDo = new ComboBox();
            label3 = new Label();
            btnTaoPhieuGiaHan = new Button();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
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
            groupBox1.Location = new Point(42, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 109);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phiếu Đăng Ký";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(701, 46);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(241, 39);
            txtTenKH.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 46);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(205, 43);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(241, 39);
            txtMaPhieu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 48);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChonDichVu);
            groupBox2.Controls.Add(dgvDichVuDaDK);
            groupBox2.Location = new Point(36, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(988, 310);
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
            btnChonDichVu.Location = new Point(418, 244);
            btnChonDichVu.Margin = new Padding(5);
            btnChonDichVu.Name = "btnChonDichVu";
            btnChonDichVu.Size = new Size(110, 48);
            btnChonDichVu.TabIndex = 23;
            btnChonDichVu.Text = "Chọn";
            btnChonDichVu.UseVisualStyleBackColor = false;
            // 
            // dgvDichVuDaDK
            // 
            dgvDichVuDaDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVuDaDK.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvDichVuDaDK.Location = new Point(32, 40);
            dgvDichVuDaDK.Name = "dgvDichVuDaDK";
            dgvDichVuDaDK.RowHeadersWidth = 82;
            dgvDichVuDaDK.Size = new Size(948, 185);
            dgvDichVuDaDK.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvLichThiMoi);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cmbLyDo);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(52, 569);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(988, 382);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin Phiếu gia hạn";
            // 
            // dgvLichThiMoi
            // 
            dgvLichThiMoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichThiMoi.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8 });
            dgvLichThiMoi.Location = new Point(32, 177);
            dgvLichThiMoi.Name = "dgvLichThiMoi";
            dgvLichThiMoi.RowHeadersWidth = 82;
            dgvLichThiMoi.Size = new Size(681, 187);
            dgvLichThiMoi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 125);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 6;
            label4.Text = "Lịch thi mới:";
            // 
            // cmbLyDo
            // 
            cmbLyDo.FormattingEnabled = true;
            cmbLyDo.Location = new Point(195, 44);
            cmbLyDo.Name = "cmbLyDo";
            cmbLyDo.Size = new Size(241, 40);
            cmbLyDo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 52);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 4;
            label3.Text = "Lý do:";
            // 
            // btnTaoPhieuGiaHan
            // 
            btnTaoPhieuGiaHan.BackColor = Color.MediumSeaGreen;
            btnTaoPhieuGiaHan.FlatStyle = FlatStyle.Flat;
            btnTaoPhieuGiaHan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaoPhieuGiaHan.ForeColor = Color.White;
            btnTaoPhieuGiaHan.Location = new Point(364, 959);
            btnTaoPhieuGiaHan.Margin = new Padding(5);
            btnTaoPhieuGiaHan.Name = "btnTaoPhieuGiaHan";
            btnTaoPhieuGiaHan.Size = new Size(336, 72);
            btnTaoPhieuGiaHan.TabIndex = 21;
            btnTaoPhieuGiaHan.Text = "📝 Tạo phiếu gia hạn";
            btnTaoPhieuGiaHan.UseVisualStyleBackColor = false;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mã lịch thi";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
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
            // Column1
            // 
            Column1.HeaderText = "Mã dịch vụ";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên dịch vụ";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã lịch thi";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày thi";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 170;
            // 
            // Column5
            // 
            Column5.HeaderText = "Giờ thi";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // MH_TAOPHIEUGIAHAN
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 1057);
            Controls.Add(btnTaoPhieuGiaHan);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Location = new Point(32, 48);
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
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}