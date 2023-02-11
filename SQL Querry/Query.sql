CREATE TABLE [dbo].[Category]
(
	[Category_ID] INT NOT NULL PRIMARY KEY IDENTITY,
	[Category_name] NVARCHAR(50) NOT NULL
)

INSERT INTO Category VALUES (N'Овощи');
INSERT INTO Category VALUES (N'Зерновые');
INSERT INTO Category VALUES (N'Напитки');

CREATE TABLE [dbo].[Product]
(
	[Product_ID] INT NOT NULL PRIMARY KEY IDENTITY,
	[Product_name] NVARCHAR(50) NOT NULL 
)

INSERT INTO Product VALUES (N'Картофель');
INSERT INTO Product VALUES (N'Гречка');
INSERT INTO Product VALUES (N'Минеральная вода');

CREATE TABLE [dbo].[ProductCategory] (
    [Product_ID]  INT NOT NULL,
    [Category_ID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Product_ID] ASC, [Category_ID] ASC),
    FOREIGN KEY ([Product_ID]) REFERENCES [dbo].[Product] ([Product_ID]),
    FOREIGN KEY ([Category_ID]) REFERENCES [dbo].[Category] ([Category_ID])
);

INSERT INTO ProductCategory VALUES (1, 1);
INSERT INTO ProductCategory VALUES (1, 2);
INSERT INTO ProductCategory VALUES (2, 3);

SELECT P.Product_name, C.Category_name
FROM Product P
LEFT JOIN ProductCategory PC ON P.Product_ID = PC.Product_ID
LEFT JOIN Category C ON PC.Category_ID = C.Category_ID