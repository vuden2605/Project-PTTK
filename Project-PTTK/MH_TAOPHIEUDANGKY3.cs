using Project_PTTK.Business;
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
    public partial class MH_TAOPHIEUDANGKY3 : Form
    {
        public MH_TAOPHIEUDANGKY3()
        {
            InitializeComponent();
            LoadDichVuHienCo();
        }

        private void dgvLichThiDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDichVuHienCo ()
        {
            try
            {
                DichVuBUS dvBus = new DichVuBUS(new DataAccess.DichVuDAO());
                var dichVuList = dvBus.getDichVuHienCo();
                if (dichVuList != null && dichVuList.Count > 0)
                {
                    dgvLichThiDV.DataSource = dichVuList;
                    dgvLichThiDV.Columns["maLichThi"]!.HeaderText = "Mã lịch thi";
                    dgvLichThiDV.Columns["tenDichVu"]!.HeaderText = "Tên dịch vụ";
                    dgvLichThiDV.Columns["ngayThi"]!.HeaderText = "Ngày thi";
                    dgvLichThiDV.Columns["gioThi"]!.HeaderText = "Giờ thi";
                    dgvLichThiDV.Columns["phongThi"]!.HeaderText = "Phòng thi";
                    dgvLichThiDV.Columns["soLuongTsDaDangKy"]!.HeaderText = "Số TS đã đăng ký";
                    dgvLichThiDV.Columns["soLuongTsToiDa"]!.HeaderText = "Số TS tối đa";

                }
                else
                {
                    MessageBox.Show("Không có dịch vụ nào hiện có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi tải danh sách dịch vụ hiện có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
