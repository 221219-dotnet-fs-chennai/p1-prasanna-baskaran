CREATE DATABASE Trainerfind
CREATE TABLE [users](
[user_id] int,
[Username] varchar(25) Not NULL,
[gender] varchar(25),
[email] varchar(25) Not NULL,
[pasword] VARCHAR (25) Not NULL ,
[location] VARCHAR(25) NOT NULL,
[aboutme] VARCHAR(25) NOT NULL,
[phoneno] VARCHAR(10) NOT NULL,
[website] VARCHAR(25) NOT NULL,
constraint [pk_users] PRIMARY key([user_id]));

select * from users;

INSERT INTO [users]
( 
 [user_id], [Username],[gender],[email],[pasword],[location],[aboutme],[phoneno],[website]
)
VALUES
( 
 110,'prasanna','male','prasanna4223@gmail.com','Asd123','Trichy','good','9039529538','www.google.com'
),
( -- Second row: values for the columns in the list above
 122,'revi','dev','revidev21@gmail.com','123asd','Chennai','Average','6453635235','www.yahoo.com'
),
( 
 114,'prejesh','bhadura','prejeshbadu42@gmail.com','prejesh','Madurai','Average','7396830224','www.hotmail.com'
);

CREATE TABLE [skills](
    [skillid] int  ,
    [skills] varchar(50), 
    [experience] varchar(50),
    [user_id] int , 
    [certification] varchar(50), 
    CONSTRAINT [pk_skillid] PRIMARY key([skillid]), 
    constraint [fk_users] foreign key([user_id]) REFERENCES [users]([user_id])ON DELETE CASCADE) ;
select * from [skills];

CREATE TABLE [education](
    [educationid] int,
    [user_id] int,
    [sslc] varchar(25),
    [ssc] varchar(25),
    [ug] varchar(25),
    [pg] varchar(25),
     constraint [pk_eduid] PRIMARY key(educationid),
     CONSTRAINT [fk_eduid] foreign key(user_id) REFERENCES users(user_id) on DELETE CASCADE);

     SELECT * from [education];

CREATE TABLE [experience](
    [experceid] int ,
    [user_id] int, 
    [companyid] int ,
    [companyloct] varchar(25),
    [joindate] date,
    constraint [pk_experid] PRIMARY key(experceid),
    constraint [fk_experid] FOREIGN key(user_id) REFERENCES [users]([user_id]) on DELETE CASCADE );

select * from [experience];

drop DATABASE Trainerfind
drop table [users]
drop table [education]
drop table [experience]
drop TABLE [skills]

INSERT INTO [users]
( 
 [user_id], [Username],[gender],[email],[pasword],[location],[aboutme],[phoneno],[website]
)
VALUES
( 
 110,'prasanna','male','prasanna4223@gmail.com','Asd123','Trichy','good','9039529538','www.google.com'
),
( -- Second row: values for the columns in the list above
 122,'revi','dev','revidev21@gmail.com','123asd','Chennai','Average','6453635235','www.yahoo.com'
),
( 
 114,'prejesh','bhadura','prejeshbadu42@gmail.com','prejesh','Madurai','Average','7396830224','www.hotmail.com'
);



INSERT INTO [skills](
    [skillid],
    [skills],
    [experience],
    [user_id],
    [certification]) 
    VALUES(1142,'C#','4months',122,'online'),
          (1452,'C#','6months',110,'career coach'),
        (1524,'java','6months',114,'Aj academy' );

INSERT INTO [education](
    [educationid],
    [user_id],
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
    [user_id],
    [companyid],
    [companyloct],
    [joindate])
     VALUES 
         (99,110,5534,'Pune','2023-07-27'),
         (61,114,8874,'Delhi','2023-05-05'),
         (78,122,3874,'Mumbai','2023-12-31');

