CREATE TABLE [dbo].[Points] (
    [idPoint]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [PointDesc]  VARCHAR (100) NULL,
    [Height]     INT           NULL,
    [Width]      INT           NULL,
    [Color]      VARCHAR (55)  NULL,
    [GUIDObject] VARCHAR (155) NULL,
    CONSTRAINT [PK_Points] PRIMARY KEY CLUSTERED ([idPoint] ASC)
);

