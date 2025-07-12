using Project_PTTK.Business;
using Project_PTTK.DataAccess.Phieu;
using Project_PTTK.Model;
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
            
        }
        public MH_TAOPHIEUDANGKY3 (int maphieu)
        {
            InitializeComponent();
            lblMaPhieuDangKy.Text = maphieu.ToString();
            LoadDichVuHienCo();
        }
        private void dgvLichThiDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDichVuHienCo()
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

        private void btnTaoPhieuDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                int maphieu = Convert.ToInt32(lblMaPhieuDangKy.Text);
                int maLichThi = Convert.ToInt32(dgvLichThiDV.CurrentRow.Cells["maLichThi"].Value);
                PhieuDangKyBUS pdkBus = new PhieuDangKyBUS(new PhieuDangKyDAO());
                ChiTietPhieuDangKy chiTietPhieuDangKy = new ChiTietPhieuDangKy(maphieu, maLichThi, 1);
                pdkBus.ThemChiTietPhieu(chiTietPhieuDangKy);
                //MessageBox.Show("Thêm dịch vụ cho phiếu đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dịch vụ cho phiếu đăng ký: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
