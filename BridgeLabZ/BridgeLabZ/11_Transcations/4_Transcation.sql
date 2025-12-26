BEGIN TRY
    BEGIN TRANSACTION;

    INSERT INTO Bills (BillDate, TotalAmount)
    VALUES (GETDATE(), 100);

    DECLARE @BillId INT = SCOPE_IDENTITY();

    INSERT INTO BillItems (BillId, ProductId, Quantity, Price)
    VALUES (@BillId, 101, 2, 10);

    UPDATE Inventory
    SET Stock = Stock - 2
    WHERE ProductId = 101;

    COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
    PRINT 'Transaction Failed';
END CATCH;
