-- Creación de Store Procedure Productos_B
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Productos_B'))
BEGIN
	DROP PROCEDURE Productos_B
END

GO
-- HISTORIAL
-- Descripción: baja de producto en tabla Productos.
-- Fecha de creación: 21/01/2015
CREATE PROCEDURE Productos_B
	@ProductoId		INT
AS

SET NOCOUNT ON

IF (EXISTS(SELECT TOP (1) 1 FROM Productos WHERE ProductoId = @ProductoId))
BEGIN
	BEGIN TRANSACTION Delete_Productos

	DELETE Productos
		WHERE	ProductoId = @ProductoId

	IF (@@ERROR <> 0)
	BEGIN
		ROLLBACK TRANSACTION Delete_Productos

		RAISERROR('Error en baja de producto.', 10, 10)

		RETURN -1
	END
END ELSE BEGIN
	RAISERROR('El producto no existe en la base.', 10, 10)

	RETURN -1
END

COMMIT TRANSACTION Delete_Productos


RETURN 0