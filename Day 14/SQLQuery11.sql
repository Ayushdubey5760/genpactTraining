create database StaffDbb

use StaffDb
create table Dept
(DId int primary key,
DName nvarchar(50) not null unique)
insert into Dept values (1,'App-Development')
insert into Dept values (2,'Web-Development')
insert into Dept values (3,'Agile-Scrum')
insert into Dept values (4,'App-HRM')
create table Staff
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50),
Designation nvarchar(50)check
(Designation in ('Developer','Manager','Tester','Designer','CTO','CFO','Other')),
Salary decimal(8,2),
Department int foreign key references Dept(DId)
)
insert into Staff values
(12,'Deep','Singh','Developer',96000.45,1),
(2,'Vipin','T.N.R','CTO',96000.45,1),
(3,'Disha','M','Manager',96000.45,1),
(4,'Gagan','Kapoor','Manager',96000.45,1),
(5,'Vibha','J.J>','Developer',96000.45,1),
(9,'Arun','N','Developer',96000.45,1),
(11,'Vishal','M','Tester',96000.45,1)

select * from Dept join Staff on Dept.DId=Staff.Department
where Staff.Department=2

create proc usp