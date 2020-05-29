/*
drop procedure [write].[InsertPositions]
*/
create procedure [write].[InsertPositions]
@tblPositions typePositions readonly
as
begin
	insert into [write].[Positions]
	(GUIDObject, PointDesc, Height, Width, Color, X, Y, idJourney)
	select 
	GUIDObject, PointDesc, Height, Width, Color, X, Y, idJourney
	from 
	@tblPositions
end
