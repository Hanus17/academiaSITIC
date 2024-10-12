if exists(select 1 from sys.objects where object_id = object_id(N'[Enrollments].[Insert]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Enrollments].[Insert]
end
go

create procedure [Enrollments].[Insert]
	@EnrollmentDate date,
	@EnrollmentId int output,
	@StudentId  int,
	@CourseId  int
--with encryption
as
begin
	insert into Enrollments(StudentId, CourseId, EnrollmentDate)
	values (@StudentId, @CourseId, @EnrollmentDate)

	set @EnrollmentId = SCOPE_IDENTITY()	

end
go
exec sp_recompile N'[Enrollments].[Insert]' 