/*
drop procedure insertNewActionFieldWithPoints
*/
CREATE procedure [dbo].[insertNewActionFieldWithPoints]
@idRecord				bigint,
@ActionDate				datetime,
@idActionFieldType		tinyint,

@tblPoints			typePoints readonly
as
declare 
@idActionField		bigint
begin

	insert into [dbo].[ActionFields] (ActionDate, idActionFieldType, idRecord)
	values
	(@ActionDate, @idActionFieldType, @idRecord)

	set @idActionField = @@IDENTITY

	declare @newPoints table (PointDesc varchar(100), Height int, Width int, Color varchar(55))

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

	insert into ActionPoints
	(idActionField, idPoint, idOrientation)
	select
	@idActionField, p.idPoint, tbl.idOrientation
	from
	@tblPoints tbl
	inner join Points p on tbl.GUIDObject = p.GUIDObject

	--PARA EL TEST
	----------------------------------------------------------------
	----------------------------------------------------------------
	--insert into ActionPoints
	--(idActionField, idPoint, idOrientation)
	--select
	--@idActionField, p.idPoint, tbl.idOrientation
	--from
	--@tblPoints tbl
	--inner join Points p on tbl.PointDesc = p.PointDesc and
	--					   tbl.Height = p.Height and
	--					   tbl.Width = p.Width and
	--					   tbl.Color = p.Color


	select @idActionField as idActionField
end