create DATABASE QLAV
go
use QLAV
go
create table NGUOIHOC
(
	MaNH char(10) not null,	
	Name nvarchar(20),
	Email varchar(100),
	TK varchar (50),
	MK varchar(50),
	LV smallint,
	KN smallint,
	constraint pk_MaNH primary key(MaNH)
)
create table DIEM
(
	MaDIEM char(10) not null,
	MaNH char(10) not null,
	Thoigian time,
	constraint pk_MaDIEM primary key(MaDIEM)
)
create table BAIHOC
(
	MaBH char(10) not null,
	TenBH nvarchar(30),
	constraint pk_MaBH primary key(MaBH)
)
create table HOC
(
	MaBH char(10) not null,
	MaNH char(10) not null,
	Tiendo smallint,
	constraint pk_HOC primary key(MaBH,MaNH)
)
create table TUVUNG
(
	MaTV char(10) not null,
	MaBH char(10) not null,
	MaLOAI char(5) not null,
	Angu varchar(20),
	Vngu nvarchar(20),
	constraint pk_TUVUNG primary key(MaTV)
)
create table LOAITV
(
	MaLOAI char(5) not null,
	Tenloai nvarchar(30),
	constraint pk_MaLOAI primary key(MaLOAI)
)
create table NGUPHAP
(
	MaNP char(10) not null,
	MaBH char(10) not null,
	Noidung nvarchar(100),
	Chuthich nvarchar(100),
	constraint pk_MaNP primary key(MaNP)
)
create table CAUHOI
(
	MaCH char(5) not null,
	MaLOAICH char(10) not null,
	Noidung varchar(100),
	A varchar(100),
	B varchar(100),
	C varchar(100),
	Dapan varchar(100),
	constraint pk_MaCH primary key(MaCH)
)
create table KIEMTRA
(
	MaNH char(10) not null,
	MaCH char(10) not null,
	constraint pk_KIEMTRA primary key(MaNH,MaCH)
)
create table LOAICH
(
	MaLOAICH char(10) not null,
	Tenloai varchar(50),
	constraint pk_MaLOAICH primary key(MaLOAICH)
)



ALTER TABLE LOAICH
ADD CONSTRAINT pk_MaLOAICH PRIMARY KEY (MaLOAICH);



ALTER TABLE DIEM  ADD CONSTRAINT FK01_D FOREIGN KEY(MaNH) REFERENCES NGUOIHOC(MaNH) on delete cascade
/*ALTER TABLE DIEM DROP CONSTRAINT FK01_D*/
ALTER TABLE TUVUNG  ADD CONSTRAINT FK01_TV FOREIGN KEY(MaBH) REFERENCES BAIHOC(MaBH) on delete cascade
/*ALTER TABLE TUVUNG DROP CONSTRAINT FK01_TV*/
ALTER TABLE TUVUNG  ADD CONSTRAINT FK02_TV FOREIGN KEY(MaLOAI) REFERENCES LOAITV(MaLOAI) on delete cascade
/*ALTER TABLE TUVUNG DROP CONSTRAINT FK02_TV*/
ALTER TABLE NGUPHAP  ADD CONSTRAINT FK01_NP FOREIGN KEY(MaBH) REFERENCES BAIHOC(MaBH) on delete cascade
/*ALTER TABLE NGUPHAP DROP CONSTRAINT FK01_NP*/
ALTER TABLE CAUHOI  ADD CONSTRAINT FK01_CH FOREIGN KEY(MaLOAICH) REFERENCES LOAICH(MaLOAICH) on delete cascade
/*ALTER TABLE CAUHOI DROP CONSTRAINT FK01_CH*/

select * from BAIHOC where MaBH=cast(MaBH as varchar)

select MaLOAI,Tenloai from LOAITV
select *from BAIHOC
select * from TUVUNG

delete  from BAIHOC

ALTER TABLE TUVUNG ADD Phienam nvarchar(50)

insert into LOAITV values('V',N'Động từ')
insert into LOAITV values('N',N'Danh từ')
insert into LOAITV values('ADJ',N'Tính từ')
insert into LOAITV values('ADV',N'Trạng từ')


insert into TUVUNG values('1B1','1','V','run',N'chạy')


ALTER TABLE BAIHOC ALTER COLUMN TenBH nvarchar(30)

select * from NGUOIHOC

select * from TUVUNG where Angu='Good' Except select * from TUVUNG where MaTV='1BV0001'