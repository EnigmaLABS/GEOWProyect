CREATE TABLE [write].[Positions] (
    [idPosition] BIGINT        IDENTITY (1, 1) NOT NULL,
    [GUIDObject] VARCHAR (155) NOT NULL,
    [PointDesc]  VARCHAR (100) NULL,
    [Height]     INT           NULL,
    [Width]      INT           NULL,
    [Color]      VARCHAR (55)  NULL,
    [X]          INT           NULL,
    [Y]          INT           NULL,
    [dtPosition] DATETIME      CONSTRAINT [DF_Positions_dtPosition] DEFAULT (getdate()) NULL,
    [idJourney]  BIGINT        NULL,
    CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED ([idPosition] ASC)
);

