CREATE DATABASE SistemaApuestas;
GO

USE SistemaApuestas;
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Usuario NVARCHAR(50) NOT NULL UNIQUE,
    Clave NVARCHAR(100) NOT NULL,
    Rol NVARCHAR(20) NOT NULL
);

CREATE TABLE TiposApuesta (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50) NOT NULL,
    Premio DECIMAL(10,2) NOT NULL,
    CantidadNumeros INT NOT NULL,
    RangoMin INT NOT NULL,
    RangoMax INT NOT NULL,
    TieneNumeroExtra BIT NOT NULL DEFAULT 0
);

CREATE TABLE Apuestas (
    Id INT PRIMARY KEY IDENTITY,
    UsuarioId INT NOT NULL FOREIGN KEY REFERENCES Usuarios(Id),
    TipoApuestaId INT NOT NULL FOREIGN KEY REFERENCES TiposApuesta(Id),
    Numero NVARCHAR(100) NOT NULL,
    Monto DECIMAL(10,2) NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Estado NVARCHAR(20) DEFAULT 'Pendiente'
);

CREATE TABLE Resultados (
    Id INT PRIMARY KEY IDENTITY,
    TipoApuestaId INT NOT NULL FOREIGN KEY REFERENCES TiposApuesta(Id),
    NumeroGanador NVARCHAR(100) NOT NULL,
    Fecha DATETIME NOT NULL
);

INSERT INTO Usuarios (Usuario, Clave, Rol) VALUES
('admin', 'admin123', 'Admin'),
('cajero1', 'cajero123', 'Cajero');

INSERT INTO TiposApuesta (Nombre, Premio, CantidadNumeros, RangoMin, RangoMax, TieneNumeroExtra) VALUES
('Quiniela', 60.00, 1, 0, 99, 0),
('Palé', 1000.00, 2, 0, 99, 0),
('Tripleta', 20000.00, 3, 0, 99, 0),
('Super Pale', 3500.00, 2, 0, 99, 0),
('Loto', 0, 6, 1, 38, 0),
('Loto Más', 0, 6, 1, 38, 1),
('Super Kino TV', 0, 10, 1, 80, 0),
('Loto Pool', 0, 5, 1, 31, 0);
