-- Creaci�n de Store Procedure Categorias_L
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Categorias_L'))
BEGIN
	DROP PROCEDURE Categorias_L
END

GO
-- HISTORIAL
-- Descripci�n: muestreo de tabla Categorias
-- Fecha de creaci�n: 19/01/2015
CREATE PROCEDURE Categorias_L
AS

SET NOCOUNT ON

SELECT	CategoriaId		AS 'C�digo de Categor�a',
	Descripcion		AS 'Descripci�n'
	FROM	Categorias


RETURN 0