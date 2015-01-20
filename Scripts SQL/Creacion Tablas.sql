-- Verifico si existe la tabla Categorias y de ser así la elimino
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'U' AND Name = 'Categorias'))
BEGIN
	DROP TABLE Categorias
END

-- Creo la tabla Categorias
CREATE TABLE Categorias (
	CategoriaId		INT IDENTITY(1, 1) PRIMARY KEY,
	Descripcion		VARCHAR(255) NOT NULL
)

-- Verifico si existe la tabla Productos y de ser así la elimino
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'U' AND Name = 'Productos'))
BEGIN
	DROP TABLE Productos
END

-- Creo la tabla Productos
CREATE TABLE Productos (
	ProductoId		INT PRIMARY KEY NOT NULL,
	CategoriaId		INT FOREIGN KEY REFERENCES Categorias (CategoriaId),
	Descripcion		VARCHAR(255) NOT NULL,
	PrecioCompra		NUMERIC(31, 2),
	PrecioVenta		NUMERIC(31, 2)
)