CREATE TABLE [read].[Journeys_Points] (
    [idJourney] BIGINT NOT NULL,
    [idPoint]   BIGINT NOT NULL,
    CONSTRAINT [PK_Journeys_Points] PRIMARY KEY CLUSTERED ([idJourney] ASC, [idPoint] ASC),
    CONSTRAINT [FK_Journeys_Points_Journeys] FOREIGN KEY ([idJourney]) REFERENCES [dbo].[Journeys] ([idJourney]),
    CONSTRAINT [FK_Journeys_Points_Points] FOREIGN KEY ([idPoint]) REFERENCES [dbo].[Points] ([idPoint])
);

