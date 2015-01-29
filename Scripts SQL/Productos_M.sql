-- Creación de Store Procedure Productos_M
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Productos_M'))
BEGIN
	DROP PROCEDURE Productos_M
END

GO
-- HISTORIAL
-- Descripción: alta de producto en tabla Productos.
-- Fecha de creación: 21/01/2015
CREATE PROCEDURE Productos_M
	@ProductoId		INT,
	@Descripcion		VARCHAR(255),
	@PrecioCompra		FLOAT,
	@PrecioVenta		FLOAT,
	@Categoria		INT
AS

SET NOCOUNT ON

IF (EXISTS(SELECT TOP (1) 1 FROM Productos WHERE ProductoId = @ProductoId))
BEGIN
	BEGIN TRANSACTION Update_Productos

	UPDATE Productos
		SET	Descripcion = @Descripcion,
			PrecioCompra = @PrecioCompra,
			PrecioVenta = @PrecioVenta,
			CategoriaId = @Categoria
		WHERE	ProductoId = @ProductoId

	IF (@@ERROR <> 0)
	BEGIN
		ROLLBACK TRANSACTION Update_Productos

		RAISERROR('Error en modificación de producto.', 10, 10)

		RETURN -1
	END
END ELSE BEGIN
	RAISERROR('El producto no existe en la base.', 10, 10)

	RETURN -1
END

COMMIT TRANSACTION Update_Productos


RETURN 0