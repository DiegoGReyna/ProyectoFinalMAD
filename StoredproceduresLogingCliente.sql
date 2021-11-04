USE Proyecto_MAD;
	
Go

CREATE VIEW Ver_Login_Usuario_Cliente
as
SELECT  CLIENTE.Id_Cliente'Id cliente',USUARIOS.Id_Usuario 'Id Usuario',CLIENTE.CorreoElectronico 'Correo Electronico',CLIENTE.Celular 'Celular',USUARIOS.Contrasena 'Contraseña',USUARIOS.Nombre 'Nombre',USUARIOS.Apellido_Paterno 'Apellido paterno', 
        USUARIOS.Apellido_Materno 'Apellido Materno', USUARIOS.USUARIO_ACTIVO 'Activo'
FROM    CLIENTE 
		INNER JOIN USUARIOS 
		ON CLIENTE.Id_Usuario=USUARIOS.Id_Usuario

GO

CREATE PROCEDURE PR_Login_Cliente
		@correo VARCHAR(50),
		@contrasena VARCHAR(60)
	as
BEGIN
	SELECT	[Id Cliente],[Id Usuario],[Correo Electronico],[Celular],[Nombre],[Apellido Paterno],[Apellido materno],
			[Activo]

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





