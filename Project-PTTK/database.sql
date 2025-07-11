CREATE DATABASE QuanLyChungChi;
GO
USE QuanLyChungChi;
GO
-- KHÁCH HÀNG
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    LoaiKhachHang NVARCHAR(50),
    Email NVARCHAR(100)
);
GO
CREATE TABLE KhachHangTuDo (
    MaKH INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
GO
CREATE TABLE KhachHangDonVi (
    MaKH INT PRIMARY KEY,
    TenDV NVARCHAR(100),
    DiaChi NVARCHAR(255),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
GO
-- NHÂN VIÊN
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    MatKhau NVARCHAR(100),
    HoTen NVARCHAR(100),
    SDT NVARCHAR(15),
    Email NVARCHAR(100),
    VaiTro NVARCHAR(50),
    Luong DECIMAL(18, 2)
);
GO
-- DỊCH VỤ
CREATE TABLE DichVu (
    MaDichVu INT IDENTITY(1,1) PRIMARY KEY,
    TenDichVu NVARCHAR(100),
    Gia DECIMAL(18, 2)
);
GO
-- PHÒNG THI
CREATE TABLE PhongThi (
    MaPhongThi INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    SoThiSinhToiDa INT
);
GO
-- LỊCH THI
CREATE TABLE LichThi (
    MaLichThi INT IDENTITY(1,1) PRIMARY KEY,
    NgayThi DATE DEFAULT GETDATE(),
    GioThi TIME,
    SoTSDaDangKy INT,
	MaPhongThi INT,
	MaDichVu INT,
	NvLap INT,
	FOREIGN KEY (MaPhongThi) REFERENCES PhongThi(MaPhongThi),
	FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu),
	FOREIGN KEY (NvLap) REFERENCES NHANVIEN(MaNV)
);
GO
-- PHIẾU ĐĂNG KÍ
CREATE TABLE PhieuDangKy (
    MaPhieuDangKy INT IDENTITY(1,1) PRIMARY KEY,
    NgayTao DATE DEFAULT GETDATE(),
    TrangThaiThanhToan NVARCHAR(50),
    MaKH INT,
	NvLap INT
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
	FOREIGN KEY (NvLap) REFERENCES NHANVIEN(MaNV)
);
GO
-- CHI TIẾT PHIẾU
CREATE TABLE ChiTietPhieu (
    MaPhieuDangKy INT,
    MaLichThi INT,
    SoLuong INT,
    PRIMARY KEY (MaPhieuDangKy, MaLichThi),
    FOREIGN KEY (MaPhieuDangKy) REFERENCES PhieuDangKy(MaPhieuDangKy),
    FOREIGN KEY (MaLichThi) REFERENCES LichThi(MaLichThi)
);
GO
-- PHIẾU GIA HẠN
CREATE TABLE PhieuGiaHan (
    MaPhieuGiaHan INT IDENTITY(1,1) PRIMARY KEY,
    NgayTao DATE DEFAULT GETDATE(),
    LyDo NVARCHAR(255),
    TrangThaiThanhToan NVARCHAR(50),
    MaNV INT,
    MaPhieuDangKy INT,
	MaLichThi INT
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaPhieuDangKy, MaLichThi) REFERENCES ChiTietPhieu(MaPhieuDangKy,MaLichThi)
);
GO
-- THÍ SINH
CREATE TABLE ThiSinh (
    MaTS INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    CCCD NVARCHAR(12),
    GioiTinh NVARCHAR(10),
    TrangThaiPhatHanhPhieuDuThi NVARCHAR(50),
	MaLichThi INT,
	FOREIGN KEY (MaLichThi) REFERENCES LichThi(MaLichThi)
);
GO
-- CHỨNG CHỈ
CREATE TABLE ChungChi (
    MaChungChi INT IDENTITY(1,1) PRIMARY KEY,
    MaTS INT,
	NvLap INT,
    NgayCap DATE DEFAULT GETDATE(),
    TrangThai NVARCHAR(50),
    KetQua NVARCHAR(50),
	FOREIGN KEY (NvLap) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaTS) REFERENCES ThiSinh(MaTS)
);
GO
-- HÓA ĐƠN
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    TongTien DECIMAL(18, 2),
    ChietKhau DECIMAL(5, 2),
    PhuongThucThanhToan NVARCHAR(50),
    NgayTao DATE DEFAULT GETDATE(),
    Loai NVARCHAR(50),
    NvLap INT,
    MaPhieuDangKy INT,
	MaPhieuGiaHan INT
    FOREIGN KEY (NvLap) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaPhieuDangKy) REFERENCES PhieuDangKy(MaPhieuDangKy),
	FOREIGN KEY (MaPhieuGiaHan) REFERENCES PhieuGiaHan(MaPhieuGiaHan)
);
GO
-- Khách hàng
INSERT INTO KhachHang (LoaiKhachHang, Email) VALUES 
(N'Tự do', 'nguyenvana@gmail.com'),
(N'Đơn vị', 'côngtyabc@gmail.com');

-- Khách hàng tự do
INSERT INTO KhachHangTuDo (MaKH, HoTen, NgaySinh) VALUES 
(1, N'Nguyễn Văn A', '1990-05-20');

-- Khách hàng đơn vị
INSERT INTO KhachHangDonVi (MaKH, TenDV, DiaChi) VALUES 
(2, N'Công ty ABC', N'123 Lê Lợi, Quận 1, TP.HCM');
GO
-- Nhân viên
INSERT INTO NhanVien (MatKhau, HoTen, SDT, Email, VaiTro, Luong) VALUES
('123456', N'Trần Thị B', '0909123456', 'tranb@example.com', N'Tiếp nhận', 15000000),
('123456', N'Phạm Văn C', '0911123456', 'phamc@example.com', N'Kế toán', 10000000),
('123456', N'Phạm Văn D', '0911123456', 'phamd@example.com', N'Nhập liệu', 10000000);
GO
-- Dịch vụ
INSERT INTO DichVu (TenDichVu, Gia) VALUES
(N'Thi TOEIC', 500000),
(N'Thi IELTS', 700000);
-- Phòng thi
INSERT INTO PhongThi (TenPhong, SoThiSinhToiDa) VALUES
(N'Phòng 101', 30),
(N'Phòng 202', 25);
-- Lịch thi
INSERT INTO LichThi (NgayThi, GioThi, SoTSDaDangKy, MaPhongThi, MaDichVu, NvLap) VALUES
('2025-07-15', '08:00:00', 10, 1, 1, 1),
('2025-07-20', '14:00:00', 5, 2, 2, 2);
-- Phiếu đăng ký
INSERT INTO PhieuDangKy (TrangThaiThanhToan, MaKH, NvLap) VALUES
(N'Chưa thanh toán', 1, 1),
(N'Đã thanh toán', 2, 2);
--Chi tiết phiếu
INSERT INTO ChiTietPhieu (MaPhieuDangKy, MaLichThi, SoLuong) VALUES
(1, 1, 1),
(2, 2, 2);
-- Phiếu gia hạn
INSERT INTO PhieuGiaHan (LyDo, TrangThaiThanhToan, MaNV, MaPhieuDangKy, MaLichThi) VALUES
(N'Bận việc cá nhân', N'Chưa thanh toán', 2, 1, 1);
-- Thí sinh
INSERT INTO ThiSinh (HoTen, NgaySinh, CCCD, GioiTinh, TrangThaiPhatHanhPhieuDuThi, MaLichThi) VALUES
(N'Lê Thị D', '1995-03-15', '123456789012', N'Nữ', N'Đã phát hành', 1),
(N'Ngô Văn E', '1992-11-01', '987654321098', N'Nam', N'Đã phát hành', 2);
--Chứng chỉ
INSERT INTO ChungChi (MaTS, NvLap, TrangThai, KetQua) VALUES
(1, 1, N'Đã cấp', N'Đạt'),
(2, 2, N'Chưa cấp', N'Đạt');
--Hóa đơn
INSERT INTO HoaDon (TongTien, ChietKhau, PhuongThucThanhToan, Loai, NvLap, MaPhieuDangKy, MaPhieuGiaHan) VALUES
(500000, 0, N'Tiền mặt', N'Phí đăng kí', 1, 1, NULL),
(700000, 10, N'Chuyển khoản', N'Gia hạn', 2, NULL, 1);












