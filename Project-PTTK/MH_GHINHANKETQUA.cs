using Project_PTTK.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_PTTK.Business;
using Project_PTTK.Model;


namespace Project_PTTK
{
    public partial class MH_GHINHANKETQUA : Form
    {
        public MH_GHINHANKETQUA()
        {
            InitializeComponent();
        }
        private ThiSinhBus tsbus = new ThiSinhBus(new ThiSinhDAO());
        private ChungChiBus chungChiBus = new ChungChiBus(new ChungChiDAO());

        private void txtMaTS_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaTS.Text, out int maTS))
            {
                var thiSinh = tsbus.LoadThongTinTS(maTS);
                if (thiSinh != null)
                {
                    lblTenTS.Text = thiSinh.HoTen;
                    lblNgaySinh.Text = thiSinh.NgaySinh.ToString("dd/MM/yyyy");
                }
                else
                {
                    lblTenTS.Text = "Không tìm thấy";
                    lblNgaySinh.Text = "";
                }
            }
            else
            {
                lblTenTS.Text = "";
                lblNgaySinh.Text = "";
            }
        }

        private void btnTaoChungChi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaTS.Text, out int maTS))
                {
                    MessageBox.Show("Mã thí sinh không hợp lệ!");
                    return;
                }

                var ts = tsbus.LoadThongTinTS(maTS);
                if (ts == null)
                {
                    MessageBox.Show("Không tìm thấy thí sinh.");
                    return;
                }

                // Tính điểm trung bình
                bool isValid1 = double.TryParse(txtSubject1.Text, out double s1);
                bool isValid2 = double.TryParse(txtSubject2.Text, out double s2);
                bool isValid3 = double.TryParse(txtSubject3.Text, out double s3);
                bool isValid4 = double.TryParse(txtSubject4.Text, out double s4);

                if (!isValid1 || !isValid2 || !isValid3 || !isValid4)
                {
                    MessageBox.Show("Điểm các môn không hợp lệ!");
                    return;
                }

                // ✅ Kiểm tra điểm nằm trong khoảng 0-10
                if (s1 < 0 || s1 > 10 || s2 < 0 || s2 > 10 || s3 < 0 || s3 > 10 || s4 < 0 || s4 > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.");
                    return;
                }

                double ketQuaDouble = (s1 + s2 + s3 + s4) / 4.0;
                int ketQua = (int)Math.Round(ketQuaDouble);

                int NvLap = 1; // tạm thời

                ChungChiCreateModel model = new ChungChiCreateModel(maTS, ketQua);
                model.NvLap = NvLap;

                chungChiBus.ThemChungChi(model);

                MessageBox.Show("Tạo chứng chỉ thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo chứng chỉ: " + ex.Message);
            }
        }

    }
}
