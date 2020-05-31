
/*
select distinct p.idJourney, p.idPoint  from [read].Positions p

exec [read].GetPositions 50, 428882
*/
CREATE procedure [read].GetPositions
@idJourney		bigint,
@idObject		bigint
as
begin
	select p.dtPosition, p.X, p.Y
	from 
	[read].Positions p with(nolock)
	where
	p.idJourney = @idJourney and p.idPoint = @idObject
end