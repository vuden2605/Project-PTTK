CREATE DATABASE QuanLyChungChi;
GO
USE QuanLyChungChi;
GO
CREATE TABLE KHACH_HANG (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    LoaiKhachHang NVARCHAR(50),
    Email NVARCHAR(100)
);
GO
CREATE TABLE KHACH_HANG_TU_DO (
    MaKH INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH)
);
GO
CREATE TABLE KHACH_HANG_DON_VI (
    MaKH INT PRIMARY KEY,
    TenDV NVARCHAR(100),
    DiaChi NVARCHAR(200),
    FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH)
);
GO
CREATE TABLE NHAN_VIEN (
    MaNV INT PRIMARY KEY IDENTITY(1,1),
    MatKhau NVARCHAR(100),
    HoTen NVARCHAR(100),
    SDT NVARCHAR(15),
    Email NVARCHAR(100),
    VaiTro NVARCHAR(50),
    Luong DECIMAL(18,2)
);
GO
CREATE TABLE DICH_VU (
    MaDichVu INT PRIMARY KEY IDENTITY(1,1),
    TenDichVu NVARCHAR(100),
    Gia DECIMAL(18,2)
);
GO
CREATE TABLE PHONG_THI (
    MaPhongThi INT PRIMARY KEY IDENTITY(1,1),
    TenPhong NVARCHAR(100)
);
GO	
CREATE TABLE LICH_THI (
    MaLichThi INT PRIMARY KEY IDENTITY(1,1),
    NgayThi DATE,
    GioThi TIME,
    SoThiSinhToiDa INT,
    SoThiSinhDaDangKi INT,
    MaPhongThi INT,
    MaDichVu INT,
	NvLap INT
    FOREIGN KEY (MaPhongThi) REFERENCES PHONG_THI(MaPhongThi),
    FOREIGN KEY (MaDichVu) REFERENCES DICH_VU(MaDichVu),
	FOREIGN KEY (NvLap) REFERENCES NHAN_VIEN(MaNV)
);
CREATE TABLE PHIEU_DANG_KI (
    MaPhieuDangKi INT PRIMARY KEY IDENTITY(1,1),
    NgayTao DATE DEFAULT GETDATE(),
    TrangThaiThanhToan NVARCHAR(50),
    PhuongThucThanhToan NVARCHAR(50),
    MaKH INT,
	NvLap INT
    FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
	FOREIGN KEY (NvLap) REFERENCES NHAN_VIEN(MaNV)
);
GO
CREATE TABLE CHI_TIET_PHIEU (
    MaPhieuDangKi INT,
    MaDichVu INT,
	Soluong INT,
    PRIMARY KEY (MaPhieuDangKi, MaDichVu),
    FOREIGN KEY (MaPhieuDangKi) REFERENCES PHIEU_DANG_KI(MaPhieuDangKi),
    FOREIGN KEY (MaDichVu) REFERENCES DICH_VU(MaDichVu)
);
GO
CREATE TABLE PHIEU_GIA_HAN (
    MaPhieuGiaHan INT PRIMARY KEY IDENTITY(1,1),
    NgayTao DATE DEFAULT GETDATE(),
    LyDo NVARCHAR(200),
    TrangThaiThanhToan NVARCHAR(50),
    MaPhieuDangKi INT,
    FOREIGN KEY (MaPhieuDangKi) REFERENCES PHIEU_DANG_KI(MaPhieuDangKi)
);
GO
CREATE TABLE HOA_DON (
    MaHoaDon INT PRIMARY KEY IDENTITY(1,1),
    TongTien DECIMAL(18,2),
    ChietKhau DECIMAL(18,2),
    NgayTao DATE DEFAULT GETDATE(),
    Loai NVARCHAR(50),
    NvLap INT,
    MaPhieuDangKi INT,
	MaPhieuGiaHan INT,
    FOREIGN KEY (NvLap) REFERENCES NHAN_VIEN(MaNV),
	FOREIGN KEY (MaPhieuGiaHan) REFERENCES PHIEU_GIA_HAN(MaPhieuGiaHan),
    FOREIGN KEY (MaPhieuDangKi) REFERENCES PHIEU_DANG_KI(MaPhieuDangKi)
);
GO
CREATE TABLE THI_SINH (
    MaTS INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    TrangThaiPhatHanhPhieuDuThi NVARCHAR(100),
    MaKH INT,
	MaLichThi INT,
    FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
	FOREIGN KEY (MaLichThi) REFERENCES LICH_THI(MaLichThi)
);
GO
CREATE TABLE CHUNG_CHI (
    MaChungChi INT PRIMARY KEY IDENTITY(1,1),
    NgayCap DATE DEFAULT GETDATE(),
    TrangThai NVARCHAR(50),
    KetQua DECIMAL(10,2),
    MaTS INT,
	NvLap INT
    FOREIGN KEY (MaTS) REFERENCES THI_SINH(MaTS),
	FOREIGN KEY (NvLap) REFERENCES NHAN_VIEN(MaNV)
);
GO
-- Khách hàng tổng
INSERT INTO KHACH_HANG (LoaiKhachHang, Email) VALUES
(N'Tự do', 'tudo1@gmail.com'), -- ID = 1
(N'Đơn vị', 'donvi1@gmail.com'); -- ID = 2

-- Khách hàng tự do
INSERT INTO KHACH_HANG_TU_DO (MaKH, HoTen, NgaySinh) VALUES
(1, N'Nguyễn Văn A', '1995-05-12');

-- Khách hàng đơn vị
INSERT INTO KHACH_HANG_DON_VI (MaKH, TenDV, DiaChi) VALUES
(2, N'Công ty ABC', N'123 Đường ABC, Quận 1');
GO

INSERT INTO NHAN_VIEN (MatKhau, HoTen, SDT, Email, VaiTro, Luong) VALUES
('123456', N'Lê Thị B', '0909123456', 'nvb@gmail.com', N'Nhân viên tiếp nhận', 10000000),
('123456', N'Trần Văn C', '0988123123', 'nvc@gmail.com', N'Nhân viên thanh toán', 12000000);
GO
INSERT INTO DICH_VU (TenDichVu, Gia) VALUES
(N'Thi TOEIC', 500000),
(N'Thi IELTS', 700000),
(N'Thi VSTEP',80000),
(N'Thi tin học',60000);
GO
INSERT INTO PHONG_THI (TenPhong) VALUES
(N'Phòng 101'),
(N'Phòng 202'),
(N'Phòng 303'),
(N'Phòng 404');
GO
INSERT INTO LICH_THI (NgayThi, GioThi, SoThiSinhToiDa, SoThiSinhDaDangKi, MaPhongThi, MaDichVu, NvLap)
VALUES
('2025-07-20', '08:00', 20, 0, 1, 1, 1),
('2025-07-20', '14:00', 20, 0, 2, 2, 1);
GO
INSERT INTO PHIEU_DANG_KI (TrangThaiThanhToan, PhuongThucThanhToan, MaKH, NvLap)
VALUES
(N'Chưa thanh toán', N'Tiền mặt', 1, 2);
GO
INSERT INTO CHI_TIET_PHIEU (MaPhieuDangKi, MaDichVu,Soluong)
VALUES (1, 1,1);
GO
INSERT INTO PHIEU_GIA_HAN (LyDo, TrangThaiThanhToan, MaPhieuDangKi)
VALUES
(N'Vắng thi', N'Chưa thanh toán', 1);
GO
INSERT INTO HOA_DON (TongTien, ChietKhau, Loai, NvLap, MaPhieuDangKi, MaPhieuGiaHan)
VALUES
(500000, 0, N'Phiếu đăng ký', 1, 1, null);
GO
INSERT INTO THI_SINH (HoTen, NgaySinh, TrangThaiPhatHanhPhieuDuThi, MaKH, MaLichThi)
VALUES
(N'Nguyễn Văn A', '1995-05-12', N'Đã phát hành', 1, 1);
INSERT INTO CHUNG_CHI (TrangThai, KetQua, MaTS, NvLap)
VALUES
(N'Đã cấp', 9.0, 1, 2);









