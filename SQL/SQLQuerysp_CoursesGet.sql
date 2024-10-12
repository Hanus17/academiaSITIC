if exists(select 1 from sys.objects where object_id = object_id(N'[Courses].[Get]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Courses].[Get]
end
go

create procedure [Courses].[Get]
	@CourseId int
	
--with encryption
as
begin
	select CourseId, Name, Credits, CourseId  
	from Courses 
	where @CourseId is null or(@CourseId is not null and CourseId = @CourseId)

end
go
exec sp_recompile N'[Courses].[Get]' 