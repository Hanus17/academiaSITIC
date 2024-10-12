if exists(select 1 from sys.objects where object_id = object_id(N'[Courses].[Delete]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Courses].[Delete]
end
go

create procedure [Courses].[Delete]
	@CoursesId int
	
--with encryption
as
begin
	delete Courses where CourseId = @CoursesId

end
go
exec sp_recompile N'[Courses].[Delete]' 