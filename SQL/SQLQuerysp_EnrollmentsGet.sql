if exists(select 1 from sys.objects where object_id = object_id(N'[Enrollments].[Get]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Enrollments].[Get]
end
go

create procedure [Enrollments].[Get]
	@Enrollments int
	
--with encryption
as
begin
	select Enrollments, StudentId, CourseId, EnrollmentDate
	from Enrollments 
	where @Enrollments is null or(@Enrollments is not null and CourseId = @Enrollments)

end
go
exec sp_recompile N'[Enrollments].[Get]' 