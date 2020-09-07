create database MyCompany
go
use MyCompany
go
create table Employee(
IdPK int identity(1,1) primary key, 
IdNumber varchar (10) unique not null,
Name nvarchar(80) not null,
Mail nvarchar(150)not null,
Birthday date not null 
)
insert into Employee values ('6587542361','Juan Gabriel','Juan@gmail.com','24/05/2000')
insert into Employee values ('6587542362','Gonazalo','Gonazalo@gmail.com','24/05/2000')
insert into Employee values ('6587542363','Marta','Marta@gmail.com','24/05/2000')
insert into Employee values ('6587542364','Lisandro','Lisandro@gmail.com','24/05/2000')
insert into Employee values ('6587542365','Anna Maria','Anna@gmail.com','24/05/2000')

select *from Employee


