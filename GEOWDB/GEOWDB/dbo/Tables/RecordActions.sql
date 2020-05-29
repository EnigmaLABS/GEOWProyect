CREATE TABLE [dbo].[RecordActions] (
    [idRecord]   BIGINT   IDENTITY (1, 1) NOT NULL,
    [RecordDate] DATETIME NULL,
    [TraceIni]   BIT      NULL,
    [ChangesIni] BIT      NULL,
    [ActiveIni]  BIT      NULL,
    CONSTRAINT [PK_RecordActions] PRIMARY KEY CLUSTERED ([idRecord] ASC)
);

