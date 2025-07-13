using Project_PTTK.Business;
using Project_PTTK.DataAccess;
using Project_PTTK.Model;
using System.Security.AccessControl;

namespace Project_PTTK
{
    public partial class MH_TAOPHIEUGIAHAN : Form
    {
        private PhieuGiaHanBus pghBus = new PhieuGiaHanBus(new PhieuGiaHanDAO());
        private LichThiBus ltBus = new LichThiBus(new LichThiDAO());
        private DichVuBUS dichVuBUS = new DichVuBUS(new DichVuDAO());
        private ThiSinhBus tsBus = new ThiSinhBus(new ThiSinhDAO());
        private int _maPhieuDangKy = -1;

        public MH_TAOPHIEUGIAHAN()
        {
            InitializeComponent();
            // Tắt tự tạo cột
            dgvDichVuDaDK.AutoGenerateColumns = false;
            dgvDichVuDaDK.Columns.Clear();

            // Cột MaDichVu
            DataGridViewTextBoxColumn colMa = new DataGridViewTextBoxColumn();
            colMa.HeaderText = "Mã dịch vụ";
            colMa.DataPropertyName = "MaDichVu";
            colMa.Name = "MaDichVu";
            dgvDichVuDaDK.Columns.Add(colMa);

            // Cột TenDichVu
            DataGridViewTextBoxColumn colTen = new DataGridViewTextBoxColumn();
            colTen.HeaderText = "Tên dịch vụ";
            colTen.DataPropertyName = "TenDichVu";
            colTen.Name = "TenDichVu";
            dgvDichVuDaDK.Columns.Add(colTen);

            // Tùy chọn: chỉnh tự động co giãn
            dgvDichVuDaDK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Gán dữ liệu rỗng ban đầu để hiện tên cột
            dgvDichVuDaDK.DataSource = new List<object>(); // hoặc null nếu chưa có
        }

        private void MH_TAOPHIEUGIAHAN_Load(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDichVuDaDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChonDichVu_Click(object sender, EventArgs e)
        {
            if (dgvDichVuDaDK.CurrentRow != null)
            {
                
                var maDichVu = dgvDichVuDaDK.CurrentRow.Cells["MaDichVu"].Value?.ToString();

                var lichthi = ltBus.LayTheoMaDichVu(int.Parse(maDichVu));
                dgvLichThiMoi.DataSource = lichthi;



            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ.");
            }
        }


        private void dgvLichThiMoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTaoPhieuGiaHan_Click(object sender, EventArgs e)
        {
            if (dgvLichThiMoi.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvLichThiMoi.CurrentRow;

                // Lấy MaPhieuDangKy và MaLichThi từ dòng đang chọn trong DataGridView
                int maPhieu = _maPhieuDangKy;
                int maLichThi = Convert.ToInt32(selectedRow.Cells["MaLichThi"].Value);

                PhieuGiaHan phieuGiaHan = new PhieuGiaHan
                {
                    MaPhieuDangKy = maPhieu,
                    MaLichThi = maLichThi,
                    LyDo = cmbLyDo.Text,
                    TrangThaiThanhToan = "Chưa thanh toán",
                    MaNV = Session.MaNV
                };
                
                pghBus.ThemPhieuGiaHan(phieuGiaHan);
                MessageBox.Show("Tạo phiếu gia hạn thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch thi để tạo phiếu gia hạn.");
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                    return;

                if (!int.TryParse(txtMaPhieu.Text, out int mats))
                {
                    MessageBox.Show("Mã phiếu không hợp lệ!");
                    return;
                }

                var thiSinh = tsBus.LoadThongTinTS(mats);
                
                
                if (thiSinh == null)
                {
                    MessageBox.Show("Không tìm thấy thí sinh.");
                    return;
                }

                _maPhieuDangKy = thiSinh.MaPhieuDangKy;

                txtTenKH.Text = thiSinh?.HoTen ?? string.Empty;

                var dichvu = dichVuBUS.GetDichVuViews(_maPhieuDangKy)
                      .Select(dv => new { dv.maDichVu, dv.tenDichVu })
                      .ToList();
                dgvDichVuDaDK.DataSource = dichvu;
            }
        }
    }
}
