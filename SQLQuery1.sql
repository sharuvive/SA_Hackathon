CREATE TABLE [dbo].[Food]
(
	[fid] INT NOT NULL PRIMARY KEY, 
    [fname] NVARCHAR(50) NULL, 
    [price] REAL NULL
)


CREATE TABLE [dbo].[Order]
(
	[oid] INT NOT NULL PRIMARY KEY, 
    [stid] NVARCHAR(10) NULL, 
    [date] DATE NULL,
	[status] NVARCHAR(15) NULL
)

CREATE TABLE [dbo].[Order]
(
	[oid] INT NOT NULL PRIMARY KEY, 
    [stid] NVARCHAR(10) NULL, 
    [date] DATE NULL,
	[status] NVARCHAR(15) NULL
)

CREATE TABLE [dbo].[FoodOrder] (
    [fid]     INT NOT NULL,
    [oid] INT NOT NULL,
    CONSTRAINT [PK_dbo.FoodOrder] PRIMARY KEY CLUSTERED ([fid] ASC, [oid] ASC),
    CONSTRAINT [FK_dbo.FoodOrder_dbo.Food_fid] FOREIGN KEY ([fid]) REFERENCES [dbo].[Food] ([fid]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.FoodOrder_dbo.Order_oid] FOREIGN KEY ([oid]) REFERENCES [dbo].[Order] ([oid]) ON DELETE CASCADE
);