CREATE TABLE Policies
(
    PolicyId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT NOT NULL,
    PolicyTypeId INT NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    PremiumAmount DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) NOT NULL,

    CONSTRAINT FK_Policies_Customers
        FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),

    CONSTRAINT FK_Policies_PolicyTypes
        FOREIGN KEY (PolicyTypeId) REFERENCES PolicyTypes(PolicyTypeId),

    CONSTRAINT CK_Policies_Dates
        CHECK (EndDate > StartDate)
);
