Create database project

create table mynotetable
(
Name varchar(50),
Text varchar(50),
arrindex varchar(50),
);
select * from mynotetable;
create table phn_table
(
Name varchar(50),
Number varchar(50),
c varchar(50)
);
select * from phn_table;

create table pass_table
(
pass varchar(50),
c varchar(50)
);
select * from pass_table;
create table back_random
(
back varchar(50),
c varchar(50)
);

INSERT INTO back_random
(back, c)
VALUES
('false', 1);
select * from back_random;
create table back_select
(
count varchar(50),
c varchar(50)
);
select * from back_select;
INSERT INTO back_select
(count, c)
VALUES
('', 1);
select * from back_select;
create table volume
(
vol varchar(50),
c varchar(50)
);
INSERT INTO volume
(vol, c)
VALUES
('0', 1);
select * from volume;

create table Music_tle
(
music nvarchar(max),
c varchar(50)
);
select * from Music_tle;

create table alarm_table
(
music nvarchar(max),
hour varchar(50),
mini varchar(50),
c varchar(50)
);
select * from alarm_table;

