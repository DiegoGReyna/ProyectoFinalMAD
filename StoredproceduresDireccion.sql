
USE Proyecto_MAD;
GO

CREATE PROC SP_Estado_ComboBox
		AS
		SELECT Id_Estado,Nombre FROM DIRECCION_ESTADO
	GO

	CREATE PROC SP_Municipio_ComboBox
		AS
		SELECT Id_Municipio,Nombre FROM DIRECCION_MUNICIPIO
	GO

	CREATE PROC SP_COLONIA_ComboBox
		As
		SELECT Id_Colonia,Nombre FROM DIRECCION_COLONIA
		GO
