CREATE TABLE PolicyTypes
(
    PolicyTypeId INT IDENTITY(1,1) PRIMARY KEY,
    PolicyTypeName VARCHAR(50) NOT NULL,
    CoverageAmount DECIMAL(12,2) NOT NULL,
    BasePremium DECIMAL(10,2) NOT NULL
);