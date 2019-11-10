
USE MASTER;
GO
IF DB_ID(N'personas') IS NOT NULL
DROP DATABASE personas;
GO
CREATE DATABASE personas;
GO
USE personas;
GO

IF OBJECT_ID('dbo.persona','U') IS NOT NULL
DROP TABLE persona
GO
CREATE TABLE dbo.persona(
Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
nombre varchar(100) NOT NULL,
correo varchar(50) NOT NULL,
fecha_nacimiento datetime NOT NULL
);

