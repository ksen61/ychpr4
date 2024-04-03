CREATE DATABASE PetShop33;
GO

USE PetShop33;
GO

CREATE TABLE Categories(
 CategoryID int PRIMARY KEY IDENTITY(1,1),
 CategoryName varchar(50) NOT NULL,
 Description varchar(100)
);
GO

CREATE TABLE Products(
 ProductID int PRIMARY KEY IDENTITY(1,1),
 ProductName varchar(50) NOT NULL,
 ProductDescription varchar(255),
 CategoryID int,
 Price decimal(10,2),
 CONSTRAINT FK_Category_Product FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
GO

CREATE TABLE ProductDetails( 
ProductDetailID int PRIMARY KEY IDENTITY(1,1), 
ProductID int, 
Size varchar(20) null,
Color varchar(20) null,
Material varchar(20) null,
CONSTRAINT FK_Product_ProductDetails FOREIGN KEY (ProductID) REFERENCES Products(ProductID) 
);
go

insert into Categories(CategoryName, Description)
values
 ('Корма', 'Различные виды корма для домашних животных'),
 ('Амуниция', 'Ошейники, поводки, намордники'),
 ('Игрушки', 'Разнообразные игрушки для животных'),
 ('Содержание и транспортировка', 'Товары для ухода и перевозки животных');
 go

insert into Products(ProductName, ProductDescription, CategoryID, Price)
values
 ('Сухой корм для кошек', 'Royal Canin', 1, 200.00),
 ('Сухой корм для собак', 'Pedigree', 1, 299.00),
 ('Ошейник', 'Petsafe', 2, 499.99),
 ('Мышка со звуковым чипом', 'Kong', 3, 580.00),
 ('Мячик', 'Nite Ize', 3, 350.00),
 ('Сумка-переноска', 'Sherpa', 4, 2499.00),
 ('Когтеточка', 'Catit', 4, 699.00),
 ('Лежанка', 'PetFusion', 4, 685.99);
go

INSERT INTO ProductDetails (ProductID, Size, Color, Material) 
VALUES 
(1, '10kg', NULL, 'Пакет'), 
(2, '5kg', NULL, 'Пакет'),
(3, '20cm', 'Голубой', 'Кожа'), 
(4, '10cm', 'Серый', 'Ткань'),
(5, '15cm', 'Красный', 'Резина'), 
(6, '30L', 'Черный', 'Ткань'), 
(7, '50cm', 'Розовый', 'Ковролин'),
(8, '60cm', 'Коричневый', 'Микровелюр');
go
select * from ProductDetails;
go
