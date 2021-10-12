create DATABASE QLAV
go
use QLAV
go
create table NGUOIHOC(
	MaNH int not null,
	Name varchar(20),
	TK varchar(10),
	MK varchar(10),
	LV smallint,
	KN smallint,
	constraint pk_MaNH primary key(MaNH)
)
create table BAIHOC(
	MaBH int not null,
	TenBH varchar(10),
	constraint pk_MaBH primary key(MaBH)
)
create table HOC(
	MaBH int not null,
	MaNH int not null,
	constraint pk_HOC primary key(MaNH,MaBH) 
)
create table TUVUNG(
	MaTV char(10) not null,
	MaBH int not null,
	Noidung varchar(20),
	Loai char(5)
	constraint pk_TUVUNG primary key(MaTV) 
)
create table NGUPHAP(
	MaNP int not null,
	MaBH int not null,
	Noidung varchar(50),
	constraint pk_NGUPHAP primary key(MaNP) 
)
create table CAUHOI(
	MaCH char(5) not null,
	Noidung varchar(100) not null,
	Loai char(5),
	A varchar(10),
	B varchar(10),
	C varchar(10),
	Dapan char(1),
	constraint pk_CAUHOI primary key(MaCH) 
)
create table KIEMTRA(
	MaCH char(1) not null,
	MaNH int not null,
	constraint pk_KIEMTRA primary key(MaCH,MaNH) 
)
ALTER TABLE TUVUNG ADD CONSTRAINT FK01_TV FOREIGN KEY(MaBH) REFERENCES BAIHOC(MaBH)
ALTER TABLE TUVUNG DROP CONSTRAINT FK01_TV

ALTER TABLE NGUPHAP ADD CONSTRAINT FK01_NP FOREIGN KEY(MaBH) REFERENCES BAIHOC(MaBH)
ALTER TABLE NGUPHAP DROP CONSTRAINT FK01_NP
select * from NGUOIHOC