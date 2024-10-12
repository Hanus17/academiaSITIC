if exists(select 1 from sys.objects where object_id = object_id(N'[students].[Get]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[students].[Get]
end
go

create procedure [students].[Get]
	@StudentId int
	
--with encryption
as
begin
	select StudentId, Name, DateOfBirth, Email
	from students 
	where @StudentId is null or(@StudentId is not null and StudentId = @StudentId)

end
go
exec sp_recompile N'[students].[Get]' 

exec [students].[Get] 2
exec [students].[Get]