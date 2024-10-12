declare @CourseId int
exec [Courses].[Insert] 'Español',100, @CourseId output

select @CourseId

select * from Courses
select * from Enrollments
select * from students