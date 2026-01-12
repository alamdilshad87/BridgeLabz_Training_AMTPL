CREATE TABLE Payments
(
    PaymentId INT IDENTITY(1,1) PRIMARY KEY,
    PolicyId INT NOT NULL,
    PaymentDate DATE NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_Payments_Policies
        FOREIGN KEY (PolicyId) REFERENCES Policies(PolicyId)
);