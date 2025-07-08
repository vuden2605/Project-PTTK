using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Project_PTTK
{
    public partial class LoginForm : Form
    {
        private readonly Dictionary<string, (string Password, string Role)> users = new()
        {
            { "tiepnhan", ("123456", "Tiếp nhận") },
            { "ketoan", ("abc123", "Kế toán") },
            { "nhaplieu", ("pwd321", "Nhập liệu") },
            { "admin", ("admin", "Admin") }
        };

        public LoginForm()
        {
            InitializeComponent();
            CustomizeUI();
        }

        private void CustomizeUI()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (users.TryGetValue(username, out var user) && user.Password == password)
            {
                MessageBox.Show($"🎉 Đăng nhập thành công!\nXin chào {username} ({user.Role})", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // this.Hide(); // hoặc mở MainForm tùy vai trò
            }
            else
            {
                lblMessage.Text = "❌ Thông tin đăng nhập không đúng.";
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.ForeColor == Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
                if (txt.Name == "txtPassword") txt.PasswordChar = '●';
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt.Name == "txtUsername")
                {
                    txt.Text = "Tên đăng nhập";
                    txt.ForeColor = Color.Gray;
                }
                else if (txt.Name == "txtPassword")
                {
                    txt.PasswordChar = '\0';
                    txt.Text = "Mật khẩu";
                    txt.ForeColor = Color.Gray;
                }
            }
        }
    }
}
