DECLARE emp_cursor CURSOR FOR
SELECT Name FROM dbo.Employee;

DECLARE @Name VARCHAR(50);

OPEN emp_cursor;

FETCH NEXT FROM emp_cursor INTO @Name;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @Name;
    FETCH NEXT FROM emp_cursor INTO @Name;
END

CLOSE emp_cursor;
DEALLOCATE emp_cursor;
