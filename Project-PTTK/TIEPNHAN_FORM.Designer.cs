namespace Project_PTTK
{
    partial class TIEPNHAN_FORM
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
            button1 = new Button();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(547, 238);
            button1.Name = "button1";
            button1.Size = new Size(270, 98);
            button1.TabIndex = 8;
            button1.Text = "PHIẾU GIA HẠN";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(149, 238);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(270, 98);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "PHIẾU ĐĂNG KÝ";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(221, 92);
            label1.Name = "label1";
            label1.Size = new Size(518, 50);
            label1.TabIndex = 6;
            label1.Text = "CHỌN LOẠI PHIẾU CẦN TẠO";
            // 
            // TIEPNHAN_FORM
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 430);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "TIEPNHAN_FORM";
            Text = "MÀN HÌNH NHÂN VIÊN TIẾP NHẬN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnLogin;
        private Label label1;
    }
}