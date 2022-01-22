Create Table Student_Registration
(
sid int primary key identity,
name varchar(50),
phone nvarchar(50),
gender varchar(20),
Email varchar(50),
Password varchar(50),
std_ad_id int foreign key references Tutor_Registration(Id)
);
select * from Student_Registration

create table exams
(
ex_id int primary key identity,
ex_name nvarchar(20) not null,
);

select * from exams

create table questions
(
q_id int primary key identity,
q_title nvarchar(max) not null,
q_opa nvarchar(200) not null,
q_opb nvarchar(200) not null,
q_opc nvarchar(200) not null,
q_opd nvarchar(200) not null,
q_opcorrect nvarchar(200) not null,
q_addeddate nvarchar(20) not null,
q_fk_ad int foreign key references Tutor_Registration(Id),
q_fk int foreign key references exams(ex_id)
);
select * from questions

use master
select * from sys.tables

insert into exams
values('Ms-office')

insert into exams
values('Web Design')

insert into exams
values('Cryptography')

insert into exams
values('Computer Network')

insert into exams
values('C#')

insert into exams
values('CCNA')

insert into exams
values('CEH')

insert into exams
values('C++')

insert into exams
values('Python')

insert into exams
values('flutter')

select * from exams

select * from questions

 


select * from Tutor_Registration
select count(id) from Tutor_Registration where Name='sanjar'
select email from Tutor_Registration where Name ='kabir'

select * from questions

create table Payment_verification
(
  f_id int primary key identity,
  f_name varchar(50) not null,
  f_phone varchar(50) not null,
  fees varchar(50) not null
);
create table Payment_ver
(
  fid int primary key identity,
  fname varchar(50) not null,
  fphone varchar(50) not null,
  f_fees varchar(50) not null
);
select * from Tutor_Registration
select * from Payment_ver

create table Payment_veri
(
  fid int primary key,
  fname varchar(50) not null,
  fphone varchar(50) not null,
  f_fees varchar(50) not null
);
