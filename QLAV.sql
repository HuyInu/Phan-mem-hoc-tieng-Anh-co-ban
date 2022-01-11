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
create table BAITAPNP
(
	MaBTNP char(5) not null,
	MaNP char(10) not null,
	Cauhoi nvarchar(2000),
	A nvarchar(2000),
	B nvarchar(2000),
	C nvarchar(2000),
	Dapan char(1),
	constraint pk_MaBTNP primary key(MaBTNP)
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
create table Thongke
(
	MaBH char(10) not null,
	MaNH char(10) not null,	
	Tongdung int,
	Tongsai int,
	Solanhoc int,
)
create table AVATAR
(
	MaAT smallint not null,
	Anh image,
)
create table TKEMONTH
(
	MaNH char(10) not null, 
	SL int,
	THANG smallint,
	NAM int
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
ALTER TABLE BAITAPNP  ADD CONSTRAINT FK01_BTNP FOREIGN KEY(MaBH) REFERENCES BAIHOC(MaBH) on delete cascade
ALTER TABLE BAITAPNP DROP CONSTRAINT FK01_BTNP
ALTER TABLE Thongke  ADD CONSTRAINT FK01_TK FOREIGN KEY(MaBH) REFERENCES BAIHOC(MaBH) on delete cascade
ALTER TABLE Thongke  ADD CONSTRAINT FK02_TK FOREIGN KEY(MaNH) REFERENCES NGUOIHOC(MaNH) on delete cascade

ALTER TABLE TKEWEEK  ADD CONSTRAINT FK01_WEE FOREIGN KEY(MaNH) REFERENCES NGUOIHOC(MaNH) on delete cascade

ALTER TABLE TKEMONTH  ADD CONSTRAINT FK01_MOO FOREIGN KEY(MaNH) REFERENCES NGUOIHOC(MaNH) on delete cascade

select MaLOAI,Tenloai from LOAITV
select *from BAIHOC
select * from TUVUNG
select * from NGUPHAP
select * from NGUOIHOC
select * from HOC
select * from BAITAPNP
select * from thongke

delete  from NGUOIHOC where MaNH='3'
delete from HOC
delete from THONGKE
insert into LOAITV values('V',N'Động từ')
insert into LOAITV values('N',N'Danh từ')
insert into LOAITV values('ADJ',N'Tính từ')
insert into LOAITV values('ADV',N'Trạng từ')


insert into HOC values('0001','0001','0');

ALTER TABLE BAITAPNP ADD MABH char(10)
ALTER TABLE HOC ALTER COLUMN FNP tinyint
ALTER TABLE NGUOIDUNG DROP COLUMN LV

insert into Thongke values('0002','0001','10','25','3')
select * from Thongke
select Sum(Tongdung) as 'SR',Sum(Tongsai) as 'SF',Sum(Solanhoc) as 'SL' from Thongke where MaNH='0001'

insert into DEFAULTAVATAR(MaAT,Anh) 
SELECT '1',BulkColumn 
FROM Openrowset( Bulk 'C:\Users\ACER\Downloads\ava.jpg', Single_Blob) as img

delete from DEFAULTAVATAR
select * from DEFAULTAVATAR
select Ava from NGUOIHOC
update NGUOIHOC set Ava= (SELECT BulkColumn FROM Openrowset( Bulk 'C:\Users\ACER\Downloads\TV.png', Single_Blob) as img) where MaNH='0001'

insert into NGUOIHOC values('0006','hee','sdfsdf','aaa','bbbbb',(select Anh from DEFAULTAVATAR))
update NGUOIHOC set Ava=(select Anh from DEFAULTAVATAR) where MaNH='0001'

select Sum(SL),TUAN,DAY(StartW) as 'staW',convert(varchar,EndW,3) as 'endW',NAM from TKEWEEK  where TUAN='46' and NAM='2021' group by TUAN,StartW,endW,NAM

select SUM(SL),THANG from TKEMONTH where THANG='12' and NAM='2021' group by THANG

select MaNH,SUM(SL) from TKEMONTH where NAM='2021' group by MaNH

select N.MaNH as 'Mã NH',N.Name as 'Tên',W.SL as 'Tổng trong tuần',M.SL as 'Tổng  tháng',SUM(M.SL) as 'Tổng trong năm' from NGUOIHOC N,TKEWEEK W,TKEMONTH M where N.MaNH=W.MaNH and W.MaNH=M.MaNH and W.TUAN='51' and M.THANG='12' and M.NAM='2021' group by N.MaNH,N.Name,W.SL,M.SL

select * from TKEWEEK where TUAN='50'
 select N.MaNH,N.Name,W.SL,W.TUAN,W.NAM from NGUOIHOC N left join (select * from TKEWEEK where TUAN='50') W on N.MaNH=W.MaNH where W.TUAN='50' or W.TUAN is null

select N.MaNH,N.Name,W.SL,W.TUAN,W.NAM from NGUOIHOC N left join TKEWEEK W on N.MaNH=W.MaNH where W.TUAN='51' and W.NAM='2021' or W.TUAN is null and W.NAM is null
select N.MaNH,N.Name,M.SL,sum(M.SL) from NGUOIHOC N left join TKEMONTH M on N.MaNH=M.MaNH where  M.NAM='2021' and M.THANG='11' or M.NAM is null  and M.THANG is null group by n.MaNH,n.Name,m.SL



select a.MaNH,a.Name,isnull(a.SLW,0) as 'Tổng trong tuần',isnull(a.SLM,0) as 'Tổng trong tháng',isnull(c.TM,0) as 'Tổng tong năm' from (select aa.MaNH,aa.Name,aa.SL as 'SLW',bb.SL as 'SLM' from 
(select N.MaNH,N.Name,W.SL from NGUOIHOC N left join (select MaNH,SL from TKEWEEK where TUAN='2' and NAM='2022') W on N.MaNH=W.MaNH ) aa 
left join (select MaNH,SL,THANG,NAM from  TKEMONTH where THANG='1' and NAM='2022') bb on aa.MaNH=bb.MaNH ) a
left join (select M.MaNH,SUM(M.SL) as 'TM' from TKEMONTH M where NAM='2022' group by MaNH) c on c.MaNH=a.MaNH

select * from TKEMONTH where THANG='1' and NAM='2022' and MaNH='0004'
select TUAN,NAM from TKEWEEK where TUAN='2' and NAM='2022' and MaNH='0004'

update TKEWEEK set SL=SL+1 where TUAN='48' and NAM='2021'

select top (10) N.MaNH from NGUOIHOC N,TKEWEEK  where TUAN=51 and NAM=2021 order by SL desc

select P.TenNP,H.MaBH,H.TenBH from NGUPHAP P,BAIHOC H where P.MaBH=H.MaBH and TenNP like '%b%'

select SUM(SL) from TKEWEEK where TUAN='2' and NAM='2022'