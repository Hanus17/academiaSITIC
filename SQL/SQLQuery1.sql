create database Excercises

use Excercises

--create table [User]
--(
--	UserId int primary key identity(1,1),
--	Username varchar(50) not null,
--	password varchar(50) not null
--)

if not exists(select 1 from dbo.sysobjects where id 
= OBJECT_ID(N'[dbo].[students]')and OBJECTPROPERTY(id, N'isUserTable')= 1)
BEGIN
	create table [dbo].[students]
	(
		StudentId int not null primary key identity(1,1),
		Name varchar(150) not null,
		DateOfBirth date not null,
		Email varchar(100)
	)
END

if not exists(select 1 from dbo.sysobjects where id 
= OBJECT_ID(N'[dbo].[Courses]')and OBJECTPROPERTY(id, N'isUserTable')= 1)
BEGIN
	create table Courses
	(
		CourseId int primary key identity(1,1),
		Name varchar(100),
		Credits int
	)
END

if not exists(select 1 from dbo.sysobjects where id 
= OBJECT_ID(N'[dbo].[Enrollments]')and OBJECTPROPERTY(id, N'isUserTable')= 1)
BEGIN
create table Enrollments
	(
		Enrollments int primary key identity(1,1),
		StudentId int,
		CourseId int,
		EnrollmentDate date,
		foreign key(StudentId) references Students(StudentId),
		foreign key(CourseId) references Courses(CourseId)
	)
END