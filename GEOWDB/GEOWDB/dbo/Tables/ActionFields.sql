CREATE TABLE [dbo].[ActionFields] (
    [idActionField]     BIGINT   IDENTITY (1, 1) NOT NULL,
    [idActionFieldType] TINYINT  NULL,
    [idRecord]          BIGINT   NULL,
    [ActionDate]        DATETIME NULL,
    CONSTRAINT [PK_ActionFields] PRIMARY KEY CLUSTERED ([idActionField] ASC),
    CONSTRAINT [FK_ActionFields_ActionFieldTypes] FOREIGN KEY ([idActionFieldType]) REFERENCES [dbo].[ActionFieldTypes] ([idActionFieldType]),
    CONSTRAINT [FK_ActionFields_RecordActions] FOREIGN KEY ([idRecord]) REFERENCES [dbo].[RecordActions] ([idRecord])
);

