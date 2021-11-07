USE Proyecto_MAD;

CREATE VIEW Ver_Login_Usuario_Empleado
as
SELECT      EMPLEADO.Id_Empleado 'Id Empleado',USUARIOS.Id_Usuario 'Id Usuario',DIRECCION_USUARIOS.Id_Direccion_Usuarios 'Id Direccion',EMPLEADO.Usuario 'Usuario',USUARIOS.Contrasena 'Contraseña',EMPLEADO.RFC 'RFC',EMPLEADO.Es_Administrador'Administrador', 
            USUARIOS.USUARIO_ACTIVO 'Activo',USUARIOS.Nombre 'Nombre',USUARIOS.Apellido_Paterno 'Apellido paterno',USUARIOS.Apellido_Materno 'Apellido materno',USUARIOS.CURP 'CURP'
                         
FROM        EMPLEADO 
			INNER JOIN USUARIOS 
			ON EMPLEADO.Id_USUARIO = USUARIOS.Id_Usuario 
			INNER JOIN DIRECCION_USUARIOS 
			ON USUARIOS.Id_DIRECCION_USUARIOS = DIRECCION_USUARIOS.Id_Direccion_Usuarios


GO


	CREATE PROCEDURE PR_Login_Empleado
		@Usuario VARCHAR(50),
		@contrasena VARCHAR(60)
	as
BEGIN
	SELECT	[Id Empleado],[Id Usuario],[Id Direccion],[Usuario],[Contraseña],[RFC],[Administrador],
			[Activo],[Nombre],[Apellido paterno],[Apellido materno],[CURP]

	FROM	Ver_Login_Usuario_Empleado
	WHERE	[Usuario]= @Usuario AND [Contraseña]= @contrasena
END


GO


CREATE PROC PR_Buscar_Desactivar_Empleado
		@valor VARCHAR(50)
	
	AS
		UPDATE Ver_Login_Usuario_Empleado SET [Activo]=0
		WHERE [Usuario] = @valor
		
GO
