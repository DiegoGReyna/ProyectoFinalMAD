USE Proyecto_MAD;
	
Go

CREATE VIEW Ver_Login_Usuario_Cliente
as
SELECT  CLIENTE.Id_Cliente'Id Cliente',USUARIOS.Id_Usuario'Id Usuario',DIRECCION_USUARIOS.Id_Direccion_Usuarios'Id Direccion',CARRITO.Id_Carrito'Id Carrito',CLIENTE.CorreoElectronico'Correo Electronico',CLIENTE.Celular'Celular',USUARIOS.Contrasena'Contraseña', 
        USUARIOS.Nombre'Nombre',USUARIOS.Apellido_Paterno'Apellido Paterno',USUARIOS.Apellido_Materno'Apellido materno',DIRECCION_USUARIOS.Estado'Estado',DIRECCION_USUARIOS.Municipio'Municipio',DIRECCION_USUARIOS.Colonia'Colonia', 
        DIRECCION_USUARIOS.CodigoPostal'Codigo Postal',DIRECCION_USUARIOS.Calle'Calle',DIRECCION_USUARIOS.NUMERO_CASA'Numero domicilio',USUARIOS.USUARIO_ACTIVO'Activo'
FROM    CARRITO 
		INNER JOIN CLIENTE 
		ON CARRITO.Id_Cliente = CLIENTE.Id_Cliente 
		INNER JOIN 
		USUARIOS ON CLIENTE.Id_Usuario = USUARIOS.Id_Usuario 
		INNER JOIN DIRECCION_USUARIOS 
		ON USUARIOS.Id_DIRECCION_USUARIOS = DIRECCION_USUARIOS.Id_Direccion_Usuarios

GO


CREATE PROCEDURE PR_Login_Cliente
		@correo VARCHAR(50),
		@contrasena VARCHAR(60)
	as
BEGIN
	SELECT	[Id Cliente],[Id Usuario],[Id Direccion],[Id Carrito],[Correo Electronico],[Celular],[Contraseña],[Nombre],[Apellido Paterno],[Apellido materno],
			CONCAT([Estado],',',[Municipio],',',[Codigo Postal],',',[Colonia],',',[Numero domicilio],' ',[Calle]) [DireccionCompleta],[Estado],[Municipio],
			[Colonia],[Codigo Postal],[Calle],[Numero domicilio],CONCAT([Nombre],' ',[Apellido Paterno],' ',[Apellido materno])[Nombre Completo],[Activo]

	FROM	Ver_Login_Usuario_Cliente
	WHERE	[Correo Electronico]= @correo AND [Contraseña]= @contrasena
END


GO


	CREATE PROC PR_Buscar_Desactivar_Cliente
		@valor VARCHAR(50)
	
	AS
		UPDATE Ver_Login_Usuario_Cliente SET [Activo]=0
		WHERE [Correo Electronico] = @valor
		
GO





