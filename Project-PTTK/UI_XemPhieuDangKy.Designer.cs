namespace Project_PTTK
{
    partial class UI_XemPhieuDangKy
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            m = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 142);
            label5.Name = "label5";
            label5.Size = new Size(251, 28);
            label5.TabIndex = 19;
            label5.Text = "Danh sách phiếu đăng ký";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(953, 439);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 18;
            label4.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(838, 439);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 17;
            label3.Text = "Tổng số bản ghi:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { m, Column2, Column1, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(71, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(898, 254);
            dataGridView1.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(679, 59);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 13;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(554, 59);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 12;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 27);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 40);
            label1.Name = "label1";
            label1.Size = new Size(290, 20);
            label1.TabIndex = 10;
            label1.Text = "Tìm kiếm khách hàng theo Mã khách hàng:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(71, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 114);
            panel1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(10, 10);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 0;
            label6.Text = "Bộ lọc và Tìm kiếm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Tất cả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 40);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 21;
            label7.Text = "Trạng thái:";
            // 
            // m
            // 
            m.HeaderText = "Mã phiếu đăng ký";
            m.MaxInputLength = 32900;
            m.MinimumWidth = 6;
            m.Name = "m";
            m.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Loại khách hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày tạo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Trạng thái thanh toán";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phương thức thanh toán";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // UI_XemPhieuDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 486);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "UI_XemPhieuDangKy";
            Text = "UI_XemPhieuDangKy";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn m;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}