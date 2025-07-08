using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PTTK
{
    public partial class LogoutForm : Form
    {
        private string username;
        private string role;

        public LogoutForm(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            lblWelcome.Text = $"👋 Xin chào {username} ({role})";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Trở về Form đăng nhập
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }

}
