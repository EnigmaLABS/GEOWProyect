CREATE TABLE [dbo].[RecordPoints] (
    [idRecord]      BIGINT  NOT NULL,
    [idPoint]       BIGINT  NOT NULL,
    [idOrientation] TINYINT NULL,
    CONSTRAINT [PK_RecordPoints] PRIMARY KEY CLUSTERED ([idRecord] ASC, [idPoint] ASC),
    CONSTRAINT [FK_RecordPoints_Orientations] FOREIGN KEY ([idOrientation]) REFERENCES [dbo].[Orientations] ([idOrientation]),
    CONSTRAINT [FK_RecordPoints_Points] FOREIGN KEY ([idPoint]) REFERENCES [dbo].[Points] ([idPoint]),
    CONSTRAINT [FK_RecordPoints_RecordActions] FOREIGN KEY ([idRecord]) REFERENCES [dbo].[RecordActions] ([idRecord])
);

