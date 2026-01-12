CREATE TABLE Claims
(
    ClaimId INT IDENTITY(1,1) PRIMARY KEY,
    PolicyId INT NOT NULL,
    ClaimDate DATE NOT NULL,
    ClaimAmount DECIMAL(10,2) NOT NULL,
    ClaimStatus VARCHAR(20) NOT NULL,

    CONSTRAINT FK_Claims_Policies
        FOREIGN KEY (PolicyId) REFERENCES Policies(PolicyId)
);