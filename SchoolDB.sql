Drop Database School
GO

Create Database School
GO

Create Table HocVien(
MaHV int PRIMARY KEY IDENTITY(1,1),
TenHV varchar(25),
Lop varchar(5)
);

Create Table MonHoc (
MaMH int PRIMARY KEY IDENTITY(1,1),
TenMH varchar(225)
);

Create Table BangDiem(
MaHP int PRIMARY KEY IDENTITY(1,1),
MaHV int,
MaMH int,
Diem float,
HeSo int,
Namhoc int,
CONSTRAINT FK_MaHV FOREIGN KEY (MaHV)
    REFERENCES HocVien(MaHV),
CONSTRAINT FK_MaMH FOREIGN KEY (MaMH)
    REFERENCES MonHoc(MaMH)
);


