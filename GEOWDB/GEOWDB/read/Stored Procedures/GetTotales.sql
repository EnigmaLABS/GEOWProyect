/*
exec [read].GetTotales
*/

CREATE procedure [read].GetTotales
as
begin

select 
	(select COUNT(1) from [read].Positions with(nolock)) as TotalCoordenadas,
	(select COUNT(1) from Points with(nolock)) as TotalPoints,
	(select COUNT(1) from Journeys with(nolock)) as TotalTrayectos

end