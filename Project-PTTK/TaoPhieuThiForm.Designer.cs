using System.Windows.Forms;
using System.Drawing;

namespace Project_PTTK
{
    partial class TaoPhieuDangKyForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cboLoaiKH, cboDichVu, cboLichThi, cboGioiTinh;
        private TextBox txtTenKH, txtTenDV, txtDiaChiDV, txtHoTenTS, txtCMND;
        private DateTimePicker dtpNgaySinhKH, dtpNgaySinhTS;
        private Button btnDangKy;

        private Label lblLoaiKH, lblTenKH, lblNgaySinhKH, lblTenDV, lblDiaChiDV;
        private Label lblHoTenTS, lblNgaySinhTS, lblCMND, lblGioiTinh, lblDichVu, lblLichThi;

        private GroupBox groupKhachHang, groupThiSinh, groupDangKy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cboLoaiKH = new ComboBox();
            cboDichVu = new ComboBox();
            cboLichThi = new ComboBox();
            cboGioiTinh = new ComboBox();
            txtTenKH = new TextBox();
            txtTenDV = new TextBox();
            txtDiaChiDV = new TextBox();
            txtHoTenTS = new TextBox();
            txtCMND = new TextBox();
            dtpNgaySinhKH = new DateTimePicker();
            dtpNgaySinhTS = new DateTimePicker();
            btnDangKy = new Button();
            lblLoaiKH = new Label();
            lblTenKH = new Label();
            lblNgaySinhKH = new Label();
            lblTenDV = new Label();
            lblDiaChiDV = new Label();
            lblHoTenTS = new Label();
            lblNgaySinhTS = new Label();
            lblCMND = new Label();
            lblGioiTinh = new Label();
            lblDichVu = new Label();
            lblLichThi = new Label();
            groupKhachHang = new GroupBox();
            groupThiSinh = new GroupBox();
            groupDangKy = new GroupBox();
            groupKhachHang.SuspendLayout();
            groupThiSinh.SuspendLayout();
            groupDangKy.SuspendLayout();
            SuspendLayout();
            // 
            // cboLoaiKH
            // 
            cboLoaiKH.Location = new Point(160, 28);
            cboLoaiKH.Name = "cboLoaiKH";
            cboLoaiKH.Size = new Size(180, 31);
            cboLoaiKH.TabIndex = 1;
            // 
            // cboDichVu
            // 
            cboDichVu.Location = new Point(160, 28);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(180, 31);
            cboDichVu.TabIndex = 1;
            // 
            // cboLichThi
            // 
            cboLichThi.Location = new Point(490, 28);
            cboLichThi.Name = "cboLichThi";
            cboLichThi.Size = new Size(180, 31);
            cboLichThi.TabIndex = 3;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Location = new Point(490, 63);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(180, 31);
            cboGioiTinh.TabIndex = 7;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(160, 63);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(180, 30);
            txtTenKH.TabIndex = 3;
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(160, 98);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(180, 30);
            txtTenDV.TabIndex = 7;
            // 
            // txtDiaChiDV
            // 
            txtDiaChiDV.Location = new Point(490, 98);
            txtDiaChiDV.Name = "txtDiaChiDV";
            txtDiaChiDV.Size = new Size(180, 30);
            txtDiaChiDV.TabIndex = 9;
            // 
            // txtHoTenTS
            // 
            txtHoTenTS.Location = new Point(160, 28);
            txtHoTenTS.Name = "txtHoTenTS";
            txtHoTenTS.Size = new Size(180, 30);
            txtHoTenTS.TabIndex = 1;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(160, 63);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(180, 30);
            txtCMND.TabIndex = 5;
            // 
            // dtpNgaySinhKH
            // 
            dtpNgaySinhKH.Format = DateTimePickerFormat.Short;
            dtpNgaySinhKH.Location = new Point(490, 63);
            dtpNgaySinhKH.Name = "dtpNgaySinhKH";
            dtpNgaySinhKH.Size = new Size(180, 30);
            dtpNgaySinhKH.TabIndex = 5;
            // 
            // dtpNgaySinhTS
            // 
            dtpNgaySinhTS.Format = DateTimePickerFormat.Short;
            dtpNgaySinhTS.Location = new Point(490, 28);
            dtpNgaySinhTS.Name = "dtpNgaySinhTS";
            dtpNgaySinhTS.Size = new Size(180, 30);
            dtpNgaySinhTS.TabIndex = 3;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.MediumSeaGreen;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(310, 450);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(200, 45);
            btnDangKy.TabIndex = 3;
            btnDangKy.Text = "📝 Tạo Phiếu Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // lblLoaiKH
            // 
            lblLoaiKH.Location = new Point(20, 30);
            lblLoaiKH.Name = "lblLoaiKH";
            lblLoaiKH.Size = new Size(100, 23);
            lblLoaiKH.TabIndex = 0;
            lblLoaiKH.Text = "Loại khách hàng:";
            // 
            // lblTenKH
            // 
            lblTenKH.Location = new Point(20, 65);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(100, 23);
            lblTenKH.TabIndex = 2;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblNgaySinhKH
            // 
            lblNgaySinhKH.Location = new Point(370, 65);
            lblNgaySinhKH.Name = "lblNgaySinhKH";
            lblNgaySinhKH.Size = new Size(100, 23);
            lblNgaySinhKH.TabIndex = 4;
            lblNgaySinhKH.Text = "Ngày sinh (KH):";
            // 
            // lblTenDV
            // 
            lblTenDV.Location = new Point(20, 100);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Size = new Size(100, 23);
            lblTenDV.TabIndex = 6;
            lblTenDV.Text = "Tên đơn vị:";
            // 
            // lblDiaChiDV
            // 
            lblDiaChiDV.Location = new Point(370, 100);
            lblDiaChiDV.Name = "lblDiaChiDV";
            lblDiaChiDV.Size = new Size(100, 23);
            lblDiaChiDV.TabIndex = 8;
            lblDiaChiDV.Text = "Địa chỉ đơn vị:";
            // 
            // lblHoTenTS
            // 
            lblHoTenTS.Location = new Point(20, 30);
            lblHoTenTS.Name = "lblHoTenTS";
            lblHoTenTS.Size = new Size(100, 23);
            lblHoTenTS.TabIndex = 0;
            lblHoTenTS.Text = "Họ tên thí sinh:";
            // 
            // lblNgaySinhTS
            // 
            lblNgaySinhTS.Location = new Point(370, 30);
            lblNgaySinhTS.Name = "lblNgaySinhTS";
            lblNgaySinhTS.Size = new Size(100, 23);
            lblNgaySinhTS.TabIndex = 2;
            lblNgaySinhTS.Text = "Ngày sinh (TS):";
            // 
            // lblCMND
            // 
            lblCMND.Location = new Point(20, 65);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(100, 23);
            lblCMND.TabIndex = 4;
            lblCMND.Text = "CMND/CCCD:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(370, 65);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblDichVu
            // 
            lblDichVu.Location = new Point(20, 30);
            lblDichVu.Name = "lblDichVu";
            lblDichVu.Size = new Size(100, 23);
            lblDichVu.TabIndex = 0;
            lblDichVu.Text = "Dịch vụ:";
            // 
            // lblLichThi
            // 
            lblLichThi.Location = new Point(370, 30);
            lblLichThi.Name = "lblLichThi";
            lblLichThi.Size = new Size(100, 23);
            lblLichThi.TabIndex = 2;
            lblLichThi.Text = "Lịch thi:";
            // 
            // groupKhachHang
            // 
            groupKhachHang.Controls.Add(lblLoaiKH);
            groupKhachHang.Controls.Add(cboLoaiKH);
            groupKhachHang.Controls.Add(lblTenKH);
            groupKhachHang.Controls.Add(txtTenKH);
            groupKhachHang.Controls.Add(lblNgaySinhKH);
            groupKhachHang.Controls.Add(dtpNgaySinhKH);
            groupKhachHang.Controls.Add(lblTenDV);
            groupKhachHang.Controls.Add(txtTenDV);
            groupKhachHang.Controls.Add(lblDiaChiDV);
            groupKhachHang.Controls.Add(txtDiaChiDV);
            groupKhachHang.Location = new Point(30, 20);
            groupKhachHang.Name = "groupKhachHang";
            groupKhachHang.Size = new Size(720, 160);
            groupKhachHang.TabIndex = 0;
            groupKhachHang.TabStop = false;
            groupKhachHang.Text = "Thông tin khách hàng";
            // 
            // groupThiSinh
            // 
            groupThiSinh.Controls.Add(lblHoTenTS);
            groupThiSinh.Controls.Add(txtHoTenTS);
            groupThiSinh.Controls.Add(lblNgaySinhTS);
            groupThiSinh.Controls.Add(dtpNgaySinhTS);
            groupThiSinh.Controls.Add(lblCMND);
            groupThiSinh.Controls.Add(txtCMND);
            groupThiSinh.Controls.Add(lblGioiTinh);
            groupThiSinh.Controls.Add(cboGioiTinh);
            groupThiSinh.Location = new Point(30, 190);
            groupThiSinh.Name = "groupThiSinh";
            groupThiSinh.Size = new Size(720, 130);
            groupThiSinh.TabIndex = 1;
            groupThiSinh.TabStop = false;
            groupThiSinh.Text = "Thông tin thí sinh";
            // 
            // groupDangKy
            // 
            groupDangKy.Controls.Add(lblDichVu);
            groupDangKy.Controls.Add(cboDichVu);
            groupDangKy.Controls.Add(lblLichThi);
            groupDangKy.Controls.Add(cboLichThi);
            groupDangKy.Location = new Point(30, 330);
            groupDangKy.Name = "groupDangKy";
            groupDangKy.Size = new Size(720, 100);
            groupDangKy.TabIndex = 2;
            groupDangKy.TabStop = false;
            groupDangKy.Text = "Thông tin đăng ký";
            // 
            // TaoPhieuDangKyForm
            // 
            ClientSize = new Size(800, 520);
            Controls.Add(groupKhachHang);
            Controls.Add(groupThiSinh);
            Controls.Add(groupDangKy);
            Controls.Add(btnDangKy);
            Font = new Font("Segoe UI", 10F);
            Name = "TaoPhieuDangKyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo Phiếu Đăng Ký";
            groupKhachHang.ResumeLayout(false);
            groupKhachHang.PerformLayout();
            groupThiSinh.ResumeLayout(false);
            groupThiSinh.PerformLayout();
            groupDangKy.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}