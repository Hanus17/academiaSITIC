if exists(select 1 from sys.objects where object_id = object_id(N'[Courses].[GetAll]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Courses].[GetAll]
end
go

create procedure [Courses].[GetAll]
	@CourseId int
	
--with encryption
as
begin
	select CourseId, Name, Credits, CourseId 
	from Courses
	where CourseId = @CourseId

end
go
exec sp_recompile N'[Courses].[GetAll]' 