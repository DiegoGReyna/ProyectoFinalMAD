USE Proyecto_MAD;
Go

CREATE TRIGGER TR_Sucursal_Eliminar
	ON SUCURSAL
	INSTEAD OF DELETE
	AS
	BEGIN
		DECLARE @ID INT

		Select @ID=SUCURSAL.Id_Sucursal
		FROM SUCURSAL
		JOIN deleted ON deleted.Id_Sucursal = SUCURSAL.Id_Sucursal
		
		UPDATE SUCURSAL
		SET Sucursal_Activo=0
		WHERE @ID = SUCURSAL.Id_Sucursal


	END
	GO