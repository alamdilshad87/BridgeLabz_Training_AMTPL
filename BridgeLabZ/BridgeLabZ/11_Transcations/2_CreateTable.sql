CREATE TABLE Bills (
    BillId INT IDENTITY PRIMARY KEY,
    BillDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL
);
CREATE TABLE Inventory (
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Stock INT NOT NULL,
    Price DECIMAL(10,2)
);
CREATE TABLE BillItems (
    ItemId INT IDENTITY PRIMARY KEY,
    BillId INT,
    ProductId INT,
    Quantity INT,
    Price DECIMAL(10,2),
    FOREIGN KEY (BillId) REFERENCES Bills(BillId),
    FOREIGN KEY (ProductId) REFERENCES Inventory(ProductId)
);
