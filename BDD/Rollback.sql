USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'SistemaApuestas')
BEGIN
    ALTER DATABASE SistemaApuestas SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SistemaApuestas;
END
GO
