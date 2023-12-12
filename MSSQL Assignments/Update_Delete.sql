UPDATE UserTable
SET IsActive = 0
WHERE IsActive = 1;

UPDATE UserTable
SET ModifiedDate = GETDATE()
WHERE IsActive = 0;

DELETE FROM GroupTable
WHERE ID = 1;

DELETE FROM UserGroup
WHERE ID = 1;

SELECT * FROM UserTable
SELECT * FROM GroupTable
SELECT * FROM UserGroup