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
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLichThiDV).BeginInit();
            SuspendLayout();
            // 
            // lblMaPhieuDangKy
            // 
            lblMaPhieuDangKy.AutoSize = true;
            lblMaPhieuDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaPhieuDangKy.Location = new Point(547, 16);
            lblMaPhieuDangKy.Margin = new Padding(5, 0, 5, 0);
            lblMaPhieuDangKy.Name = "lblMaPhieuDangKy";
            lblMaPhieuDangKy.Size = new Size(74, 45);
            lblMaPhieuDangKy.TabIndex = 15;
            lblMaPhieuDangKy.Text = "001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(60, 16);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(482, 45);
            label2.TabIndex = 14;
            label2.Text = "Thêm dịch vụ cho phiếu đăng ký";
            // 
            // btnTaoPhieuDangKy
            // 
            btnTaoPhieuDangKy.BackColor = Color.MediumSeaGreen;
            btnTaoPhieuDangKy.FlatStyle = FlatStyle.Flat;
            btnTaoPhieuDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaoPhieuDangKy.ForeColor = Color.White;
            btnTaoPhieuDangKy.Location = new Point(309, 668);
            btnTaoPhieuDangKy.Margin = new Padding(5);
            btnTaoPhieuDangKy.Name = "btnTaoPhieuDangKy";
            btnTaoPhieuDangKy.Size = new Size(325, 72);
            btnTaoPhieuDangKy.TabIndex = 13;
            btnTaoPhieuDangKy.Text = "Thêm dịch vụ";
            btnTaoPhieuDangKy.UseVisualStyleBackColor = false;
            // 
            // dgvLichThiDV
            // 
            dgvLichThiDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichThiDV.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvLichThiDV.Location = new Point(60, 144);
            dgvLichThiDV.Margin = new Padding(5);
            dgvLichThiDV.Name = "dgvLichThiDV";
            dgvLichThiDV.RowHeadersWidth = 51;
            dgvLichThiDV.Size = new Size(1180, 514);
            dgvLichThiDV.TabIndex = 12;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên dịch vụ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày thi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 160;
            // 
            // Column5
            // 
            Column5.HeaderText = "Giờ thi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Số lượng thí sinh tối đa";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 250;
            // 
            // Column7
            // 
            Column7.HeaderText = "Số lượng thí sinh đã đăng ký";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(60, 92);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(708, 32);
            label1.TabIndex = 11;
            label1.Text = "DANH SÁCH DỊCH VỤ VÀ LỊCH THI HIỆN CÓ TẠI TRUNG TÂM";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Crimson;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(709, 668);
            btnThoat.Margin = new Padding(5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(156, 72);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // MH_TAOPHIEUDANGKY3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 757);
            Controls.Add(btnThoat);
            Controls.Add(lblMaPhieuDangKy);
            Controls.Add(label2);
            Controls.Add(btnTaoPhieuDangKy);
            Controls.Add(dgvLichThiDV);
            Controls.Add(label1);
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
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label1;
        private Button btnThoat;
    }
}