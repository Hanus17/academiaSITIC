declare @CourseId int
exec [Courses].[Insert] 'Espa�ol',100, @CourseId output

select @CourseId

select * from Courses
select * from Enrollments
select * from students