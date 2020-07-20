CREATE TABLE [dbo].[EncodedMessages]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [OriginalMessage] NVARCHAR(MAX) NOT NULL, 
    [EncodedMessage] NVARCHAR(MAX) NOT NULL
)
