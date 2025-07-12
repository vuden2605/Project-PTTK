namespace Project_PTTK
{
    partial class MH_TAOPHIEUDANGKY3
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
            lblMaPhieuDangKy = new Label();
            label2 = new Label();
            btnTaoPhieuDangKy = new Button();
            dgvLichThiDV = new DataGridView();
            label1 = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLichThiDV).BeginInit();
            SuspendLayout();
            // 
            // lblMaPhieuDangKy
            // 
            lblMaPhieuDangKy.AutoSize = true;
            lblMaPhieuDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaPhieuDangKy.Location = new Point(337, 10);
            lblMaPhieuDangKy.Name = "lblMaPhieuDangKy";
            lblMaPhieuDangKy.Size = new Size(48, 28);
            lblMaPhieuDangKy.TabIndex = 15;
            lblMaPhieuDangKy.Text = "001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 10);
            label2.Name = "label2";
            label2.Size = new Size(294, 28);
            label2.TabIndex = 14;
            label2.Text = "Thêm dịch vụ cho phiếu đăng ký";
            // 
            // btnTaoPhieuDangKy
            // 
            btnTaoPhieuDangKy.BackColor = Color.MediumSeaGreen;
            btnTaoPhieuDangKy.FlatStyle = FlatStyle.Flat;
            btnTaoPhieuDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaoPhieuDangKy.ForeColor = Color.White;
            btnTaoPhieuDangKy.Location = new Point(190, 418);
            btnTaoPhieuDangKy.Name = "btnTaoPhieuDangKy";
            btnTaoPhieuDangKy.Size = new Size(200, 45);
            btnTaoPhieuDangKy.TabIndex = 13;
            btnTaoPhieuDangKy.Text = "Thêm dịch vụ";
            btnTaoPhieuDangKy.UseVisualStyleBackColor = false;
            btnTaoPhieuDangKy.Click += btnTaoPhieuDangKy_Click;
            // 
            // dgvLichThiDV
            // 
            dgvLichThiDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichThiDV.Location = new Point(37, 90);
            dgvLichThiDV.Name = "dgvLichThiDV";
            dgvLichThiDV.RowHeadersWidth = 51;
            dgvLichThiDV.Size = new Size(726, 321);
            dgvLichThiDV.TabIndex = 12;
            dgvLichThiDV.CellContentClick += dgvLichThiDV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(37, 58);
            label1.Name = "label1";
            label1.Size = new Size(439, 20);
            label1.TabIndex = 11;
            label1.Text = "DANH SÁCH DỊCH VỤ VÀ LỊCH THI HIỆN CÓ TẠI TRUNG TÂM";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Crimson;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(436, 418);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(96, 45);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // MH_TAOPHIEUDANGKY3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(btnThoat);
            Controls.Add(lblMaPhieuDangKy);
            Controls.Add(label2);
            Controls.Add(btnTaoPhieuDangKy);
            Controls.Add(dgvLichThiDV);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "MH_TAOPHIEUDANGKY3";
            Text = "MH_TAOPHIEUDANGKY3";
            ((System.ComponentModel.ISupportInitialize)dgvLichThiDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaPhieuDangKy;
        private Label label2;
        private Button btnTaoPhieuDangKy;
        private DataGridView dgvLichThiDV;
        private Label label1;
        private Button btnThoat;
    }
}