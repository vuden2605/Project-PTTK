namespace Project_PTTK
{
    partial class KETOAN_FORM
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
            btnLogin = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(155, 84);
            label1.Name = "label1";
            label1.Size = new Size(619, 50);
            label1.TabIndex = 0;
            label1.Text = "CHỌN CHỨC NĂNG THANH TOÁN";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(127, 228);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(270, 98);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "PHIẾU ĐĂNG KÝ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(525, 228);
            button1.Name = "button1";
            button1.Size = new Size(270, 98);
            button1.TabIndex = 5;
            button1.Text = "PHIẾU GIA HẠN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // KETOAN_FORM
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 430);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "KETOAN_FORM";
            Text = "MÀN HÌNH KẾ TOÁN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private Button button1;
    }
}