USE Proyecto_MAD;
Go

CREATE TRIGGER TR_ActualizarStock
	ON CARRITO_PRODUCTOS
	FOR INSERT
	AS
	BEGIN
		
			UPDATE P SET P.Stock=P.Stock-I.CantidadProducto
			FROM PRODUCTO AS P INNER JOIN
			INSERTED AS I ON I.Id_Producto=P.CodigoProducto

	END
	GO
