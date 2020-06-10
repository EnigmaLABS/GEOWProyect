CREATE TABLE [dbo].[Journeys] (
    [idJourney] BIGINT   IDENTITY (1, 1) NOT NULL,
    [dtInicio]  DATETIME CONSTRAINT [DF_JourneyCounter_dtInicio] DEFAULT (getdate()) NULL,
    [dtFin]     DATETIME NULL,
    CONSTRAINT [PK_JourneyCounter] PRIMARY KEY CLUSTERED ([idJourney] ASC)
);



