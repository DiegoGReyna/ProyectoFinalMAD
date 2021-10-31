USE Proyecto_MAD;

----Usar views?? FALTA CREAR VIEWS 
--Mostrar Productos

go
			 
			  
CREATE VIEW Ver_Empleado_Usuario_Direccion_Sucursal
as
	SELECT EMPLEADO.Id_Empleado 'ID de empleado',USUARIOS.Id_Usuario 'ID de usuario',EMPLEADO.Usuario 'Usuario',USUARIOS.Nombre 'Nombre',USUARIOS.Apellido_Paterno 'Apellido paterno',USUARIOS.Apellido_Materno 'Apellido Materno',
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
		WHERE USUARIOS.USUARIO_ACTIVO=1
Go

CREATE VIEW Ver_Empleado_Agregar
as
SELECT EMPLEADO.Id_Empleado 'ID de empleado',USUARIOS.Id_Usuario 'ID de usuario',EMPLEADO.Usuario 'Usuario',USUARIOS.Nombre 'Nombre',USUARIOS.Apellido_Paterno 'Apellido paterno',USUARIOS.Apellido_Materno 'Apellido Materno',
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

go

CREATE PROCEDURE PR_Mostrar_Empleados
as
BEGIN
SELECT	[ID de empleado],[ID de usuario],[Usuario],[Nombre],[Apellido paterno],[Apellido Materno],[Contraseña],[RFC],[CURP],[Fecha de Nacimiento],[Administrador],[Estado],[Municipio],[Colonia],[Codigo postal],
		[calle],[Numero casa],[Sucursal donde Trabaja],[Fecha Ultima Modificacion],[Activo]	
FROM	Ver_Empleado_Usuario_Direccion_Sucursal

END

go



	CREATE PROC PR_Empleado_Agregar
		@Id_Empleado INT,
		@Id_Usuario INT,
		@Usuario VARCHAR(50),
		@Nombre VARCHAR(50),
		@ApellidoPaterno VARCHAR(50),
		@ApellidoMaterno VARCHAR(50),
		@Contrasena VARCHAR(50),
		@RFC VARCHAR(50),
		@CURP VARCHAR(50),
		@FechaNacimiento DATE,
		@Administrador BIT,
		@Estado VARCHAR(50),
		@Municipio VARCHAR(50),
		@Colonia VARCHAR(50),
		@CodigoPostal int,
		@Calle VARCHAR(50),
		@NumeroCasa int,
		@Id_Sucursal int,
		@FechaUltimaModificacion DATE
		
	AS
	BEGIN
		DECLARE @idDireccion int
		DECLARE @idUsuario int 
		DECLARE @idEmpleado int 

		INSERT INTO DIRECCION_USUARIOS(Estado,Municipio,Colonia,CodigoPostal,Calle,NUMERO_CASA) 
		VALUES(@Estado,@Municipio,@Colonia,@CodigoPostal,@Calle,@NumeroCasa)
		SELECT @idDireccion =MAX(@idDireccion)FROM DIRECCION_USUARIOS

		INSERT INTO USUARIOS(Id_DIRECCION_USUARIOS,Nombre,Apellido_Paterno,Apellido_Materno,Contrasena,Fecha_Nacimiento,CURP,Fecha_UltimaModificacion)
		VALUES(@idDireccion,@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Contrasena,@FechaNacimiento,@CURP,@FechaNacimiento)
		SELECT @idUsuario =MAX(@idUsuario)FROM USUARIOS

		INSERT INTO EMPLEADO(Id_USUARIO,Usuario,RFC,Es_Administrador)
		VALUES(@idUsuario,@Usuario,@RFC,@Administrador)
		SELECT @idEmpleado =MAX(@idEmpleado)FROM EMPLEADO

		INSERT INTO EMPLEADO_SUCURSAL(Id_Sucursal,Id_Empleado)
		VALUES(@Id_Sucursal,@Id_Empleado)


	END
		GO