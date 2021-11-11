CREATE DATABASE SaleManagement

USE SaleManagement

USE master
/*DROP DATABASE SaleManagement
DROP TABLE OrderDetail
DROP TABLE Orders
DROP TABLE Member
DROP TABLE Product
*/

CREATE TABLE Member(
	MemberId		INT				PRIMARY KEY,
	Email			VARCHAR(100)	NOT NULL,
	CompanyName		VARCHAR(40)		NOT NULL,
	City			VARCHAR(15)		NOT NULL,
	Country			VARCHAR(15)		NOT NULL,
	Password		VARCHAR(30)		NOT NULL
)

CREATE TABLE Product(
	ProductId		INT				PRIMARY KEY,
	CategoryId		INT				NOT NULL,
	ProductName		VARCHAR(40)		NOT NULL,
	Weight			VARCHAR(20)		NOT NULL,
	UnitPrice		money			NOT NULL,
	UnitsInStock		INT				NOT NULL
)

CREATE TABLE Orders(
	OrderId			INT				PRIMARY KEY,
	MemberId		INT				NOT NULL,
	OrderDate		datetime		NOT NULL,
	RequiredDate	datetime		NULL,
	ShippedDate		datetime		NULL,
	Freight			money			NULL,
)

CREATE TABLE OrderDetail(
	OrderId			INT				FOREIGN KEY REFERENCES Orders(OrderId),
	ProductId		INT				FOREIGN KEY REFERENCES Product(ProductId),
	UnitPrice		money			NOT NULL,
	Quantity		INT				NOT NULL,
	Discount		FLOAT			NOT NULL,
	PRIMARY KEY (OrderId, ProductId)
)

INSERT INTO dbo.Member (MemberId, Email, CompanyName, City, Country, Password)
VALUES
(2,'phuong@gmail.com','KMS','Da Nang','Viet Nam','123'),
(3,'hanh@gmail.com','Dien Luc Tan Thuan','Da Nang','USA','123'),
(4,'binh@gmail.com','Thanh Da High School','Ha Noi','UK','123'),
(5,'phuongnnse150998@fpt.edu.vn','FPTU','Ho Chi Minh','Viet Nam','123')

INSERT INTO dbo.Product(ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitsInStock)
VALUES
(1,1,'Pork','12',125000,5),
(2,1,'Beef','1',90000,6),
(3,2,'Chicken Meat','2',80000,7),
(4,2,'Fish','5',100000,5),
(5,3,'Goat Meat','7',160000,2)

SELECT * FROM Member
SELECT * FROM Product

INSERT INTO dbo.Orders(OrderId,MemberId,OrderDate, RequiredDate, ShippedDate, Freight)
VALUES
(1,2,'2021-10-20','2021-10-22','2021-10-21',10000),
(2,2,'2021-09-20','2021-09-22','2021-09-21',20000)

SELECT * FROM dbo.Orders

INSERT INTO dbo.OrderDetail(OrderId, ProductId, Quantity,UnitPrice, Discount)
VALUES
(1,1,2,125000,5),
(1,2,3,90000,10),
(2,3,1,80000,10),
(2,4,2,100000,5)

SELECT * FROM dbo.OrderDetail