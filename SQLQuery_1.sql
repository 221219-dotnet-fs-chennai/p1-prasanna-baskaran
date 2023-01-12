CREATE table Student ( name varchar(255),Rollno varchar(255),age int,phoneno varchar(10),deptname varchar(255))
INSERT into Student VALUES('Surendar','12217urpdf',21,'5241789635','Mechanical')
INSERT into Student VALUES('Surep','1221734df',23,'5241789635','EcE')
INSERT into Student VALUES('Supradar','12266df',22,'5241789635','Engineer')
INSERT into Student VALUES('pradar','12217urp53f',22,'5241789635','Mechanical')
INSERT into Student VALUES('Surserar','12217ur64f',21,'5241789635','Engineer')
INSERT into Student VALUES('Suryefar','12217urs3f',23,'5241789635','Electrical')
INSERT into Student VALUES('rerwdar','12217urpd5',22,'5241789635','Mechanical')
INSERT into Student VALUES('Srwddendar','12217u5pdf',21,'5241789635','Electrical')

SELECT * from Student where deptname='Mechanical'
DROP TABLE Student

select * from Student where deptname='Mechanical' or 