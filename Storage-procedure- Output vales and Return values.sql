CREATE TABLE Car(
CarID INT,
CarName VARCHAR(100));

INSERT INTO Car VALUES (101,'Mercedes-Benz');

INSERT INTO Car VALUES (201,'BMW');

INSERT INTO Car VALUES (301,'Ferrari');

INSERT INTO Car VALUES (401,'Lamborghini');

INSERT INTO Car VALUES (501,'Porsche');
SELECT * FROM Car;

INSERT INTO Car (Carlocation) VALUES ('TL') where CarID= 101;
ALTER TABLE Car
ADD Carlocation varchar(255);

ALTER TABLE Car
DROP COLUMN Carlocation;

update Car set Carlocation='KL' WHERE CarID=501;

SELECT * FROM Car WHERE  CarID IS NOT NULL;

CREATE TABLE Employee( EmpId int not null ,Empname varchar(255) not null, Gender varchar(255), DepartId int);
SELECT * from Employee;

INSERT INTO Employee VALUES (1012,'Arun','Male',1243);
INSERT INTO Employee VALUES (1032,'Sheela','Female',2535);
INSERT INTO Employee VALUES (1012,'Ajai','Male',1255);
INSERT INTO Employee VALUES (1032,'Satya','Female',2746);











-------------------------------------------------------------
CREATE PROCEDURE getMalecount 
@Gender VARCHAR(20),
@Empcount int OUTPUT
as 
BEGIN
SELECT @Empcount= COUNT(EmpId) from Employee WHERE Gender=@Gender END 
-------------------------------------------------------------------

DECLARE @Count INT
EXECUTE  getMalecount 'Male', @Count OUTPUT
PRINT @Count
------------------------------------------------------------














CREATE PROCEDURE getfemalecount
@totcount int OUTPUT
as
BEGIN
SELECT @totcount=COUNT(EmpId) from Employee WHERE Gender='Female'
END
--------------------------------------------------------------
DECLARE @totfemcount INT
EXECUTE getfemalecount  @totfemcount OUTPUT
SELECT @totfemcount


 