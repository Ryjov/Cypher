CREATE TABLE [dbo].[EncodedMessages]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OriginalMessage] NVARCHAR(MAX) NOT NULL, 
    [EncryptedMessage] NVARCHAR(MAX) NOT NULL
)
