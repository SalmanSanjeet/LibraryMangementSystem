create table Profile_Master
(
Pro_User_Id varchar(50) primary key,
Pro_Name varchar(100),
Pro_Email varchar(150),
Pro_Mobile varchar(50),
Pro_Password varchar(50),
Pro_Address varchar(250),
Pro_Role varchar(50),
Pro_Status varchar(50)
);

create table Role_Master
(
Role_Id varchar(50) primary key,
Role varchar(50),
Role_Status varchar(50)
);

create table Member_Master
(
Mem_Id varchar(50) primary key,
Mem_Name varchar(150),
Mem_Email varchar(150),
Mem_Mobile varchar(50),
Mem_Address varchar(250),
Mem_Dob datetime,
Mem_Doj datetime,
Plan_Id varchar(50),
Mem_Status varchar(50)
);

create table Plan_Master
(
Plan_Id varchar(50) primary key,
Plan_Name varchar(50),
Plan_Doc datetime,
Plan_Book_Limit int,
Plan_Book_Hold int,
Plan_Validity int,
Plan_Amount float,
Plan_Dis float,
Plan_Status varchar(50)
);

create table Book_Master
(
Book_Id varchar(50) primary key,
Book_Name varchar(100),
Book_Auth varchar(50),
Book_Edition int,
Book_Pages int,
Book_Publish int,
Sr_Id int,
Book_Status varbinary(50)
);

create table Section_Master
(
Sec_Id int primary key,
Sec_Name varchar(50),
Sec_Status varchar(50)
);

create table Rack_Master
(
Rack_Id int primary key,
Rack_Name varchar(50),
Rack_Status varchar(50)
);

create table Sec_Roc_Map
(
Sr_Id int,
Sec_Id int,
Rack_Id int,
Sr_Print int,
Sr_Status varchar(50),
Constraint
foreign key (Sec_Id) references Section_Master(Sec_Id),
foreign key (Rack_Id) references Rack_Master(Rack_Id),
primary key (Sr_Id, Sec_Id, Rack_Id)
);

create table Purchase_Main
(
Pur_Id varchar(50) primary key,
Pur_Date datetime,
Pur_From varchar(50),
Pur_Amount float,
Pur_Status varbinary(50)
);

create table Purchase_Sub
(
Pur_Id varchar(50) primary key,
Pur_Date datetime,
Pur_No int,
Book_Id varchar(50),
Book_Name varchar(150),
Qty int,
Rate float,
Amount float,
Status varbinary(10),
foreign key(Pur_Id) references Purchase_Main(Pur_Id),
foreign key(Book_Id) references Book_Master(Book_Id)
);

create table Stocks 
(
Book_Id varchar(50) primary key,
Book_Name varchar(150),
Qty int,
s_status varchar(50),
foreign key(Book_Id) references Book_Master(Book_Id)
);

create table Mem_Transaction
(
Trans_Id int,
Trans_Date datetime,
Mem_Id varchar(50),
Mem_Name varchar(50),
Amount float,
Fine float,
Type varchar(50),
Status varbinary(50)
);

create table Book_Register_Main
(
Reg_Id int primary key,
Reg_Date datetime,
Mem_Id varchar(50),
Reg_Status varchar(50),
foreign key(Mem_Id) references Member_Master(Mem_Id)
);

create table Book_Register_Sub
(
Reg_Id int primary key,
Reg_Date datetime,
Mem_Id varchar(50),
Brs_No int,
Book_Id varchar(50),
Br_Out_Date datetime,
Br_In_Date datetime,
Br_Qty int,
Br_Fine float,
Br_Status varbinary(50),
foreign key(Mem_Id) references Member_Master(Mem_Id),
foreign key(Book_Id) references Book_Master(Book_Id)
);


insert into profile_master(pro_user_id, pro_name, pro_email, pro_mobile, pro_password, pro_address, pro_role, pro_status)
values ('admin', 'Admin', 'aa@gmail.com', '', 'pass', '', 'Admin', 'Actprofile_masterive');

select * from profile_master;

insert into role_master(role_id, role, role_status)
values ('BK00001', 'Math Book', 'Inactive');





-- Stored Procedure for 'New Role'

drop procedure if exists Proc_New_Role;
delimiter $$
create procedure Proc_New_Role()
begin
	select @MaxNum := ifnull(max(right(role_id, 5) * 1), 0) + 1 as 'MaxNo' from role_master;
    select CONCAT('BK', right(concat('00000', cast(@MaxNum as CHAR)), 5)) as 'RoleID';
end $$
delimiter ;
call Proc_New_Role();

select * from role_master;














