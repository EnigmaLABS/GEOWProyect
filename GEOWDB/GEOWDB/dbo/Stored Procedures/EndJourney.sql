create procedure EndJourney
@idJourney			bigint
as
begin
	update Journeys
	set
	dtFin = GETDATE()
	where
	idJourney = @idJourney
end