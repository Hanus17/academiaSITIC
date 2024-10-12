if exists(select 1 from sys.objects where object_id = object_id(N'[Enrollments].[Update]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Enrollments].[Update]
end
go

create procedure [Enrollments].[Update]
	@EnrollmentDate date,
	@StudentId int,
	@CourseId  int,
	@Enrollments int
--with encryption
as
begin
	update Enrollments
	set EnrollmentDate = @EnrollmentDate,
	StudentId = @StudentId,
	CourseId = @CourseId
	where Enrollments = @Enrollments

end
go
exec sp_recompile N'[Enrollments].[Update]' 