if exists(select 1 from sys.objects where object_id = object_id(N'[Courses].[Update]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Courses].[Update]
end
go

create procedure [Courses].[Update]
	@Name varchar(100),
	@Credits int,
	@CourseId int
--with encryption
as
begin
	update Courses
	set Name = @Name,
	Credits = @Credits
	where CourseId = @CourseId

end
go
exec sp_recompile N'[Courses].[Update]' 