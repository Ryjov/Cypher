CREATE TABLE [dbo].[CypherSymbols]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [oldSymbol] CHAR(1) NOT NULL, 
    [newsymbol] CHAR(1) NOT NULL
)
