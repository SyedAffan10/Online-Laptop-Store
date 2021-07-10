create database Online_Store;
create table user_info
(
   info_id int primary key identity(1,1),
   name varchar(50),
   phone_no varchar(20),
   addreess varchar(150),
   email varchar(100)
);
insert into user_info (name,phone_no,addreess,email) values ('ikrama','03211234567','karachi','ikrama123@gmail.com');
select * from user_info;
create table useradmin
(
   admin_name varchar(50),
   pw varchar(50)
);
insert into useradmin (admin_name,pw) values ('asad','123');
insert into useradmin (admin_name,pw) values ('affan','123');
insert into useradmin (admin_name,pw) values ('shehroz','123');
insert into useradmin (admin_name,pw) values ('khizar','123');
select * from useradmin;
alter table useradmin add admin_id int primary key identity(1,1);