CREATE TABLE KhachHang (
    MaKhachHang NVARCHAR(10) PRIMARY KEY, -- Mã khách hàng
    TenKhachHang NVARCHAR(100) NOT NULL, -- Tên khách hàng
    CCCD NVARCHAR(12) NOT NULL UNIQUE, -- CCCD
    SoDienThoai NVARCHAR(15) NOT NULL, -- Số điện thoại
    NamSinh DATE, -- Năm sinh
    DiaChi NVARCHAR(255), -- Địa chỉ
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')), -- Giới tính
    NgheNghiep NVARCHAR(100), -- Nghề nghiệp
    NgayThue DATE -- Ngày thuê
);
ALTER TABLE KhachHang
ADD MaPhong NVARCHAR(10), -- Mã phòng (khóa ngoại)
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong); 

CREATE TABLE PhongTro (
    MaPhong NVARCHAR(10) PRIMARY KEY, -- Mã phòng
    MaLoaiPhong NVARCHAR(10) NOT NULL, -- Mã loại phòng
    TrangThaiPhong NVARCHAR(50) CHECK (TrangThaiPhong IN (N'Trống', N'Đã thuê')), -- Trạng thái phòng
    FOREIGN KEY (MaLoaiPhong) REFERENCES LoaiPhong(MaLoaiPhong) -- Khóa ngoại tham chiếu đến loại phòng
);


CREATE TABLE LoaiPhong (
    MaLoaiPhong NVARCHAR(10) PRIMARY KEY, -- Mã loại phòng
    GiaThue MONEY NOT NULL, -- Giá thuê
    SoNguoi INT NOT NULL CHECK (SoNguoi > 0) -- Số người
);

-- Trigger hóa đơn
CREATE TRIGGER UpdateGiaPhong_HoaDon
ON LoaiPhong
AFTER UPDATE
AS
BEGIN
    UPDATE HoaDonTong
    SET TienPhong = (
        SELECT lp.GiaThue
        FROM LoaiPhong lp
        INNER JOIN PhongTro pt ON lp.MaLoaiPhong = pt.MaLoaiPhong
        INNER JOIN inserted i ON lp.MaLoaiPhong = i.MaLoaiPhong
        WHERE HoaDonTong.MaPhong = pt.MaPhong
    )
    WHERE EXISTS (
        SELECT 1
        FROM Phongtro pt
        INNER JOIN inserted i ON pt.MaLoaiPhong = i.MaLoaiPhong
        WHERE HoaDonTong.MaPhong = pt.MaPhong
    );
END

CREATE TABLE DichVu (
    MaDichVu NVARCHAR(10) PRIMARY KEY, -- Mã dịch vụ
    TenDichVu NVARCHAR(100) NOT NULL, -- Tên dịch vụ
    GiaDichVu MONEY NOT NULL, -- Giá dịch vụ
    MoTa NVARCHAR(255) -- Mô tả dịch vụ
);
CREATE TABLE HoaDonDichVu (
    MaHoaDon NVARCHAR(10),
    MaDichVu NVARCHAR(10),
    SoLuong INT,
    ThanhTien INT,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDonTong(MaHoaDon),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
);
		-- Trigger tính thành tiền = số lượng * số dịch vụ
		CREATE TRIGGER tr_UpdateThanhTien
		ON HoaDonDichVu
		AFTER INSERT, UPDATE
		AS
		BEGIN
			UPDATE HD
			SET HD.ThanhTien = DV.GiaDichVu * HD.SoLuong
			FROM HoaDonDichVu HD
			INNER JOIN DichVu DV ON HD.MaDichVu = DV.MaDichVu
			WHERE HD.MaHoaDon IN (SELECT MaHoaDon FROM inserted)
		END

CREATE TABLE HopDong (
    MaHopDong NVARCHAR(10) PRIMARY KEY, -- Mã hợp đồng
    MaPhong NVARCHAR(10) NOT NULL, -- Mã phòng
    NgayLapHopDong DATE NOT NULL, -- Ngày lập hợp đồng
    TrangThaiHopDong NVARCHAR(50) CHECK (TrangThaiHopDong IN (N'Còn hiệu lực', N'Hết hạn')), -- Trạng thái hợp đồng
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong) -- Khóa ngoại tham chiếu đến phòng
);


CREATE TABLE ChiTietHopDong (
    MaChiTietHopDong NVARCHAR(10) PRIMARY KEY, -- Mã chi tiết hợp đồng
    MaHopDong NVARCHAR(10) NOT NULL, -- Mã hợp đồng
    NgayBatDau DATE NOT NULL, -- Ngày bắt đầu hợp đồng
    NgayKetThuc DATE NOT NULL, -- Ngày kết thúc hợp đồng
    TienCoc MONEY NOT NULL, -- Tiền cọc
    FOREIGN KEY (MaHopDong) REFERENCES HopDong(MaHopDong) -- Khóa ngoại tham chiếu đến hợp đồng
);


CREATE TABLE HoaDonDien (
    MaHoaDonDien NVARCHAR(10) PRIMARY KEY, -- Mã hóa đơn điện
    MaPhong NVARCHAR(10) NOT NULL, -- Mã phòng
    ChiSoCu INT NOT NULL CHECK (ChiSoCu >= 0), -- Chỉ số cũ
    ChiSoMoi INT NOT NULL CHECK (ChiSoMoi >= 0), -- Chỉ số mới
    ThanhTien AS ((ChiSoMoi - ChiSoCu) * 3500) PERSISTED, -- Thành tiền
    ThoiGian DATE NOT NULL, -- Thời gian
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong) -- Khóa ngoại tham chiếu đến phòng
);

CREATE TABLE HoaDonNuoc (
    MaHoaDonNuoc NVARCHAR(10) PRIMARY KEY, -- Mã hóa đơn nước
    MaPhong NVARCHAR(10) NOT NULL, -- Mã phòng
    ChiSoCu INT NOT NULL CHECK (ChiSoCu >= 0), -- Chỉ số cũ
    ChiSoMoi INT NOT NULL CHECK (ChiSoMoi >= 0), -- Chỉ số mới
    ThanhTien AS ((ChiSoMoi - ChiSoCu) * 20000) PERSISTED, -- Thành tiền
    ThoiGian DATE NOT NULL, -- Thời gian
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong) -- Khóa ngoại tham chiếu đến phòng
);

CREATE TABLE HoaDonTong (
    MaHoaDon NVARCHAR(10) PRIMARY KEY, -- Mã hóa đơn tổng
    MaPhong NVARCHAR(10) NOT NULL, -- Mã phòng
    NgayLapHoaDon DATE NOT NULL, -- Ngày lập hóa đơn
    TienPhong MONEY NOT NULL, -- Tiền phòng
    MaHoaDonDien NVARCHAR(10) FOREIGN KEY REFERENCES HoaDonDien(MaHoaDonDien), -- Mã hóa đơn điện
    MaHoaDonNuoc NVARCHAR(10) FOREIGN KEY REFERENCES HoaDonNuoc(MaHoaDonNuoc), -- Mã hóa đơn nước
    TongTien MONEY -- Tổng tiền
);


CREATE TRIGGER trg_UpdateTongTien
ON HoaDonTong
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE HoaDonTong
    SET TongTien = 
        TienPhong + 
        ISNULL((SELECT SUM(ThanhTien) FROM HoaDonDichVu WHERE MaHoaDon = HoaDonTong.MaHoaDon), 0) +
        ISNULL((SELECT ThanhTien FROM HoaDonDien WHERE MaPhong = HoaDonTong.MaPhong), 0) + 
        ISNULL((SELECT ThanhTien FROM HoaDonNuoc WHERE MaPhong = HoaDonTong.MaPhong), 0)
    WHERE MaHoaDon IN (SELECT MaHoaDon FROM inserted);
END;

-- Trigger cập nhật tổng tiền hóa đơn từ các bảng hóa đơn liên quan
CREATE TRIGGER UpdateTongTien_HoaDonDien
ON HoaDonDien
AFTER UPDATE
AS
BEGIN
    UPDATE HoaDonTong
    SET TongTien = (
        SELECT ISNULL(hdn.ThanhTienNuoc, 0) + ISNULL(hdi.ThanhTienDien, 0)
        FROM HoaDonTong hdt
        INNER JOIN HoaDonNuoc hdn ON hdt.MaHoaDonNuoc = hdn.MaHoaDonNuoc
        INNER JOIN inserted hdi ON hdt.MaHoaDonDien = hdi.MaHoaDonDien
        WHERE hdt.MaHoaDonDien = hdi.MaHoaDonDien
    );
END;

-- Trigger cho bảng Hóa đơn nước
-- trigger hóa đơn nước
CREATE TRIGGER UpdateTongTien_HoaDonNuoc
ON HoaDonNuoc
AFTER UPDATE
AS
BEGIN
    UPDATE HoaDonTong
    SET TongTien = (
        SELECT ISNULL(hdn.ThanhTien, 0) + ISNULL(hdi.ThanhTien, 0)
        FROM HoaDonTong hdt
        INNER JOIN HoaDonDien hdi ON hdt.MaHoaDonDien = hdi.MaHoaDonDien
        INNER JOIN inserted hdn ON hdt.MaHoaDonNuoc = hdn.MaHoaDonNuoc
        WHERE hdt.MaHoaDonNuoc = hdn.MaHoaDonNuoc
    );
END;
-- trigger hóa đơn điện 
CREATE TRIGGER UpdateTongTien_HoaDonDien
ON HoaDonDien
AFTER UPDATE
AS
BEGIN
    UPDATE HoaDonTong
    SET TongTien = (
        SELECT ISNULL(hdn.ThanhTien, 0) + ISNULL(hdi.ThanhTien, 0)
        FROM HoaDonTong hdt
        INNER JOIN HoaDonNuoc hdn ON hdt.MaHoaDonNuoc = hdn.MaHoaDonNuoc
        INNER JOIN inserted hdi ON hdt.MaHoaDonDien = hdi.MaHoaDonDien
        WHERE hdt.MaHoaDonDien = hdi.MaHoaDonDien
    );
END;
-- trigger hóa đơn dịch vụ 

CREATE TRIGGER UpdateTongTien_HoaDonDichVu
ON HoaDonDichVu
AFTER UPDATE
AS
BEGIN
    UPDATE HoaDonTong
    SET TongTien = (
        SELECT ISNULL(hddv.ThanhTien, 0) + ISNULL(hdi.ThanhTien, 0)
        FROM HoaDonTong hdt
        INNER JOIN HoaDonDichVu hddv ON hdt.MaHoaDon = hddv.MaHoaDon
        INNER JOIN inserted hdi ON hdt.MaHoaDon = hdi.MaHoaDon
        WHERE hdt.MaHoaDon = hdi.MaHoaDon
    );
END;



-- INSERT DATA
-- Bảng loại phòng
INSERT INTO LoaiPhong (MaLoaiPhong, GiaThue, SoNguoi) VALUES
('LP001', 1500000, 1),  
('LP002', 2800000, 2),  
('LP003', 4000000, 3), 
('LP004', 6000000, 4); 
-- Bảng phòng trọ 
INSERT INTO PhongTro (MaPhong, MaLoaiPhong, TrangThaiPhong) VALUES
('P001', 'LP001', N'Trống'),
('P002', 'LP001', N'Đã thuê'),
('P003', 'LP002', N'Trống'),
('P004', 'LP002', N'Đã thuê'),
('P005', 'LP003', N'Đã thuê'),
('P006', 'LP003', N'Trống'),
('P007', 'LP001', N'Trống'),
('P008', 'LP001', N'Đã thuê'),
('P009', 'LP001', N'Trống'),
('P010', 'LP002', N'Đã thuê'),
('P011', 'LP002', N'Trống'),
('P012', 'LP002', N'Đã thuê'),
('P013', 'LP003', N'Trống'),
('P014', 'LP003', N'Trống'),
('P015', 'LP003', N'Đã thuê'),
('P016', 'LP004', N'Trống'),
('P017', 'LP004', N'Trống'),
('P018', 'LP004', N'Đã thuê'),
('P019', 'LP001', N'Đã thuê'),
('P020', 'LP001', N'Trống'),
('P021', 'LP002', N'Đã thuê'),
('P022', 'LP003', N'Trống'),
('P023', 'LP003', N'Trống'),
('P024', 'LP004', N'Trống'),
('P025', 'LP004', N'Trống'),
('P026', 'LP001', N'Đã thuê'),
('P027', 'LP002', N'Đã thuê'),
('P028', 'LP002', N'Trống'),
('P029', 'LP003', N'Đã thuê'),
('P030', 'LP004', N'Trống');

-- Bảng dịch vụ
INSERT INTO DichVu (MaDichVu, TenDichVu, GiaDichVu, MoTa)
VALUES
    ('DV001', N'Dịch vụ internet', 200000, N'Gói internet 100Mbps'),
    ('DV002', N'Dịch vụ vệ sinh', 150000, N'Dịch vụ dọn phòng hàng tuần'),
    ('DV003', N'Dịch vụ giặt là', 100000, N'Giặt là quần áo'),
    ('DV004', N'Dịch vụ cho thuê xe', 50000, N'Cho thuê xe máy theo ngày'),
    ('DV005', N'Tiền rác', 30000, N'Phí vệ sinh rác thải hàng tháng'),
	('DV006', N'Dịch vụ sửa chữa', 50000, N'Sửa chữa thiết bị'),
	('DV007', N'Dịch vụ bảo trì', 70000, N'Bảo trì thiết bị trong phòng');

-- Bảng khách hàng
INSERT INTO KhachHang (MaKhachHang, TenKhachHang, CCCD, SoDienThoai, NamSinh, DiaChi, GioiTinh, NgheNghiep, MaPhong) VALUES
-- Phòng P002 - LP001 (1 người)
('KH001', N'Nguyễn Văn A', '12345678901', '0901234567', '2000-01-01', N'Hà Nội', N'Nam', N'Sinh viên', 'P002'), -- Đã thuê

-- Phòng P004 - LP002 (2 người)
('KH002', N'Nguyễn Văn B', '12345678902', '0901234568', '1999-02-02', N'Hải Phòng', N'Nam', N'Sinh viên', 'P004'), -- Đã thuê
('KH003', N'Trần Thị C', '12345678903', '0901234569', '1998-03-03', N'TPHCM', N'Nữ', N'Nhân viên', 'P004'), -- Đã thuê

-- Phòng P005 - LP003 (3 người)
('KH004', N'Nguyễn Văn D', '12345678904', '0901234570', '1997-04-04', N'Đà Nẵng', N'Nam', N'Kỹ sư', 'P005'), -- Đã thuê
('KH005', N'Trần Thị E', '12345678905', '0901234571', '1996-05-05', N'Thuận An', N'Nữ', N'Giáo viên', 'P005'), -- Đã thuê
('KH006', N'Nguyễn Văn F', '12345678906', '0901234572', '1995-06-06', N'Hải Phòng', N'Nam', N'Sinh viên', 'P005'), -- Đã thuê

-- Phòng P010 - LP002 (2 người)
('KH007', N'Nguyễn Văn G', '12345678907', '0901234573', '1994-07-07', N'Hà Nội', N'Nam', N'Nghiên cứu viên', 'P010'), -- Đã thuê
('KH008', N'Trần Thị H', '12345678908', '0901234574', '1993-08-08', N'TPHCM', N'Nữ', N'Nhân viên', 'P010'), -- Đã thuê

-- Phòng P012 - LP002 (2 người)
('KH009', N'Nguyễn Văn I', '12345678909', '0901234575', '1992-09-09', N'Hải Phòng', N'Nam', N'Sinh viên', 'P012'), -- Đã thuê
('KH010', N'Trần Thị J', '12345678910', '0901234576', '1991-10-10', N'Thuận An', N'Nữ', N'Giáo viên', 'P012'), -- Đã thuê

-- Phòng P015 - LP003 (3 người)
('KH011', N'Nguyễn Văn K', '12345678911', '0901234577', '1990-11-11', N'Đà Nẵng', N'Nam', N'Kỹ sư', 'P015'), -- Đã thuê
('KH012', N'Trần Thị L', '12345678912', '0901234578', '1989-12-12', N'Hà Nội', N'Nữ', N'Nghiên cứu viên', 'P015'), -- Đã thuê
('KH013', N'Nguyễn Văn M', '12345678913', '0901234579', '1988-01-01', N'TPHCM', N'Nam', N'Sinh viên', 'P015'), -- Đã thuê

-- Phòng P018 - LP004 (4 người)
('KH014', N'Nguyễn Văn N', '12345678914', '0901234580', '1987-02-02', N'Hải Phòng', N'Nam', N'Sinh viên', 'P018'), -- Đã thuê
('KH015', N'Trần Thị O', '12345678915', '0901234581', '1986-03-03', N'Thuận An', N'Nữ', N'Giáo viên', 'P018'), -- Đã thuê
('KH016', N'Nguyễn Văn P', '12345678916', '0901234582', '1985-04-04', N'Đà Nẵng', N'Nam', N'Kỹ sư', 'P018'), -- Đã thuê
('KH017', N'Trần Thị Q', '12345678917', '0901234583', '1984-05-05', N'Hà Nội', N'Nữ', N'Nghiên cứu viên', 'P018'), -- Đã thuê

-- Phòng P021 - LP002 (2 người)
('KH018', N'Nguyễn Văn R', '12345678918', '0901234584', '1993-06-06', N'TPHCM', N'Nam', N'Sinh viên', 'P021'), -- Đã thuê
('KH019', N'Trần Thị S', '12345678919', '0901234585', '1992-07-07', N'Hải Phòng', N'Nữ', N'Giáo viên', 'P021'), -- Đã thuê

-- Phòng P027 - LP002 (2 người)
('KH020', N'Nguyễn Văn T', '12345678920', '0901234586', '1991-08-08', N'Thuận An', N'Nam', N'Nghiên cứu viên', 'P027'), -- Đã thuê
('KH021', N'Trần Thị U', '12345678921', '0901234587', '1990-09-09', N'Đà Nẵng', N'Nữ', N'Kỹ sư', 'P027'), -- Đã thuê

-- Phòng P029 - LP003 (3 người)
('KH022', N'Nguyễn Văn V', '12345678922', '0901234588', '1989-10-10', N'Hà Nội', N'Nam', N'Sinh viên', 'P029'), -- Đã thuê
('KH023', N'Trần Thị W', '12345678923', '0901234589', '1988-11-11', N'TPHCM', N'Nữ', N'Giáo viên', 'P029'), -- Đã thuê
('KH024', N'Nguyễn Văn X', '12345678924', '0901234590', '1987-12-12', N'Hải Phòng', N'Nam', N'Kỹ sư', 'P029'); -- Đã thuê

-- Bảng hợp đồng
INSERT INTO HopDong (MaHopDong, MaPhong, NgayLapHopDong, TrangThaiHopDong) VALUES
('HD001', 'P002', '2024-10-01', N'Còn hiệu lực'), -- Hợp đồng cho phòng P002
('HD002', 'P004', '2024-10-02', N'Còn hiệu lực'), -- Hợp đồng cho phòng P004
('HD003', 'P005', '2024-10-03', N'Còn hiệu lực'), -- Hợp đồng cho phòng P005
('HD004', 'P008', '2024-10-04', N'Còn hiệu lực'), -- Hợp đồng cho phòng P008
('HD005', 'P010', '2024-10-05', N'Còn hiệu lực'), -- Hợp đồng cho phòng P010
('HD006', 'P012', '2024-10-06', N'Còn hiệu lực'), -- Hợp đồng cho phòng P012
('HD007', 'P015', '2024-10-07', N'Còn hiệu lực'), -- Hợp đồng cho phòng P015
('HD008', 'P018', '2024-10-08', N'Còn hiệu lực'), -- Hợp đồng cho phòng P018
('HD009', 'P019', '2024-10-09', N'Còn hiệu lực'), -- Hợp đồng cho phòng P019
('HD010', 'P026', '2024-10-10', N'Còn hiệu lực'), -- Hợp đồng cho phòng P026
('HD011', 'P021', '2024-10-11', N'Còn hiệu lực'), -- Hợp đồng cho phòng P021
('HD012', 'P027', '2024-10-12', N'Còn hiệu lực'), -- Hợp đồng cho phòng P027
('HD013', 'P029', '2024-10-13', N'Còn hiệu lực'); -- Hợp đồng cho phòng P029

-- Bảng CTHD
INSERT INTO ChiTietHopDong (MaChiTietHopDong, MaHopDong, NgayBatDau, NgayKetThuc, TienCoc) VALUES
('CTHD001', 'HD001', '2024-10-01', '2025-01-01', 1000000), -- Chi tiết hợp đồng cho HD001
('CTHD002', 'HD002', '2024-10-02', '2025-02-01', 1500000), -- Chi tiết hợp đồng cho HD002
('CTHD003', 'HD003', '2024-10-03', '2025-03-01', 1200000), -- Chi tiết hợp đồng cho HD003
('CTHD004', 'HD004', '2024-10-04', '2025-04-01', 2000000), -- Chi tiết hợp đồng cho HD004
('CTHD005', 'HD005', '2024-10-05', '2025-05-01', 1800000), -- Chi tiết hợp đồng cho HD005
('CTHD006', 'HD006', '2024-10-06', '2025-06-01', 1600000), -- Chi tiết hợp đồng cho HD006
('CTHD007', 'HD007', '2024-10-07', '2025-07-01', 1300000), -- Chi tiết hợp đồng cho HD007
('CTHD008', 'HD008', '2024-10-08', '2025-08-01', 1900000), -- Chi tiết hợp đồng cho HD008
('CTHD009', 'HD009', '2024-10-09', '2025-09-01', 1700000), -- Chi tiết hợp đồng cho HD009
('CTHD010', 'HD010', '2024-10-10', '2025-10-01', 1100000), -- Chi tiết hợp đồng cho HD010
('CTHD011', 'HD011', '2024-10-11', '2025-11-01', 1400000), -- Chi tiết hợp đồng cho HD011
('CTHD012', 'HD012', '2024-10-12', '2025-12-01', 2000000), -- Chi tiết hợp đồng cho HD012
('CTHD013', 'HD013', '2024-10-13', '2026-01-01', 1500000); -- Chi tiết hợp đồng cho HD013

-- Bảng hóa đơn
-- Dữ liệu mẫu cho bảng HoaDonDien
INSERT INTO HoaDonDien (MaHoaDonDien, MaPhong, ChiSoCu, ChiSoMoi, ThoiGian) VALUES
('HDD001', 'P002', 100, 120, '2024-10-01'),
('HDD002', 'P004', 150, 180, '2024-10-01'),
('HDD003', 'P005', 200, 220, '2024-10-01'),
('HDD004', 'P008', 80, 100, '2024-10-01'),
('HDD005', 'P010', 120, 140, '2024-10-01'),
('HDD006', 'P012', 90, 110, '2024-10-01'),
('HDD007', 'P015', 60, 80, '2024-10-01'),
('HDD008', 'P018', 140, 160, '2024-10-01'),
('HDD009', 'P019', 70, 90, '2024-10-01'),
('HDD010', 'P021', 110, 130, '2024-10-01'),
('HDD011', 'P027', 130, 150, '2024-10-01'),
('HDD012', 'P029', 50, 70, '2024-10-01');

-- Dữ liệu mẫu cho bảng HoaDonNuoc
INSERT INTO HoaDonNuoc (MaHoaDonNuoc, MaPhong, ChiSoCu, ChiSoMoi, ThoiGian) VALUES
('HDN001', 'P002', 50, 60, '2024-10-01'),
('HDN002', 'P004', 70, 80, '2024-10-01'),
('HDN003', 'P005', 60, 75, '2024-10-01'),
('HDN004', 'P008', 40, 55, '2024-10-01'),
('HDN005', 'P010', 20, 25, '2024-10-01'),
('HDN006', 'P012', 10, 15, '2024-10-01'),
('HDN007', 'P015', 30, 35, '2024-10-01'),
('HDN008', 'P018', 80, 90, '2024-10-01'),
('HDN009', 'P019', 50, 55, '2024-10-01'),
('HDN010', 'P021', 15, 20, '2024-10-01'),
('HDN011', 'P027', 25, 30, '2024-10-01'),
('HDN012', 'P029', 5, 10, '2024-10-01');
-- Dữ liệu mẫu cho bảng HoaDonDichVu
INSERT INTO HoaDonDichVu (MaHoaDon, MaDichVu, SoLuong) VALUES
('HDT001', 'DV001', 1), -- Dịch vụ internet
('HDT001', 'DV003', 3), -- Dịch vụ giặt là
('HDT002', 'DV002', 1), -- Dịch vụ vệ sinh
('HDT003', 'DV004', 2), -- Dịch vụ cho thuê xe
('HDT004', 'DV005', 1), -- Tiền rác
('HDT005', 'DV001', 3), -- Dịch vụ internet
('HDT006', 'DV006', 1), -- Dịch vụ sửa chữa
('HDT007', 'DV007', 1), -- Dịch vụ bảo trì
('HDT008', 'DV002', 1), -- Dịch vụ vệ sinh
('HDT009', 'DV004', 2), -- Dịch vụ cho thuê xe
('HDT010', 'DV001', 1), -- Dịch vụ internet
('HDT011', 'DV005', 1), -- Tiền rác
('HDT012', 'DV006', 1); -- Dịch vụ sửa chữa

delete from HoaDonDichVu
-- Dữ liệu mẫu cho bảng HoaDonTong
-- Dữ liệu mẫu cho bảng HoaDonTong (đã sửa đổi giá tiền phòng)
INSERT INTO HoaDonTong (MaHoaDon, MaPhong, NgayLapHoaDon, TienPhong, MaHoaDonDien, MaHoaDonNuoc) VALUES
('HDT001', 'P002', '2024-10-01', 2800000, 'HDD001', 'HDN001'), -- LP002
('HDT002', 'P004', '2024-10-01', 6000000, 'HDD002', 'HDN002'), -- LP004
('HDT003', 'P005', '2024-10-01', 4000000, 'HDD003', 'HDN003'), -- LP003
('HDT004', 'P008', '2024-10-01', 1500000, 'HDD004', 'HDN004'), -- LP001
('HDT005', 'P010', '2024-10-01', 2800000, 'HDD005', 'HDN005'), -- LP002
('HDT006', 'P012', '2024-10-01', 2800000, 'HDD006', 'HDN006'), -- LP002
('HDT007', 'P015', '2024-10-01', 4000000, 'HDD007', 'HDN007'), -- LP003
('HDT008', 'P018', '2024-10-01', 6000000, 'HDD008', 'HDN008'), -- LP004
('HDT009', 'P019', '2024-10-01', 1500000, 'HDD009', 'HDN009'), -- LP001
('HDT010', 'P021', '2024-10-01', 2800000, 'HDD010', 'HDN010'), -- LP002
('HDT011', 'P027', '2024-10-01', 4000000, 'HDD011', 'HDN011'), -- LP003
('HDT012', 'P029', '2024-10-01', 4000000, 'HDD012', 'HDN012'); -- LP003

