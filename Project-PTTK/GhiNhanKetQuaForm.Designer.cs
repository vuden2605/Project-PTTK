namespace Project_PTTK
{
    partial class GhiNhanKetQuaForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btnDangKy = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã thí sinh:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(108, 85);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 88);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Location = new Point(389, 85);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 88);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh:";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 136);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thí sinh";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(61, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 45);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Subject1:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(385, 42);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(61, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 45);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Subject2:";
            label5.Click += label5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(385, 101);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(61, 27);
            textBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 104);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Subject4:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(104, 101);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(61, 27);
            textBox7.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 104);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 10;
            label7.Text = "Subject3:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(34, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(739, 152);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.MediumSeaGreen;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(300, 383);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(200, 45);
            btnDangKy.TabIndex = 15;
            btnDangKy.Text = "📝Tạo chứng chỉ";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // GhiNhanKetQuaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(btnDangKy);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GhiNhanKetQuaForm";
            Text = "GhiNhanKetQuaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private GroupBox groupBox2;
        private Button btnDangKy;
    }
}