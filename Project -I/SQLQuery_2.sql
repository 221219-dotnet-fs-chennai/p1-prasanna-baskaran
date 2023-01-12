CREATE DATABASE Trainerfind
use Trainerfind

CREATE TABLE [users](
[userid] int,
[firstname] varchar(25) Not NULL,
[lastname] varchar(25),
[email] varchar(25) Not NULL,
[pasword] VARCHAR (25) Not NULL ,
constraint [pk_users] PRIMARY key([userid]));

select * from [users];


CREATE TABLE [skills](
    [skillid] int  ,
    [skills] varchar(50), 
    [experience] varchar(50),
    [userid] int , 
    [certification] varchar(50), 
    CONSTRAINT [pk_skillid] PRIMARY key([skillid]), 
    constraint [fk_users] foreign key([userid]) REFERENCES [users]([userid])ON DELETE CASCADE) ;
select * from [skills];

CREATE TABLE [education](
    [educationid] int,
    [userid] int,
    [sslc] varchar(25),
    [ssc] varchar(25),
    [ug] varchar(25),
    [pg] varchar(25),
     constraint [pk_eduid] PRIMARY key(educationid),
     CONSTRAINT [fk_eduid] foreign key(userid) REFERENCES users(userid) on DELETE CASCADE);

     SELECT * from [education];

CREATE TABLE [experience](
    [experceid] int ,
    [userid] int, 
    [companyid] int ,
    [companyloct] varchar(25),
    [joindate] date,
    constraint [pk_experid] PRIMARY key(experceid),
    constraint [fk_experid] FOREIGN key(userid) REFERENCES [users]([userid]) on DELETE CASCADE );

select * from [experience];

drop DATABASE Trainerfind
drop table [users]
drop table [education]
drop table [experience]
drop TABLE [skills]

INSERT INTO [users]
( 
 [userid], [firstname], [lastname],[email],[pasword]
)
VALUES
( 
 110,'prasanna','supra','prasanna4223@gmail.com','Asd123'
),
( -- Second row: values for the columns in the list above
 122,'revi','dev','revidev21@gmail.com','@d2sr%'
),
( 
 114,'prejesh','bhadura','prejeshbadu42@gmail.com','WErw23%2'
);

INSERT INTO [skills](
    [skillid],
    [skills],
    [experience],
    [userid],
    [certification]) 
    VALUES(1142,'C#','4months',122,'online'),
          (1452,'C#','6months',110,'career coach'),
        (1524,'java','6months',114,'Aj academy' );

INSERT INTO [education](
    [educationid],
    [userid],
    [sslc],
    [ssc],
    [ug],
    [pg]) 
VALUES 
(89,114,'89%','80%','71%','78%'),
(67,110,'95%','80%','85%','88%'),
(54,122,'71%','80%','68%','85%');

insert INTO [experience] (
    [experceid],
    [userid],
    [companyid],
    [companyloct],
    [joindate])
     VALUES 
         (99,110,5534,'Pune','2023-07-27'),
         (61,114,8874,'Delhi','2023-05-05'),
         (78,122,3874,'Mumbai','2023-12-31');