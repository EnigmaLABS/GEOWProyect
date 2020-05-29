CREATE TYPE [dbo].[typePositions] AS TABLE (
    [GUIDObject] VARCHAR (155) NOT NULL,
    [PointDesc]  VARCHAR (100) NULL,
    [Height]     INT           NOT NULL,
    [Width]      INT           NOT NULL,
    [Color]      VARCHAR (55)  NOT NULL,
    [X]          INT           NOT NULL,
    [Y]          INT           NOT NULL,
    [idJourney]  BIGINT        NULL);

