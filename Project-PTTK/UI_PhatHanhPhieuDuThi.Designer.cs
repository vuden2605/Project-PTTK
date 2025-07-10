namespace Project_PTTK
{
    partial class UI_PhatHanhPhieuDuThi
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
            button4 = new Button();
            label5 = new Label();
            label2 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            m = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Location = new Point(610, 411);
            button4.Name = "button4";
            button4.Size = new Size(171, 45);
            button4.TabIndex = 31;
            button4.Text = "Phát hành phiếu dự thi";
            button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 77);
            label5.Name = "label5";
            label5.Size = new Size(440, 28);
            label5.TabIndex = 30;
            label5.Text = "Danh sách thí sinh cần cấp hành phiếu dự thi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 423);
            label2.Name = "label2";
            label2.Size = new Size(262, 20);
            label2.TabIndex = 27;
            label2.Text = "Chọn một phiếu đăng ký để phát hành";
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Location = new Point(815, 411);
            button3.Name = "button3";
            button3.Size = new Size(158, 45);
            button3.TabIndex = 26;
            button3.Text = "Phát hành hàng loạt";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { m, Column3, Column4, Column5, Column2, Column6, Column1, Column7 });
            dataGridView1.Location = new Point(22, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(973, 254);
            dataGridView1.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(709, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 23;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 27);
            textBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 38);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 21;
            label1.Text = "Tìm kiếm theo Mã thí sinh:";
            // 
            // m
            // 
            m.HeaderText = "Mã thí sinh";
            m.MaxInputLength = 32900;
            m.MinimumWidth = 6;
            m.Name = "m";
            m.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Họ tên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày sinh";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Tên dịch vụ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Phòng thi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày thi";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Giờ thi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái phát hành";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // UI_PhatHanhPhieuDuThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 486);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UI_PhatHanhPhieuDuThi";
            Text = "UI_PhatHanhPhieuDuThi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label5;
        private Label label2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn m;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
    }
}