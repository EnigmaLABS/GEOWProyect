/*
exec [read].GetJourneys
exec [read].[GetJourneyObjects] 50
exec [read].[GetJourneyObjects] 29
*/
CREATE procedure [read].[GetJourneyObjects]
@idJourney		bigint
as
begin
	select distinct p.idPoint, p.PointDesc, p.Color, p.Height, p.Width
	from 
	Points p
	inner join [read].[Journeys_Points] jp on p.idPoint = jp.idPoint
	where
	jp.idJourney = @idJourney
end