USE Proyecto_MAD;

----Usar views?? FALTA CREAR VIEWS 
--Mostrar Productos

go
			 
			  
CREATE VIEW Ver_Empleado_Usuario_Direccion_Estado_Municipio_Colonia
as
SELECT   USUARIOS.Id_Usuario 'ID de usuario',EMPLEADO.Id_Empleado 'ID de empleado',USUARIOS.Nombre 'Nombre',USUARIOS.Apellido_Paterno 'Apellido paterno',USUARIOS.Apellido_Materno 'Apellido Materno',EMPLEADO.Usuario 'Usuario',EMPLEADO.RFC 'RFC',USUARIOS.CURP 'CURP', 
         USUARIOS.Fecha_Nacimiento 'Fecha de nacimiento',USUARIOS.Contrasena 'Contraseña',EMPLEADO.Es_Administrador 'Es administrador',DIRECCION_USUARIOS.CodigoPostal 'Codigo postal',DIRECCION_ESTADO.Nombre 'Estado', 
         DIRECCION_MUNICIPIO.Nombre 'Municipio',DIRECCION_COLONIA.Nombre 'Colonia',DIRECCION_USUARIOS.Calle 'Calle',DIRECCION_USUARIOS.NUMERO_CASA 'Numero de casa',SUCURSAL.Nombre 'Nombre Sucursal', 
         USUARIOS.Fecha_UltimaModificacion 'Fecha ultima Modificacion',USUARIOS.USUARIO_ACTIVO 'Activo'
FROM     EMPLEADO_SUCURSAL 
		 INNER JOIN EMPLEADO 
		 ON EMPLEADO_SUCURSAL.Id_Empleado = EMPLEADO.Id_Empleado 
		 INNER JOIN SUCURSAL 
		 ON EMPLEADO_SUCURSAL.Id_Sucursal = SUCURSAL.Id_Sucursal 
		 INNER JOIN USUARIOS 
		 ON EMPLEADO.Id_USUARIO = USUARIOS.Id_Usuario 
		 INNER JOIN DIRECCION_COLONIA 
		 INNER JOIN DIRECCION_USUARIOS 
		 ON DIRECCION_COLONIA.Id_Colonia = DIRECCION_USUARIOS.Id_Colonia 
		 INNER JOIN DIRECCION_ESTADO 
		 ON DIRECCION_USUARIOS.Id_Estado_Usuarios = DIRECCION_ESTADO.Id_Estado 
		 INNER JOIN DIRECCION_MUNICIPIO 
		 ON DIRECCION_USUARIOS.Id_Municipio_Usuarios = DIRECCION_MUNICIPIO.Id_Municipio 
		 ON  USUARIOS.Id_DIRECCION_USUARIOS = DIRECCION_USUARIOS.Id_Direccion_Usuarios
		 WHERE USUARIOS.USUARIO_ACTIVO=1
Go

CREATE PROCEDURE PR_Mostrar_Empleados
as
BEGIN
SELECT	[ID de usuario],[ID de empleado],[Nombre],[Apellido paterno],[Apellido Materno],
		[Usuario],[RFC],[CURP],[Fecha de nacimiento],[Contraseña],[Es administrador],[Codigo postal],
		[Estado],[Municipio],[Colonia],[Calle],[Numero de casa],[Nombre Sucursal],[Fecha ultima Modificacion],[Activo]
FROM	Ver_Empleado_Usuario_Direccion_Estado_Municipio_Colonia

END

go