create database Day14Db

use Day14Db
create table Emps
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50),
Salary float,
DOJ date )

insert into Emps values (1,'Sam','Dicsota',98000.5,'12/23/2019')
insert into Emps values (2,'Raj','Kumar',98000.5,'11/09/2021')
insert into Emps values (3,'ravi','Garg',98000.5,'11/23/2020')

create proc usp_sEmps
as
begin
select * from Emps
end

exec usp_sEmps

----

create proc usp_searchEmp
@id int
as
begin
select * from Emps where Id=@id
end

execute usp_searchEmp 1 

---

create proc updateEmp1
@id int,
@fn nvarchar(50),
@ln nvarchar(50),
@sal float,
@doj date

as
begin
update Emps set Fname=@fn, Lname=@ln,Salary=@sal,Doj=@doj where Id=@id
if(@@ROWCOUNT>=1)
print 'Record Updated'
end

execute updateEmp1 13, 'Aman','Gupta',76000,'12/12/20007'
execute usp_sEmps


alter proc day14d
@id int = 13
as
begin
delete from Emps
where id=@id 
end
exec day14d 

