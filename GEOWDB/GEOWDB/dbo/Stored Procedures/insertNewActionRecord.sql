/*
drop procedure insertNewActionRecord
*/
create procedure [dbo].[insertNewActionRecord]
@RecordDate		datetime,
@TraceIni		bit,
@ChangesIni		bit,
@ActiveIni		bit,
@tblPoints		typePoints readonly
as
declare 
@idRecord		bigint
begin
	insert into [dbo].[RecordActions]
	(RecordDate, TraceIni, ChangesIni, ActiveIni)
	values
	(@RecordDate, @TraceIni, @ChangesIni, @ActiveIni)

	set @idRecord = @@IDENTITY

	--grabo los puntos nuevos
	insert into [dbo].[Points]
	(PointDesc, Height, Width, Color, GUIDObject)
	select 
	tbl.PointDesc, tbl.Height, tbl.Width, tbl.Color, tbl.GUIDObject
	from 
	@tblPoints tbl
	left join [dbo].[Points] p on tbl.GUIDObject = p.GUIDObject
	where 
	p.idPoint is null

	--PARA EL TEST
	----------------------------------------------------------------
	----------------------------------------------------------------
	--insert into [dbo].[Points]
	--(PointDesc, Height, Width, Color)
	--select 
	--PointDesc, Height, Width, Color
	--from 
	--@tblPoints tbl
	--where not exists (select 1 
	--				  from [dbo].[Points] sub
	--				  where
	--				  sub.PointDesc = tbl.PointDesc and
	--				  sub.Height = tbl.Height and
	--				  sub.Width = tbl.Width and
	--				  sub.Color = tbl.Color )

	--PARA EL TEST
	----------------------------------------------------------------
	----------------------------------------------------------------
	insert into RecordPoints
	(idRecord, idPoint, idOrientation)
	select
	@idRecord, p.idPoint, tbl.idOrientation
	from
	@tblPoints tbl
	inner join Points p on tbl.GUIDObject = p.GUIDObject

	--insert into RecordPoints
	--(idRecord, idPoint, idOrientation)
	--select
	--@idRecord, p.idPoint, tbl.idOrientation
	--from
	--@tblPoints tbl
	--inner join Points p on tbl.PointDesc = p.PointDesc and
	--					   tbl.Height = p.Height and
	--					   tbl.Width = p.Width and
	--					   tbl.Color = p.Color


	select @idRecord as idRecord
end