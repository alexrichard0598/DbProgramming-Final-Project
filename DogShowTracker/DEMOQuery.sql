
BEGIN TRAN
INSERT INTO Classes
                            (Class)
                            VALUES
                            ('{className}');
SELECT * FROM Classes;
ROLLBACK