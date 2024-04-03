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
 ('�����', '��������� ���� ����� ��� �������� ��������'),
 ('��������', '��������, �������, ����������'),
 ('�������', '������������� ������� ��� ��������'),
 ('���������� � ���������������', '������ ��� ����� � ��������� ��������');
 go

insert into Products(ProductName, ProductDescription, CategoryID, Price)
values
 ('����� ���� ��� �����', 'Royal Canin', 1, 200.00),
 ('����� ���� ��� �����', 'Pedigree', 1, 299.00),
 ('�������', 'Petsafe', 2, 499.99),
 ('����� �� �������� �����', 'Kong', 3, 580.00),
 ('�����', 'Nite Ize', 3, 350.00),
 ('�����-���������', 'Sherpa', 4, 2499.00),
 ('����������', 'Catit', 4, 699.00),
 ('�������', 'PetFusion', 4, 685.99);
go

INSERT INTO ProductDetails (ProductID, Size, Color, Material) 
VALUES 
(1, '10kg', NULL, '�����'), 
(2, '5kg', NULL, '�����'),
(3, '20cm', '�������', '����'), 
(4, '10cm', '�����', '�����'),
(5, '15cm', '�������', '������'), 
(6, '30L', '������', '�����'), 
(7, '50cm', '�������', '��������'),
(8, '60cm', '����������', '����������');
go
select * from ProductDetails;
go
