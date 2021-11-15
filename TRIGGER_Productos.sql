USE Proyecto_MAD;
Go

CREATE TRIGGER TR_Producto_Eliminar
	ON PRODUCTO
	INSTEAD OF DELETE
	AS
	BEGIN
		DECLARE @ID INT

		SELECT @ID=PRODUCTO.CodigoProducto
		FROM PRODUCTO
		JOIN deleted ON deleted.CodigoProducto = PRODUCTO.CodigoProducto
		
		UPDATE PRODUCTO
		SET Activo=0
		WHERE @ID = PRODUCTO.CodigoProducto


	END
	GO