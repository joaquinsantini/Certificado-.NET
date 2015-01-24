-- Creaci�n de Store Procedure Cotizaciones_A
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Cotizaciones_A'))
BEGIN
	DROP PROCEDURE dbo.Cotizaciones_A
END

GO
-- HISTORIAL
-- Descripci�n: alta de cotizaci�n en tabla Cotizaciones.
-- Fecha de creaci�n: 23/01/2015
CREATE PROCEDURE dbo.Cotizaciones_A
	@Especie		VARCHAR(50),
	@Fecha			SMALLDATETIME,
	@Cotizacion		DECIMAL(8,2)
AS

SET NOCOUNT ON

BEGIN TRANSACTION Insert_Cotizaciones

INSERT INTO Cotizaciones (Especie, Fecha, Cotizacion)
	VALUES (@Especie, @Fecha, @Cotizacion)

IF (@@ERROR <> 0)
BEGIN
	ROLLBACK TRANSACTION Insert_Cotizaciones

	RAISERROR('Error en alta de cotizaci�n.', 10, 10)

	RETURN -1
END

COMMIT TRANSACTION Insert_Cotizaciones


RETURN 0