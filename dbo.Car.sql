CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] NCHAR(10) NULL, 
    [DailyPrice] DECIMAL NULL, 
    [Description] NCHAR(10) NULL
)
