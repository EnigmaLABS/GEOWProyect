/*
drop procedure insertNewActionField
*/
CREATE procedure insertNewActionField
@idRecord				bigint,
@ActionDate				datetime,
@idActionFieldType		tinyint
as
declare 
@idActionField		bigint
begin

	insert into [dbo].[ActionFields] (ActionDate, idActionFieldType, idRecord)
	values
	(@ActionDate, @idActionFieldType, @idRecord)

	set @idActionField = @@IDENTITY


	select @idActionField as idActionField
end