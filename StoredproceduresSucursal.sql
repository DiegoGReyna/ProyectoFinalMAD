USE Proyecto_MAD;
Go

CREATE PROC Sucursal_ComboBox
		AS
		SELECT Id_Sucursal,Nombre FROM SUCURSAL
	GO

	select * from SUCURSAL