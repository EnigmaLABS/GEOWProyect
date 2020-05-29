CREATE TABLE [dbo].[ActionPoints] (
    [idActionField] BIGINT  NOT NULL,
    [idPoint]       BIGINT  NOT NULL,
    [idOrientation] TINYINT NULL,
    CONSTRAINT [PK_ActionPoints] PRIMARY KEY CLUSTERED ([idActionField] ASC, [idPoint] ASC),
    CONSTRAINT [FK_ActionPoints_ActionFields] FOREIGN KEY ([idActionField]) REFERENCES [dbo].[ActionFields] ([idActionField]),
    CONSTRAINT [FK_ActionPoints_Orientations] FOREIGN KEY ([idOrientation]) REFERENCES [dbo].[Orientations] ([idOrientation]),
    CONSTRAINT [FK_ActionPoints_Points] FOREIGN KEY ([idPoint]) REFERENCES [dbo].[Points] ([idPoint])
);

