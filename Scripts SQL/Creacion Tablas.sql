-- Verifico si existe la tabla Categorias y de ser así la elimino
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'U' AND Name = 'Categorias'))
BEGIN
	DROP TABLE dbo.Categorias
END

-- Creo la tabla Categorias
CREATE TABLE dbo.Categorias (
	CategoriaId		INT IDENTITY(1, 1) PRIMARY KEY,
	Descripcion		VARCHAR(255) NOT NULL
)

-- Verifico si existe la tabla Productos y de ser así la elimino
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'U' AND Name = 'Productos'))
BEGIN
	DROP TABLE dbo.Productos
END

-- Creo la tabla Productos
CREATE TABLE dbo.Productos (
	ProductoId		INT PRIMARY KEY NOT NULL,
	CategoriaId		INT FOREIGN KEY REFERENCES Categorias (CategoriaId),
	Descripcion		VARCHAR(255) NOT NULL,
	PrecioCompra		NUMERIC(31, 2),
	PrecioVenta		NUMERIC(31, 2),
	FechaAlta		DATETIME
)

-- Verifico si existe la tabla Cotizaciones y de ser así la elimino
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'U' AND Name = 'Cotizaciones'))
BEGIN
	DROP TABLE dbo.Cotizaciones
END

-- Creo la tabla Cotizaciones
CREATE TABLE dbo.Cotizaciones (
	Especie			VARCHAR(50) NULL,
	Fecha			SMALLDATETIME NULL,
	Cotizacion		DECIMAL(8, 2) NULL
)