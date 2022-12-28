create table Empdetails (EmployeeID int primary key, salary int, Address1 varchar(255), Address2 varchar(255),City varchar(255),State varchar(255), Country varchar(255))
INSERT into Empdetails  VALUES (1246, 50000,'kedayam street','varana', 'Chennai', 'TamilNadu','India')
INSERT into Empdetails values (1288,65000,'bharathi street','cheppakam', 'Chennai','TamilNadu','India')
INSERT into Empdetails values (1273,45000,'vahman street','hiji', 'binglu','Andra pradesh','India')
INSERT into Empdetails  values (1942,56000,'blue street','alaphula', 'vigo','Kerala','India')
INSERT into Empdetails  values (1743,28000,'denmark street','refree', 'Saleem','TamilNadu','India')
select * from Empdetails









CREATE table Employee (ID int FOREIGN key references Empdetails(EmployeeID),FirstName varchar(255),LastName varchar(255), SSN int unique not null,DeptID int not null)
insert into Employee values(1246, 'john','selengs',9475846,773)
insert into Employee values(1288, 'Isebella','zelensky',9473646,323)
insert into Employee values(1273, 'john','carter',1224553,624)
insert into Employee values(1942, 'joe','vegan',9955253,325)
insert into Employee values(1743, 'kim','thomson',3648441,173)

select * from Employee





CREATE table Department ( ID int references Employee(ID), Name varchar(255), Location varchar(255))
insert into Department values(1246,'Mechanical','Chennai')
INSERT into Department values (1288,'Finance','Chennai')
INSERT into Department values (1273,'Marketing', 'binglu')
INSERT into Department values (1942, 'Engineer','vigo')
INSERT into Department values (1743,'Marketing','refree')
drop table Department;

select * from Department





insert into Employee values(1357 , 'Tina','Smith',5574181,578)

select COUNT(ID) as 'Total employees' from Employee 


SELECT COUNT(ID),Name as 'Total employees' from Department GROUP BY Name