if exists(select 1 from sys.objects where object_id = object_id(N'[students].[GetAll]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[students].[GetAll]
end
go

create procedure [students].[GetAll]
	@StudentId int
	
--with encryption
as
begin
	select StudentId, Name, DateOfBirth, Email
	from students 
	where StudentId = @StudentId

end
go
exec sp_recompile N'[students].[GetAll]' 