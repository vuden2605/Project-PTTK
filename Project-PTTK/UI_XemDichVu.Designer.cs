namespace Project_PTTK
{
    partial class UI_XemDichVu
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(353, 43);
            label1.Name = "label1";
            label1.Size = new Size(446, 65);
            label1.TabIndex = 0;
            label1.Text = "BẢNG GIÁ DỊCH VỤ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(64, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1030, 478);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên dịch vụ";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 450;
            // 
            // Column2
            // 
            Column2.HeaderText = "Giá";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 500;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(64, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 99);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 35);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm dịch vụ:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 39);
            textBox1.TabIndex = 1;
            // 
            // UI_XemDichVu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 733);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UI_XemDichVu";
            Text = "CÁC DỊCH VỤ HIỆN CÓ CỦA TRUNG TÂM";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
    }
}