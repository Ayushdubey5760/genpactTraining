create database ExerciseDbDay16
use ExerciseDbDay16
create table Student 
(
Sid integer primary key,
SName varchar(30),
SEmail varchar(50),
SContact varchar(10)
);

insert into Student (Sid, SName, SEmail, SContact) 
values
(1, 'Sid' , 'sid@gmail.com' , '111'),
(2, 'John' , 'john@gmail.com' , '222'),
(3, 'Jes' , 'jes@gmail.com' , '333');

create table Fee
(
Sid int foreign key references Student(Sid),
Sfee decimal(6,2),
SMonth int,
SYear int,
Primary Key (Sid, SMonth, SYear),
);
create table PayConfirmation
(
Sid int,
Name varchar(30),
Email varchar(50),
Fee decimal(6,2),
PaidOnDate Date
);
create trigger trgFeePayConfirmation
on Fee
after insert
as
declare @id int
declare @SFees  decimal(6,2)
declare @name varchar(30)
declare @email varchar(50)
select @id = Sid from inserted
select @SFees = Sfee from inserted
begin
select @name = SName , @email = SEMail from Student where Sid = @id
insert into PayConfirmation values(@id ,@name,@email,@SFees,GETDATE())
print 'Pay Confirmation Table Updated'
end
