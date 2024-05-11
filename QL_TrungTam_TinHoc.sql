create database QL_TT_TinHoc
go
use QL_TT_TinHoc
go


CREATE TABLE Roles
(
    IdRole INT PRIMARY KEY IDENTITY(1,1),
    TenRole NVARCHAR(255)
);

CREATE TABLE NhanVien
(
    IdNV INT PRIMARY KEY IDENTITY(1,1),
	HoTen Nvarchar(255),
	GioiTinh nvarchar(255),
	DiaChi nvarchar(255),
	MucLuong int,
    tk NVARCHAR(255) ,
    mk NVARCHAR(255) ,
    IdRole INT FOREIGN KEY REFERENCES Roles(IdRole)
);

CREATE TABLE ADMIN
(
    IdADMIN INT PRIMARY KEY IDENTITY(1,1),
    tk NVARCHAR(255) ,
    mk NVARCHAR(255) ,
    IdRole INT FOREIGN KEY REFERENCES Roles(IdRole)
);

CREATE TABLE HocVien (
    MaHocVien INT PRIMARY KEY,
    HoTen NVARCHAR(255),
    Tuoi INT,
    GioiTinh NVARCHAR(10),
    Email NVARCHAR(255),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

CREATE TABLE GiangVien (
    MaGiangVien INT PRIMARY KEY,
    HoTen NVARCHAR(255),
    Email NVARCHAR(255),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

CREATE TABLE PhongHoc (
    MaPhong INT PRIMARY KEY,
    TenPhong NVARCHAR(255),
    SucChua INT
);

CREATE TABLE KhoaHoc (
    MaKhoaHoc INT PRIMARY KEY,
    TenKhoaHoc NVARCHAR(255),
    MoTa TEXT,
	GiaKh int,
);

CREATE TABLE LopHoc (
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(255),
    MaPhong INT,
    MaGiangVien INT,
    MaKhoaHoc INT,
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong),
    FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien),
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
);

create table CaLam(
	  IdCaLam INT PRIMARY KEY IDENTITY(1,1),
	  IdNV int,
	  caLam nvarchar(255),
	  FOREIGN KEY (IdNV) REFERENCES NhanVien(IdNV)
)

create table DKKhoaHoc
(
	IdDK INT PRIMARY KEY IDENTITY(1,1),
	MaKhoaHoc INT,
	MaHocVien INT,
	Ngaydk datetime,
	FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc),
	FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
)


INSERT INTO Roles( TenRole) Values ('Admin'), ('NV');

INSERT INTO NhanVien (HoTen, GioiTinh, DiaChi, MucLuong, tk, mk, IdRole) VALUES
(N'Nguyễn Văn A', N'Nam', N'Hà Nội', 5000000, N'nv01', N'123', 2),
(N'Trần Thị B', N'Nữ', N'Hồ Chí Minh', 6000000, N'nv02', N'123', 2),
(N'Lê Văn C', N'Nam', N'Đà Nẵng', 5500000, N'nv_c', N'matkhau789', 2),
(N'Phạm Thị D', N'Nữ', N'Hải Phòng', 4500000, N'nv_d', N'matkhauabc', 2),
(N'Hoàng Văn E', N'Nam', N'Cần Thơ', 7000000, N'nv_e', N'matkhauxyz', 2);

INSERT INTO ADMIN (tk, mk, IdRole) VALUES (N'admin', N'123', 1);

INSERT INTO HocVien (MaHocVien, HoTen, Tuoi, GioiTinh, Email, DienThoai, DiaChi) VALUES
(1, N'Nguyễn Văn A', 20, N'Nam', N'nguyenvana@example.com', N'123456789', N'Hà Nội'),
(2, N'Trần Thị B', 22, N'Nữ', N'tranthib@example.com', N'987654321', N'Hồ Chí Minh'),
(3, N'Lê Văn C', 25, N'Nam', N'levanc@example.com', N'456789123', N'Đà Nẵng'),
(4, N'Phạm Thị D', 21, N'Nữ', N'phamthid@example.com', N'654321987', N'Hải Phòng'),
(5, N'Hoàng Văn E', 23, N'Nam', N'hoangvane@example.com', N'321654987', N'Cần Thơ');

INSERT INTO GiangVien (MaGiangVien, HoTen, Email, DienThoai, DiaChi) VALUES
(1, N'Nguyễn Thị X', N'nguyenthix@example.com', N'111111111', N'Hà Nội'),
(2, N'Trần Văn Y', N'tranvany@example.com', N'222222222', N'Hồ Chí Minh'),
(3, N'Lê Thị Z', N'lethiz@example.com', N'333333333', N'Đà Nẵng'),
(4, N'Phạm Văn K', N'phamvank@example.com', N'444444444', N'Hải Phòng'),
(5, N'Hoàng Thị L', N'hoangthil@example.com', N'555555555', N'Cần Thơ');

INSERT INTO PhongHoc (MaPhong, TenPhong, SucChua) VALUES
(1, N'Phòng 101', 30),
(2, N'Phòng 201', 25),
(3, N'Phòng 301', 20),
(4, N'Phòng 102', 35),
(5, N'Phòng 202', 28);


INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc, MoTa) VALUES
(1, N'Khóa học SQL căn bản', N'Học về cú pháp và các câu lệnh SQL căn bản.'),
(2, N'Khóa học PHP nâng cao', N'Học về lập trình PHP và phát triển ứng dụng web.'),
(3, N'Khóa học Python cơ bản', N'Học về cú pháp và các khái niệm cơ bản trong ngôn ngữ Python.'),
(4, N'Khóa học Thiết kế đồ họa', N'Học về các phần mềm thiết kế đồ họa và kỹ năng thiết kế.'),
(5, N'Khóa học Digital Marketing', N'Học về các chiến lược và kỹ năng quảng cáo trực tuyến.');


INSERT INTO LopHoc (MaLop, TenLop, MaPhong, MaGiangVien, MaKhoaHoc) VALUES
(1, N'Lớp A', 1, 1, 1),
(2, N'Lớp B', 2, 2, 2),
(3, N'Lớp C', 3, 3, 1),
(4, N'Lớp D', 1, 2, 3),
(5, N'Lớp E', 2, 3, 2);