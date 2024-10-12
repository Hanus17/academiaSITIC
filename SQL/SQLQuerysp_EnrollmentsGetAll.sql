if exists(select 1 from sys.objects where object_id = object_id(N'[Enrollments].[GetAll]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Enrollments].[GetAll]
end
go

create procedure [Enrollments].[GetAll]
	@Enrollments int
	
--with encryption
as
begin
	select Enrollments, StudentId, CourseId, EnrollmentDate
	from Enrollments 
	where Enrollments = @Enrollments

end
go
exec sp_recompile N'[Enrollments].[GetAll]' 