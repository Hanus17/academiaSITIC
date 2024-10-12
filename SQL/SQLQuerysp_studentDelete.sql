if exists(select 1 from sys.objects where object_id = object_id(N'[students].[Delete]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[students].[Delete]
end
go

create procedure [students].[Delete]
	@StudentId int
	
--with encryption
as
begin
	delete students where StudentId = @StudentId

end
go
exec sp_recompile N'[students].[Delete]' 

