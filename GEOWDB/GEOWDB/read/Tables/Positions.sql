CREATE TABLE [read].[Positions] (
    [idPosition]     BIGINT   IDENTITY (1, 1) NOT NULL,
    [X]              INT      NULL,
    [Y]              INT      NULL,
    [dtPosition]     DATETIME NULL,
    [dtPositionLoad] DATETIME CONSTRAINT [DF_PositionsR_dtPositionLoad] DEFAULT (getdate()) NULL,
    [idJourney]      BIGINT   NULL,
    [idPoint]        BIGINT   NULL,
    CONSTRAINT [PK_PositionsR] PRIMARY KEY CLUSTERED ([idPosition] ASC),
    CONSTRAINT [FK_Positions_Journeys] FOREIGN KEY ([idJourney]) REFERENCES [dbo].[Journeys] ([idJourney]),
    CONSTRAINT [FK_Positions_Points] FOREIGN KEY ([idPoint]) REFERENCES [dbo].[Points] ([idPoint])
);




GO
CREATE NONCLUSTERED INDEX [IX_Journeys]
    ON [read].[Positions]([idJourney] ASC)
    INCLUDE([idPoint]);

