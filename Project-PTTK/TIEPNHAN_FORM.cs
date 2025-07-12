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
    public partial class TIEPNHAN_FORM : Form
    {
        public TIEPNHAN_FORM()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var form = new MH_TAOPHIEUDANGKY1();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MH_TAOPHIEUGIAHAN();
            form.ShowDialog();
        }
    }
}
