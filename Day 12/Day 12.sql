create database OurDb
--- create database DatabaseName
use OurDb 

-- create table tablename
--(ColumnName Datatype Constraint

create table Emp
(Id int primary key,
Name nvarchar(50) not null,
Salary float,
DOJ datetime)

insert into Emp values (1,'Ayush',98000.90,'12/12/2000')

insert into Emp (Id,Name,Salary) values (2,' Ay', 38000.90)

select * from Emp