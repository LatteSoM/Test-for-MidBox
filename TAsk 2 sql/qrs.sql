CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100)
);

CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Заполнение таблицы Categories
INSERT INTO Categories (CategoryID, CategoryName) VALUES
(1, 'Категория 1'),
(2, 'Категория 2'),
(3, 'Категория 3');

-- Заполнение таблицы Products
INSERT INTO Products (ProductID, ProductName) VALUES
(1, 'Продукт 1'),
(2, 'Продукт 2'),
(3, 'Продукт 3');

-- Заполнение таблицы ProductCategory
INSERT INTO ProductCategory (ProductID, CategoryID) VALUES
(1, 1),
(1, 2),
(2, 2),
(3, 3);

SELECT p.ProductName, ISNULL(c.CategoryName, 'Без категории') AS CategoryName
FROM Products p
LEFT JOIN ProductCategory pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID