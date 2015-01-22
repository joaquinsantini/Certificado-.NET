-- Creación de Store Procedure Productos_A
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Productos_A'))
BEGIN
	DROP PROCEDURE Productos_A
END

GO
-- HISTORIAL
-- Descripción: alta de producto en tabla Productos
-- Fecha de creación: 21/01/2015
CREATE PROCEDURE Productos_A
	@ProductoId		INT,
	@Descripcion		VARCHAR(255),
	@PrecioCompra		FLOAT,
	@PrecioVenta		FLOAT,
	@Categoria		INT,
	@FechaAlta		DATETIME
AS

SET NOCOUNT ON

IF (EXISTS(SELECT TOP (1) 1 FROM Productos WHERE ProductoId = @ProductoId))
BEGIN
	RAISERROR('El código ingresado ya existe en la base. Ingrese otro código para continuar.', 10, 10)

	RETURN -1
END

BEGIN TRANSACTION Insert_Productos

INSERT INTO Productos (ProductoId, Descripcion, PrecioCompra, PrecioVenta, CategoriaId, FechaAlta)
	VALUES (@ProductoId, @Descripcion, CONVERT(NUMERIC(31, 2), @PrecioCompra), CONVERT(NUMERIC(31, 2), @PrecioVenta), @Categoria, @FechaAlta)

IF (@@ERROR <> 0)
BEGIN
	ROLLBACK TRANSACTION Insert_Productos

	RAISERROR('Error en alta de producto.', 10, 10)

	RETURN -1
END

COMMIT TRANSACTION Insert_Productos


RETURN 0