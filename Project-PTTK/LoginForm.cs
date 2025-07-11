using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
            string password = txtPassword.Text.Trim();

            try
            {
                string query = "SELECT MaNV, Vaitro FROM NhanVien WHERE Email = @email AND MatKhau = @matkhau";
                SqlParameter[] parameters = {
                    new SqlParameter("@email", username),
                    new SqlParameter("@matkhau", password)
            };

                DataTable dt = DBHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    int maNV = Convert.ToInt32(dt.Rows[0]["MaNV"]);
                    string role = dt.Rows[0]["Vaitro"].ToString();

                    // Lưu lại MaNV nếu cần (ví dụ như Session)
                    Session.MaNV = maNV;

                    Form mainForm;

                    switch (role)
                    {
                        case "Tiếp nhận":
                            mainForm = new MH_TAOPHIEUDANGKY1();
                            break;
                        default:
                            MessageBox.Show("Vai trò không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
