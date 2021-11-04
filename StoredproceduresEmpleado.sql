USE Proyecto_MAD;

----Usar views?? FALTA CREAR VIEWS 
--Mostrar Productos

go
			 
			  
CREATE VIEW Ver_Empleado_Usuario_Direccion_Sucursal
as
	SELECT EMPLEADO.Id_Empleado 'ID de empleado',USUARIOS.Id_Usuario 'ID de usuario',USUARIOS.Id_DIRECCION_USUARIOS'ID Direccion',EMPLEADO.Usuario 'Usuario',USUARIOS.Nombre 'Nombre',USUARIOS.Apellido_Paterno 'Apellido paterno',USUARIOS.Apellido_Materno 'Apellido Materno',
		   USUARIOS.Contrasena 'Contraseña',EMPLEADO.RFC 'RFC',USUARIOS.CURP 'CURP',USUARIOS.Fecha_Nacimiento 'Fecha de Nacimiento',EMPLEADO.Es_Administrador 'Administrador',DIRECCION_USUARIOS.Estado 'Estado',DIRECCION_USUARIOS.Municipio 'Municipio', 
		   DIRECCION_USUARIOS.Colonia 'Colonia',DIRECCION_USUARIOS.CodigoPostal 'Codigo postal',DIRECCION_USUARIOS.Calle 'calle',DIRECCION_USUARIOS.NUMERO_CASA 'Numero casa',SUCURSAL.Nombre 'Sucursal donde Trabaja', 
		   USUARIOS.Fecha_UltimaModificacion 'Fecha Ultima Modificacion',USUARIOS.USUARIO_ACTIVO 'Activo'
	FROM   EMPLEADO_SUCURSAL 
		INNER JOIN EMPLEADO 
		ON EMPLEADO_SUCURSAL.Id_Empleado = EMPLEADO.Id_Empleado 
		INNER JOIN SUCURSAL 
		ON EMPLEADO_SUCURSAL.Id_Sucursal = SUCURSAL.Id_Sucursal 
		INNER JOIN USUARIOS 
		ON EMPLEADO.Id_USUARIO = USUARIOS.Id_Usuario 
		INNER JOIN DIRECCION_USUARIOS 
		ON USUARIOS.Id_DIRECCION_USUARIOS = DIRECCION_USUARIOS.Id_Direccion_Usuarios
	
Go


CREATE PROCEDURE PR_Mostrar_Empleados
as
BEGIN
SELECT	[ID de empleado],[ID de usuario],[ID Direccion],[Usuario],[Nombre],[Apellido paterno],[Apellido Materno],[Contraseña],[RFC],[CURP],[Fecha de Nacimiento],[Administrador],[Estado],[Municipio],[Colonia],[Codigo postal],
		[calle],[Numero casa],[Sucursal donde Trabaja],[Fecha Ultima Modificacion],[Activo]	
FROM	Ver_Empleado_Usuario_Direccion_Sucursal

END

go



	CREATE PROC PR_Empleado_Agregar
		@Usuario VARCHAR(50),
		@Nombre VARCHAR(50),
		@ApellidoPaterno VARCHAR(50),
		@ApellidoMaterno VARCHAR(50),
		@Contrasena VARCHAR(50),
		@RFC VARCHAR(50),
		@CURP VARCHAR(50),
		@FechaNacimiento DATETIME,
		@Administrador BIT,
		@Estado VARCHAR(50),
		@Municipio VARCHAR(50),
		@Colonia VARCHAR(50),
		@CodigoPostal int,
		@Calle VARCHAR(50),
		@NumeroCasa int,
		@Id_Sucursal int,
		@FechaUltimaModificacion DATETIME
		
	AS
	BEGIN
		DECLARE @idDireccion int
		DECLARE @idUsuario int 
		DECLARE @idEmpleado int 

		INSERT INTO DIRECCION_USUARIOS(Estado,Municipio,Colonia,CodigoPostal,Calle,NUMERO_CASA) 
		VALUES(@Estado,@Municipio,@Colonia,@CodigoPostal,@Calle,@NumeroCasa)
		SELECT @idDireccion =SCOPE_IDENTITY()

		INSERT INTO USUARIOS(Id_DIRECCION_USUARIOS,Nombre,Apellido_Paterno,Apellido_Materno,Contrasena,Fecha_Nacimiento,CURP,Fecha_UltimaModificacion)
		VALUES(@idDireccion,@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Contrasena,@FechaNacimiento,@CURP,@FechaNacimiento)
		SELECT @idUsuario =SCOPE_IDENTITY()

		INSERT INTO EMPLEADO(Id_USUARIO,Usuario,RFC,Es_Administrador)
		VALUES(@idUsuario,@Usuario,@RFC,@Administrador)
		SELECT @idEmpleado =SCOPE_IDENTITY()

		INSERT INTO EMPLEADO_SUCURSAL(Id_Sucursal,Id_Empleado)
		VALUES(@Id_Sucursal,@idEmpleado)


	END
		GO

	CREATE PROC PR_Empleado_Editar
		@Id_Empleado int,
		@Id_Usuario int,
		@Id_Direccion Int,
		@Usuario VARCHAR(50),
		@Nombre VARCHAR(50),
		@ApellidoPaterno VARCHAR(50),
		@ApellidoMaterno VARCHAR(50),
		@Contrasena VARCHAR(50),
		@RFC VARCHAR(50),
		@CURP VARCHAR(50),
		@FechaNacimiento DATETIME,
		@Administrador BIT,
		@Estado VARCHAR(50),
		@Municipio VARCHAR(50),
		@Colonia VARCHAR(50),
		@CodigoPostal int,
		@Calle VARCHAR(50),
		@NumeroCasa int,
		@Id_Sucursal int,
		@FechaUltimaModificacion DATETIME
	AS
		UPDATE DIRECCION_USUARIOS SET Estado=@Estado,Municipio=@Municipio,
		Colonia=@Colonia,CodigoPostal=@CodigoPostal,Calle=@Calle,NUMERO_CASA=@NumeroCasa
		WHERE Id_Direccion_Usuarios=@Id_Direccion

		UPDATE USUARIOS SET Nombre=@Nombre,Apellido_Paterno=@ApellidoPaterno,
		Apellido_Materno=@ApellidoMaterno,Contrasena=@Contrasena,@FechaNacimiento=@FechaNacimiento,CURP=@CURP,
		Fecha_UltimaModificacion=@FechaUltimaModificacion
		WHERE Id_Usuario=@Id_Usuario
		
		UPDATE EMPLEADO SET Usuario=@Usuario,RFC=@RFC,
		Es_Administrador=@Administrador
		WHERE Id_Empleado=@Id_Empleado

		UPDATE EMPLEADO_SUCURSAL SET Id_Sucursal=@Id_Sucursal
		WHERE Id_Empleado=@Id_Empleado
		
				
	GO

	CREATE PROC Empleado_Buscar
		@valor VARCHAR(50)
	
	AS
	SELECT	[ID de empleado],[ID de usuario],[ID Direccion],[Usuario],[Nombre],[Apellido paterno],[Apellido Materno],[Contraseña],[RFC],[CURP],[Fecha de Nacimiento],[Administrador],[Estado],[Municipio],[Colonia],[Codigo postal],
			[calle],[Numero casa],[Sucursal donde Trabaja],[Fecha Ultima Modificacion],[Activo]	
		FROM Ver_Empleado_Usuario_Direccion_Sucursal
		WHERE [Nombre] LIKE '%' +	@valor + '%' OR [Usuario] LIKE '%'+ @valor +'%' OR [Apellido paterno] LIKE '%'+ @valor +'%' OR [Apellido Materno] LIKE '%'+ @valor +'%'
		ORDER BY [Nombre] ASC
GO

CREATE PROC Usuario_Desactivar
		@Id_Usuario INT
	AS
		UPDATE USUARIOS SET USUARIO_ACTIVO=0
		WHERE Id_Usuario= @Id_Usuario  
	GO

	CREATE PROC Usuario_Avtivar
		@Id_Usuario INT
	AS
		UPDATE USUARIOS SET USUARIO_ACTIVO=1
		WHERE Id_Usuario= @Id_Usuario  
	GO

	

	--Eliminar Empleado
	CREATE PROC PR_Empleado_Eliminar
		@Id_Empleado int,
		@Id_Usuario int,
		@Id_Direccion Int
	AS
		
		DELETE FROM EMPLEADO_SUCURSAL
		WHERE Id_Empleado=@Id_Empleado

		DELETE FROM EMPLEADO
		WHERE Id_Empleado=@Id_Empleado

		DELETE FROM USUARIOS
		WHERE Id_Usuario=@Id_Usuario

		DELETE FROM DIRECCION_USUARIOS
		WHERE Id_Direccion_Usuarios=@Id_Direccion

	GO
