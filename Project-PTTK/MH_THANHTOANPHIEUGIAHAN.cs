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
using Project_PTTK.DataAccess;
using Project_PTTK.Model;


namespace Project_PTTK
{
    public partial class MH_THANHTOANPHIEUGIAHAN : Form
    {
        public MH_THANHTOANPHIEUGIAHAN()
        {
            InitializeComponent();
        }
        private PhieuGiaHanBus phieuGiaHanBus = new PhieuGiaHanBus(new PhieuGiaHanDAO());
        private void LoadDanhSachPhieuGiaHan()
        {
            try
            {
                var danhSach = phieuGiaHanBus.LoadDSPhieuGH();

                // Hiển thị danh sách vào DataGridView
                dgvPhieuGiaHan.DataSource = danhSach;

                // Tùy chọn: chỉnh sửa tên cột
                dgvPhieuGiaHan.Columns["MaPhieuGiaHan"].HeaderText = "Mã phiếu gia hạn";
                dgvPhieuGiaHan.Columns["MaPhieuDangKy"].HeaderText = "Mã phiếu đăng ký";
                dgvPhieuGiaHan.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dgvPhieuGiaHan.Columns["MaLichThi"].HeaderText = "Mã lịch thi";

                dgvPhieuGiaHan.Columns["LyDo"].HeaderText = "Lý do";
                dgvPhieuGiaHan.Columns["TrangThaiThanhToan"].HeaderText = "Trạng thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load danh sách phiếu gia hạn: " + ex.Message);
            }
        }

        private void MH_THANHTOANPHIEUGIAHAN_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuGiaHan();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvPhieuGiaHan.CurrentRow != null)
            {
                DataGridViewRow row = dgvPhieuGiaHan.CurrentRow;

                txtMaPhieuGiaHan.Text = row.Cells["MaPhieuGiaHan"].Value?.ToString() ?? "";
                txtMaPhieuDangKy.Text = row.Cells["MaPhieuDangKy"].Value?.ToString() ?? "";
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value?.ToString() ?? "";
                txtLyDo.Text = row.Cells["LyDo"].Value?.ToString() ?? "";
                txtMaLichThi.Text = row.Cells["MaLichThi"].Value?.ToString() ?? "";

                // Tính tiền
                string lyDo = txtLyDo.Text;
                int soTien = phieuGiaHanBus.TinhSoTien(lyDo);
                nudSoTien.Value = soTien;

                // Gán tổng tiền = số tiền (vì chiết khấu = 0)
                nudTongTien.Value = soTien;


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng trước.");
            }
        }
        private HoaDonBus hdBus = new HoaDonBus(new HoaDonDAO());

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgvPhieuGiaHan.CurrentRow != null && dgvPhieuGiaHan.CurrentRow.Cells["MaPhieuGiaHan"].Value != null)
            {
                string maPhieuGiaHan = dgvPhieuGiaHan.CurrentRow.Cells["MaPhieuGiaHan"].Value.ToString();
                if (!string.IsNullOrEmpty(maPhieuGiaHan))
                {
                    // Cập nhật trạng thái phiếu gia hạn
                    var phieu = new PhieuGiaHanModel
                    {
                        MaPhieuGiaHan = int.Parse(maPhieuGiaHan),
                        MaPhieuDangKy = int.Parse(txtMaPhieuDangKy.Text),
                        MaKhachHang = int.Parse(txtMaKhachHang.Text),
                        MaLichThi = int.Parse(txtMaLichThi.Text),
                        LyDo = txtLyDo.Text,
                        TrangThaiThanhToan = "Đã thanh toán"
                    };
                    phieuGiaHanBus.CapNhatTrangThaiPhieuGH(phieu);

                    // Tính tổng tiền
                    decimal tongTien = nudSoTien.Value * (100 - nudChietKhau.Value) / 100;

                    // Tạo hóa đơn mới
                    HoaDon hoaDon = new HoaDon
                    {
                        TongTien = tongTien,
                        ChietKhau = nudChietKhau.Value,
                        PhuongThucThanhToan = cbmPhuongThuc.SelectedItem?.ToString() ?? "Chưa xác định",
                        Loai = "Phiếu gia hạn",
                        NhanVienLap = Session.MaNV, // cần có biến session chứa mã nhân viên đang đăng nhập
                        MaPhieuGiaHan = int.Parse(maPhieuGiaHan)
                    };

                    hdBus.ThemHoaDon(hoaDon); // cần khởi tạo `hdBus` kiểu `HoaDonBus`

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Phiếu gia hạn không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu gia hạn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
