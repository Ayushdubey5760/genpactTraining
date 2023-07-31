create database Day13

use Day13

create table CompanyInfo(CId int primary key,CName nvarchar(50) not null,)

insert into CompanyInfo values (1,'Samsung')
insert into CompanyInfo values (2,'HP')
insert into CompanyInfo values (3,'Apple')
insert into CompanyInfo values (4,'Dell')
insert into CompanyInfo values (5,'Toshiba')
insert into CompanyInfo values (6,'Redmi')

create table ProductInfo (PId int primary key,
PName  nvarchar(50) not null,
Pprice int,
PMDate datetime,
CId int not null,
foreign key (CId) references CompanyInfo(CId)
)
insert into ProductInfo(Pid, Pname, CId) values (101, 'Laptop',1)
insert into ProductInfo(Pid, Pname, CId) values (102, 'Laptop',1)
insert into ProductInfo(Pid, Pname, CId) values (103, 'Mobile',1)
insert into ProductInfo(Pid, Pname, CId) values (104, 'Laptop',1)
insert into ProductInfo(Pid, Pname, CId) values (105, 'Mobile',1)
insert into ProductInfo(Pid, Pname, CId) values (106, 'Laptop',1)
insert into ProductInfo(Pid, Pname, CId) values (107, 'Mobile',1)
insert into ProductInfo(Pid, Pname, CId) values (108, 'Earpod',1)
insert into ProductInfo(Pid, Pname, CId) values (109, 'Laptop',1)
insert into ProductInfo(Pid, Pname, CId) values (110, 'Mobile',1)

select CompanyInfo.Cname , ProductInfo.Pid , ProductInfo.Pname, Pname,ProductInfo.CId from CompanyInfo  join ProductInfo on CompanyInfo.CId = ProductInfo.CId
select ProductInfo.Pname, CompanyInfo.CName from CompanyInfo  join ProductInfo on CompanyInfo.CId= ProductInfo.CId
