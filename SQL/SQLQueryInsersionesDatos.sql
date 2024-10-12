declare @StudentId int
exec [students].[Insert] 'Manuel Guereca','1950-12-25','manuel.gt@itslerdo.edu.mx', @StudentId output

select @StudentId

declare @CourseId int
exec [Courses].[Insert] 'Español',100, @CourseId output

select @CourseId