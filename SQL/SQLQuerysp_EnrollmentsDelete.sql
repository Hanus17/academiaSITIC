if exists(select 1 from sys.objects where object_id = object_id(N'[Enrollments].[Delete]') and 
type in (N'P', N'PC'))
BEGIN
	drop procedure[Enrollments].[Delete]
end
go

create procedure [Enrollments].[Delete]
	@Enrollments int
	
--with encryption
as
begin
	delete Enrollments where Enrollments = @Enrollments

end
go
exec sp_recompile N'[Enrollments].[Delete]' 