select * from Staff
select * from Salary
select upper(Fname) from Staff
select lower(Fname) from Staf

select ltrim ('         India         ')
select rtrim ('         India         ')
select trim ('         India         ')
select LOWER ('India')
select Upper ('India')

select Id, Fname, Lname, Designation, Salary from Staff
select left(Fname,1) from Staff

select Id, left(Fname,1)+'.'+ left(Lname,1) +'.' as 'Initial', Fname,Lname, Salary from Staff
select Fname +'->' +Lname+ '->' + Designation as 'First Name -> Last Name -> Designation -> Id 'from Staff


select getdate() as Today

select DATEPART (DAY, getdate()) 'Date'
select DATEPART (MONTH, getdate())'Month'
select DATEPART(YEAR,getdate()) 'year'

select DATEDIFF(year,'12/12/2019','12/10/2022')
select DATEDIFF(MONTH,'12/12/2019','12/10/2022')
select DATEDIFF(DAY,'12/12/2019','12/10/2022')
