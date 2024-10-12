if exists(select 1 from sys.objects where object_id = object_id(N'[students].[Insert]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[students].[Insert]
end
go

create procedure [students].[Insert]
	@Name varchar(150),
	@DateOfBirth date,
	@Email varchar(100)
--with encryption
as
begin
	insert into students(Name, DateOfBirth, Email)
	values (@Name, @DateOfBirth, @Email)
end
go
exec sp_recompile N'[students].[Insert]'