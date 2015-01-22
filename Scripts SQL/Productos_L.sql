-- Creación de Store Procedure Productos_L
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Productos_L'))
BEGIN
	DROP PROCEDURE Productos_L
END

GO
-- HISTORIAL
-- Descripción: muestreo de tabla Categorias
-- Fecha de creación: 19/01/2015
CREATE PROCEDURE Productos_L
	@Categoria		INT
AS

SET NOCOUNT ON

IF (@Categoria <> 0)
BEGIN
	SELECT	P.ProductoId		AS 'ProductoId',
		C.Descripcion		AS 'Categoria',
		P.Descripcion		AS 'Descripcion',
		P.PrecioCompra		AS 'PrecioCompra',
		P.PrecioVenta		AS 'PrecioVenta',
		P.FechaAlta		AS 'FechaAlta'
		FROM	Productos P
		INNER JOIN	Categorias C
			ON	P.CategoriaId = C.CategoriaId
		WHERE	P.CategoriaId = @Categoria
END ELSE BEGIN
	SELECT	P.ProductoId		AS 'ProductoId',
		C.Descripcion		AS 'Categoria',
		P.Descripcion		AS 'Descripcion',
		P.PrecioCompra		AS 'PrecioCompra',
		P.PrecioVenta		AS 'PrecioVenta',
		P.FechaAlta		AS 'FechaAlta'
		FROM	Productos P
		INNER JOIN	Categorias C
			ON	P.CategoriaId = C.CategoriaId
END

RETURN 0