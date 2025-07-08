namespace Project_PTTK
{
    partial class LogoutForm
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
        private Label lblWelcome;
        private Button btnLogout;

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 28);
            lblWelcome.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(674, 13);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 35);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "🚪 Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // LogoutForm
            // 
            ClientSize = new Size(806, 322);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Name = "LogoutForm";
            Text = "Màn hình chính";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}