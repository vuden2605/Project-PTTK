using Project_PTTK.Business;
using Project_PTTK.Model;

namespace Project_PTTK
{
    public partial class LoginForm : Form
    {
        private readonly NhanVienBUS nhanVienBus = new NhanVienBUS();

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
            string email = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int maNV = nhanVienBus.Authenticate(email, password);
                if (maNV != 0)
                {
                    NhanVien? nhanVien = nhanVienBus.GetNhanVienInfo(maNV);
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên với email này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Session.MaNV = maNV; // Lưu mã nhân viên vào Session
                    Form mainForm;
                    switch (nhanVien.VaiTro)
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
                MessageBox.Show("Lỗi khi xác thực: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
