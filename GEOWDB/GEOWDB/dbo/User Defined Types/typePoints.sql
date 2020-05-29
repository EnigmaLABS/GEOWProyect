CREATE TYPE [dbo].[typePoints] AS TABLE (
    [PointDesc]     VARCHAR (100) NULL,
    [Height]        INT           NULL,
    [Width]         INT           NULL,
    [Color]         VARCHAR (55)  NULL,
    [idOrientation] TINYINT       NULL,
    [GUIDObject]    VARCHAR (155) NULL);

