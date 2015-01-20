-- Creación de Store Procedure Categorias_A
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Categorias_A'))
BEGIN
	DROP PROCEDURE Categorias_A
END

GO
-- HISTORIAL
-- Descripción: alta de categoría en tabla Categorias
-- Fecha de creación: 19/01/2015
CREATE PROCEDURE Categorias_A
	@Descripcion		VARCHAR(255)
AS

SET NOCOUNT ON

BEGIN TRANSACTION Insert_Categorias

INSERT INTO Categorias (Descripcion)
	VALUES (@Descripcion)

IF (@@ERROR <> 0)
BEGIN
	ROLLBACK TRANSACTION Insert_Categorias

	RAISERROR('Error en alta de categoría.', 10, 10)

	RETURN -1
END

COMMIT TRANSACTION Insert_Categorias


RETURN 0