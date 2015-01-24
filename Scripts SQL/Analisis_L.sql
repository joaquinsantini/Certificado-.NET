-- Creaci�n de Store Procedure Categorias_L
GO
IF (EXISTS(SELECT TOP (1) 1 FROM sysobjects WHERE Type = 'P' AND Name = 'Analisis_L'))
BEGIN
	DROP PROCEDURE Analisis_L
END

GO
-- HISTORIAL
-- Descripci�n: muestreo de tabla Categorias
-- Fecha de creaci�n: 19/01/2015
CREATE PROCEDURE Analisis_L
AS

SELECT	Especie,
	Fecha,
	Cotizacion
	FROM	Cotizaciones

SELECT	MAX(Cotizacion) AS 'Maximo'
	FROM	Cotizaciones

SELECT	MIN(Cotizacion) AS 'Minimo'
	FROM	Cotizaciones


RETURN