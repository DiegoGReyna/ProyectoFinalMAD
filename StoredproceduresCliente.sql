USE Proyecto_MAD;

Go

CREATE VIEW Ver_Cliente_Usuario_Direccion_Carrito
as

SELECT       CLIENTE.Id_Cliente'Id Cliente', USUARIOS.Id_Usuario 'Id Usuario',CARRITO.Id_Carrito 'Id Carrito',USUARIOS.Id_DIRECCION_USUARIOS 'Id Direccion',CLIENTE.CorreoElectronico 'Correo Electronico',USUARIOS.Nombre 'Nombre',USUARIOS.Apellido_Paterno 'Apellido Paterno', 
             USUARIOS.Apellido_Materno 'Apellido materno',USUARIOS.CURP 'CURP',USUARIOS.Fecha_Nacimiento 'Fecha de nacimiento',DIRECCION_USUARIOS.Estado 'Estado',DIRECCION_USUARIOS.Municipio 'Municipio',DIRECCION_USUARIOS.Colonia 'Colonia', 
             DIRECCION_USUARIOS.CodigoPostal 'Codigo postal',DIRECCION_USUARIOS.NUMERO_CASA 'Numero de domicilio',DIRECCION_USUARIOS.Calle 'Calle',USUARIOS.Fecha_UltimaModificacion 'Fecha ultima modificacion',USUARIOS.USUARIO_ACTIVO 'Activo'
FROM         CARRITO 
			 INNER JOIN CLIENTE 
			 ON CARRITO.Id_Cliente = CLIENTE.Id_Cliente 
			 INNER JOIN USUARIOS 
			 ON CLIENTE.Id_Usuario = USUARIOS.Id_Usuario 
			 INNER JOIN DIRECCION_USUARIOS 
			 ON USUARIOS.Id_DIRECCION_USUARIOS = DIRECCION_USUARIOS.Id_Direccion_Usuarios

GO

CREATE PROCEDURE PR_Mostrar_Cliente
as
BEGIN
SELECT[Id Cliente],[Id Usuario],[Id Carrito],[Id Direccion],[Correo Electronico],[Nombre],[Apellido Paterno],[Apellido materno],[CURP],
[Fecha de nacimiento],[Estado],[Municipio],[Colonia],[Codigo postal],[Numero de domicilio],[Calle],[Fecha ultima modificacion],[Activo]

FROM	Ver_Cliente_Usuario_Direccion_Carrito

END

GO
Select * from USUARIOS
GO 
CREATE PROC PR_Clinte_Agregar
		
		@CorreoElectronico VARCHAR(50),
		@NumCelular VARCHAR(50),
		@Nombre VARCHAR(50),
		@ApellidoPaterno VARCHAR(50),
		@ApellidoMaterno VARCHAR(50),
		@Contrasena VARCHAR(50),
		@CURP VARCHAR(50),
		@FechaCreacion DATETIME,
		@FechaNacimiento DATETIME,
		@Estado VARCHAR(50),
		@Municipio VARCHAR(50),
		@Colonia VARCHAR(50),
		@CodigoPostal VARCHAR(50),
		@Calle VARCHAR(50),
		@NumeroCasa VARCHAR(50),
		@FechaUltimaModificacion DATETIME
		
	AS
	BEGIN
		DECLARE @idDireccion int
		DECLARE @idUsuario int 

		INSERT INTO DIRECCION_USUARIOS(Estado,Municipio,Colonia,CodigoPostal,Calle,NUMERO_CASA) 
		VALUES(@Estado,@Municipio,@Colonia,@CodigoPostal,@Calle,@NumeroCasa)
		SELECT @idDireccion =SCOPE_IDENTITY()

		INSERT INTO USUARIOS(Id_DIRECCION_USUARIOS,Nombre,Apellido_Paterno,Apellido_Materno,Contrasena,Fecha_Nacimiento,Fecha_Creacion,CURP,Fecha_UltimaModificacion)
		VALUES(@idDireccion,@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Contrasena,@FechaNacimiento,@FechaCreacion,@CURP,@FechaUltimaModificacion)
		SELECT @idUsuario =SCOPE_IDENTITY()

		INSERT INTO CLIENTE(Id_Usuario,CorreoElectronico,Celular)
		VALUES(@idUsuario,@CorreoElectronico,@NumCelular)
		


	END	
GO


CREATE PROC PR_Cliente_Editar
		@Id_Usuario Int,
		@id_Direccion int,
		@Id_Cliente Int,
		@Id_Carrito Int,
		@CorreoElectronico VARCHAR(50),
		@NumCelular VARCHAR(50),
		@Nombre VARCHAR(50),
		@ApellidoPaterno VARCHAR(50),
		@ApellidoMaterno VARCHAR(50),
		@Contrasena VARCHAR(50),
		@CURP VARCHAR(50),
		@FechaNacimiento DATETIME,
		@Estado VARCHAR(50),
		@Municipio VARCHAR(50),
		@Colonia VARCHAR(50),
		@CodigoPostal int,
		@Calle VARCHAR(50),
		@NumeroCasa int,
		@FechaUltimaModificacion DATETIME
	AS
		UPDATE DIRECCION_USUARIOS SET Estado=@Estado,Municipio=@Municipio,
		Colonia=@Colonia,CodigoPostal=@CodigoPostal,Calle=@Calle,NUMERO_CASA=@NumeroCasa
		WHERE Id_Direccion_Usuarios=@Id_Direccion

		UPDATE USUARIOS SET Nombre=@Nombre,Apellido_Paterno=@ApellidoPaterno,
		Apellido_Materno=@ApellidoMaterno,Contrasena=@Contrasena,@FechaNacimiento=@FechaNacimiento,CURP=@CURP,
		Fecha_UltimaModificacion=@FechaUltimaModificacion
		WHERE Id_Usuario=@Id_Usuario
		
		UPDATE CLIENTE SET CorreoElectronico=@CorreoElectronico,Celular=@NumCelular
		WHERE Id_Cliente=@Id_Cliente
			
	GO



	