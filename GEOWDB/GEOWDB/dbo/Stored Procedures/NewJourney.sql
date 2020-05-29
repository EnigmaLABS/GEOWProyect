CREATE procedure [dbo].[NewJourney]
as
declare 
@idJourney		bigint
begin

	insert into Journeys (dtInicio) values (GETDATE())

	set @idJourney = @@IDENTITY

	select @idJourney as idJourney
end