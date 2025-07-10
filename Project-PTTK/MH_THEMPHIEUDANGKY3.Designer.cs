namespace Project_PTTK
{
    partial class MH_THEMPHIEUDANGKY3
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnDangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(439, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH DỊCH VỤ VÀ LỊCH THI HIỆN CÓ TẠI TRUNG TÂM";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(24, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(726, 321);
            dataGridView1.TabIndex = 1;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên dịch vụ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày thi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
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
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Số lượng thí sinh đã đăng ký";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.MediumSeaGreen;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(304, 403);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(200, 45);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Thêm dịch vụ";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // MH_THEMPHIEUDANGKY3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(btnDangKy);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "MH_THEMPHIEUDANGKY3";
            Text = "MH_THEMPHIEUDANGKY3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnDangKy;
    }
}