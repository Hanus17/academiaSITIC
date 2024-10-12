if exists(select 1 from sys.objects where object_id = object_id(N'[students].[Update]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[students].[Update]
end
go

create procedure [students].[Update]
	@StudentId int,
	@Name varchar(150),
	@DateOfBirth date,
	@Email varchar(100)
--with encryption
as
begin
	update students
	set Name = @Name,
	DateOfBirth = @DateOfBirth,
	Email = @DateOfBirth
	where StudentId = @StudentId

end
go
exec sp_recompile N'[students].[Update]' 