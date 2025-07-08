namespace Project_PTTK
{
    partial class LoginForm
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
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblMessage;
        private Button btnLogin;
        private PictureBox logo;

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblMessage = new Label();
            btnLogin = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(134, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(333, 27);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Tên đăng nhập";
            txtUsername.Enter += txt_Enter;
            txtUsername.Leave += txt_Leave;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(134, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(333, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Mật khẩu";
            txtPassword.Enter += txt_Enter;
            txtPassword.Leave += txt_Leave;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(269, 242);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(134, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(333, 55);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "🔐 Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // logo
            // 
            logo.Location = new Point(120, 20);
            logo.Name = "logo";
            logo.Size = new Size(100, 100);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // LoginForm
            // 
            ClientSize = new Size(593, 350);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblMessage);
            Name = "LoginForm";
            Text = "Hệ thống đăng nhập";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}