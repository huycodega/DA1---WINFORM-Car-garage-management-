create database gara_oto
use gara_oto

create table taikhoandn(
taikhoan varchar(20) primary key,
matkhau char(10))
select matkhau from taikhoandn where taikhoan = 'nguyenhuy'
create table khachhang(
id int identity(1,1) primary key,
ten nvarchar(50),
tuoi int, 
gioitinh nvarchar(10),
diachi nvarchar (100),
sdt char(10))

insert into khachhang values(N'Nguyễn Huy',20,'Nam',N'Sơn La','0888500904')
create table xe(
id int identity(1,1) primary key,
ten_xe nvarchar(50),
bienso char(20),
tinh_trang nvarchar(100),
tt_bhx bit,
chu_so_huu nvarchar(50),
id_kh int,
foreign key (id_kh) references khachhang(id))

insert into xe values('BMW','29A-99999',N'TỐt lắm cậu', N'Còn sử dụng', 'Nguyễn Huy',1)

delete from xe where id_kh = 1

select phieu_lap_lich.id, khachhang.id, nhansu.id from phieu_lap_lich inner join khachhang on phieu_lap_lich.id_kh = khachhang.id inner join nhansu on phieu_lap_lich.id_ns = nhansu.id
create table nhansu(
id int identity(1,1) primary key,
hinhanh image,
ten_ns nvarchar(50),
gioi_tinh nvarchar(10),
ngay_sinh datetime,
dc_ns nvarchar(50),
sdt char(10),
chuc_vu nvarchar(50))

create table nhom_pt(
id int identity(1,1) primary key,
ten_nhom nvarchar(50))

create table phutung(
id int identity (1,1) primary key ,
hinhanh image,
ten_pt nvarchar(50),
soluong int,
gia int ,
ngaynhap datetime,
noi_cung_cap nvarchar(50),
tinhtrang nvarchar(100))
insert into phutung values(N'Đánh Lửa Bugin',20,3000,'5/26/2024','Honda','Còn hàng')
select id, ten_pt from phutung where tinhtrang = 'Còn hàng'
select id from phutung where ten_pt= N'Đánh Lửa Bugin'
create table gd_pt(
hinhanh image,
ten_pt nvarchar(50),
soluong int,
gia int ,
ngaynhap datetime,
noi_cung_cap nvarchar(50),
tinhtrang nvarchar(100),
id int ,
foreign key (id) references phutung(id))

create table ct_nhom_pt(
hinhanh image,
ten_pt nvarchar(50),
soluong int,
gia int ,
ngaynhap datetime,
noi_cung_cap nvarchar(50),
tinhtrang nvarchar(100),
id_nhom int ,
id_pt int, 
foreign key(id_pt) references phutung(id),
foreign key (id_nhom) references nhom_pt(id))

create table dichvu(
id int identity(1,1) primary key,
ten_dv nvarchar(50),
gia int )

create table phieu_lap_lich(
id int identity(1,1) primary key,
ten_kh nvarchar(50),
tuoi int,
diachi nvarchar(100),
sdt char(10),
ten_xe nvarchar(50),
bxe char(10),
nguoi_lam_viec nvarchar(50),
dichvu nvarchar(50),
ngay_hen datetime,
tt_thanhtoan nvarchar(50),
id_kh int,
id_ns int,
id_phieu int
foreign key (id_kh) references khachhang(id),
foreign key (id_phieu) references dichvu(id),
foreign key (id_ns) references nhansu(id))

-- đổi hoadon - trong code chi_tiet_hoa_don
create table hoadon(
id int identity primary key,
 ten_kh nvarchar(50),
 ten_xe nvarchar(50),
 bxe char(10),
 dichvu nvarchar(50), 
 soluong_pt int null,
 tong_gia int,
 tt_thanhtoan nvarchar(50),
 ngay datetime,
 id_kh int, 
 foreign key(id_kh) references khachhang(id))

 -- đổi chitiethoadon - code (chitiet_hd_khachhang)
create table chitiethoadon (
ten_pt nvarchar(50),
soluong int,
gia int,
 id_ct int,
  id_pt int,
 foreign key (id_ct) references chi_tiet_hoa_don(id),
 foreign key(id_pt) references phutung(id))

create table hang_da_ban(
ten_pt nvarchar(50),
so_luong int,
gia int,
ngay datetime,
id_pt int,
foreign key (id_pt) references phutung(id))

create table chamcong(
id int identity(1,1) primary key,
thang int null,
nam int, 
ngaytinhcong datetime, 
ngaycongtrongthang float)

create table chitietchamcong(
id_bangcong int,
id_nhanvien int,
hoten nvarchar(50),
d1 nvarchar(10),
d2 nvarchar(10),
d3 nvarchar(10),
d4 nvarchar(10),
d5 nvarchar(10),
d6 nvarchar(10),
d7 nvarchar(10),
d8 nvarchar(10),
d9 nvarchar(10),
d10 nvarchar(10),
d11 nvarchar(10),
d12 nvarchar(10),
d13 nvarchar(10),
d14 nvarchar(10),
d15 nvarchar(10),
d16 nvarchar(10),
d17 nvarchar(10),
d18 nvarchar(10),
d19 nvarchar(10),
d20 nvarchar(10),
d21 nvarchar(10),
d22 nvarchar(10),
d23 nvarchar(10),
d24 nvarchar(10),
d25 nvarchar(10),
d26 nvarchar(10),
d27 nvarchar(10),
d28 nvarchar(10),
d29 nvarchar(10),
d30 nvarchar(10),
ngaycong float, 
ngayphep float, 
tongngaycong float,
foreign key (id_bangcong) references chamcong(id),
foreign key (id_nhanvien) references nhansu(id))

select id from chi_tiet_hoa_don order by(id) desc

 
select chi_tiet_hoa_don.dichvu , COUNT(chi_tiet_hoa_don.dichvu) as 'Dịch vụ được sử dụng nhiều nhất' from chi_tiet_hoa_don
group by MONTH(ngay), chi_tiet_hoa_don.dichvu order by COUNT(chi_tiet_hoa_don.dichvu)



-- Thống kê lợi nhuận theo từng tháng




SELECT TOP 5 hang_da_ban.ten_pt, Sum(hang_da_ban.so_luong) AS 'slhangban', hang_da_ban.gia
FROM hang_da_ban where MONTH(hang_da_ban.ngay) = 4 and YEAR(hang_da_ban.ngay) = 2024
GROUP BY hang_da_ban.ten_pt, hang_da_ban.gia, MONTH(hang_da_ban.ngay), YEAR(hang_da_ban.ngay)
ORDER BY COUNT(*) DESC;

SELECT dichvu, count(chi_tiet_hoa_don.dichvu) AS 'sudung'
FROM chi_tiet_hoa_don where month(ngay) = 5 and YEAR(ngay) = 2024
GROUP BY dichvu,MONTH(ngay), year(ngay);

create PROCEDURE sp_CalculateDoanhThu 
	@Month INT = NULL,
	@Year INT = NULL
AS
BEGIN
    -- Tạo bảng tạm để lưu kết quả tạm thời
    CREATE TABLE #DoanhThuTemp (
        Nam INT,
        Thang INT,
        TongTienBan DECIMAL(18, 2),
        TongTienNhap DECIMAL(18, 2)
    );

    -- Insert dữ liệu tổng tiền bán hàng vào bảng tạm
    INSERT INTO #DoanhThuTemp (Nam, Thang, TongTienBan)
    SELECT 
        YEAR(hang_da_ban.ngay) as Nam,
        MONTH(hang_da_ban.ngay) as Thang,
        SUM(hang_da_ban.so_luong * hang_da_ban.gia) as TongTienBan
    FROM hang_da_ban
        
    GROUP BY 
        YEAR(hang_da_ban.ngay), MONTH(hang_da_ban.ngay);

    -- Insert dữ liệu tổng giá nhập hàng vào bảng tạm, cập nhật các tháng và năm đã có
    MERGE INTO #DoanhThuTemp AS target
    USING (
        SELECT 
            YEAR(gd_pt.ngaynhap) as Nam,
            MONTH(gd_pt.ngaynhap) as Thang,
            SUM(gd_pt.soluong * gd_pt.gia) as TongTienNhap
        FROM gd_pt         
        GROUP BY 
            YEAR(gd_pt.ngaynhap), MONTH(gd_pt.ngaynhap)
    ) AS source
    ON (target.Nam = source.Nam AND target.Thang = source.Thang)
    WHEN MATCHED THEN
        UPDATE SET target.TongTienNhap = source.TongTienNhap
    WHEN NOT MATCHED THEN
        INSERT (Nam, Thang, TongTienNhap)
        VALUES (source.Nam, source.Thang, source.TongTienNhap);
    -- Trả về kết quả doanh thu
    SELECT 
        Nam, 
        Thang, 
		ISNULL(TongTienBan, 0) as TongTienBan,
		ISNULL(TongTienNhap, 0) as TongTienNhap,
        ISNULL(TongTienBan, 0) - ISNULL(TongTienNhap, 0) AS DoanhThu
    FROM 
        #DoanhThuTemp
	WHERE 
        (@Year IS NULL OR Nam = @Year)
        AND (@Month IS NULL OR Thang = @Month)
    ORDER BY 
        Nam, Thang;

    -- Xóa bảng tạm
    DROP TABLE #DoanhThuTemp;
END
EXEC sp_CalculateDoanhThu @Year = 2024


