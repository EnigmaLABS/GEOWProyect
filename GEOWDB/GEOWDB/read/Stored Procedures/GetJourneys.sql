/*
exec [read].GetJourneys

drop procedure GetJourneys
*/
CREATE procedure [read].[GetJourneys]
as
begin
	select j.idJourney, j.dtInicio, COUNT(distinct p.idPoint) as numObjetos, COUNT(pos.idPosition) as numCoordenadasTotal
	from 
	Journeys j
	inner join [read].Positions pos with(nolock) on j.idJourney = pos.idJourney
	inner join Points p on pos.idPoint = p.idPoint
	group by 
	j.idJourney, j.dtInicio
end