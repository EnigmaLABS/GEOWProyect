/*
select count(1) from write.Positions

exec write.TransferPositions

select count(1) from write.Positions
select count(1) from [read].PositionsR

select count(*) from points
select * from points

DELETE FROM ActionPoints
delete from RecordPoints
delete from points

DELETE FROM [read].PositionsR
*/
CREATE procedure [write].[TransferPositions]
as
begin
	if exists(select 1 from write.Positions)
	begin
		create table #guids (guidobject varchar(155))

		insert into #guids (guidobject)
		select distinct GUIDObject 
		from write.Positions nolock

		--Primero graba los nuevos objetos
		insert into [dbo].[Points]
		(PointDesc, Height, Width, Color, GUIDObject)
		select distinct
		pos.PointDesc, pos.Height, pos.Width, pos.Color, pos.GUIDObject
		from 
		write.Positions pos with(nolock)
		inner join #guids g on pos.GUIDObject = g.guidobject
		left join [dbo].[Points] p on pos.GUIDObject = p.GUIDObject
		where 
		p.idPoint is null

		ALTER TABLE [read].Positions
		NOCHECK CONSTRAINT FK_Positions_Points

		ALTER TABLE [read].Positions
		NOCHECK CONSTRAINT FK_Positions_Journeys

		delete w
		output 
		deleted.X, deleted.Y, deleted.dtPosition, deleted.idJourney, p.idPoint
		into 
		[read].Positions (X, Y, dtPosition, idJourney, idPoint)
		from
		write.Positions w
		inner join #guids g on w.GUIDObject = g.guidobject
		inner join [dbo].[Points] p on w.GUIDObject = p.GUIDObject

		ALTER TABLE [read].Positions
		CHECK CONSTRAINT FK_Positions_Points

		ALTER TABLE [read].Positions
		CHECK CONSTRAINT FK_Positions_Journeys

		drop table #guids
	end
end