if exists(select 1 from sys.objects where object_id = object_id(N'[Courses].[Insert]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Courses].[Insert]
end
go

create procedure [Courses].[Insert]
	@Name varchar(100),
	@Credits varchar(100),
	@CourseId  int output
--with encryption
as
begin
	insert into Courses(Name, Credits)
	values (@Name, @Credits)

	set @CourseId = SCOPE_IDENTITY()	

end
go
exec sp_recompile N'[Courses].[Insert]' 