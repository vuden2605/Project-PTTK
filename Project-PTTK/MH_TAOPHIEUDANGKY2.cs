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
    public partial class MH_TAOPHIEUDANGKY2 : Form
    {
        public MH_TAOPHIEUDANGKY2()
        {
            InitializeComponent();
        }
        public MH_TAOPHIEUDANGKY2(int maphieu, string loai, string ten, DateOnly ngaysinh, string email, string tendv, string diachi)
        {
            InitializeComponent();
            lblMaPhieuDangKy.Text = maphieu.ToString(); ;
            cmbLoaiKhachHang.Text = loai;
            txtTenKhachHang.Text = ten;
            txtEmail.Text = email;
            txtTenKhachHang.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cmbLoaiKhachHang.Enabled = false;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
