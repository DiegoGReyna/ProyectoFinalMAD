USE Proyecto_MAD;
Go

---Procesos SUCURSAL

--Mostrar SUCURSAL


CREATE VIEW Ver_Sucursal_Encargado
as
	SELECT        SUCURSAL.Id_Sucursal'Numero de sucursal', SUCURSAL.Nombre 'Nombre de la sucursal',SUCURSAL.Id_EmpleadoEncargado'Id empleado encargado', EMPLEADO.Usuario 'Usuario Empleado Encargado', 
							 USUARIOS.Nombre 'Nombre empleado encargado', SUCURSAL.Direcion_Estado 'Estado',SUCURSAL.Direccion_Municipio'Municipio', SUCURSAL.Direccion_Colonia'Colonia', 
							 SUCURSAL.Direccion_Calle'Calle', SUCURSAL.Direccion_Numero'Direcion numero', SUCURSAL.Codigo_Postal'Codigo postal',SUCURSAL.Fecha_Creacion 'Fecha creacion',SUCURSAL.Sucursal_Activo'Activo'
	FROM            EMPLEADO 
					INNER JOIN SUCURSAL 
					ON EMPLEADO.Id_Empleado =SUCURSAL.Id_EmpleadoEncargado 
					INNER JOIN USUARIOS 
					ON EMPLEADO.Id_USUARIO =USUARIOS.Id_Usuario
					where SUCURSAL.Sucursal_Activo = 1
					
GO
CREATE PROC PR_SUCURSAL_Mostrar
AS
 SELECT	[Numero de sucursal],[Nombre de la sucursal],[Id empleado encargado],[Usuario Empleado Encargado],
		[Nombre empleado encargado],[Estado],[Municipio],[Colonia],[Calle],[Direcion numero],[Codigo postal],[Fecha creacion],[Activo] 
 FROM	Ver_Sucursal_Encargado
 ORDER BY [Numero de sucursal] DESC 
				
GO
CREATE PROC PR_SUCURSAL_Agregar
	@Nombre VARCHAR(50),
	@Id_EmpleadoEncargado INT,
	@Fecha_Creacion DATE,	
	@Direcion_Estado VARCHAR(60),
	@Direccion_Municipio VARCHAR(60),
	@Direccion_Colonia VARCHAR(60),
	@Direccion_Calle VARCHAR(60),
	@Direccion_Numero VARCHAR(60),
	@Codigo_Postal VARCHAR(20) 
AS
	DECLARE @idSucursal int 
	INSERT INTO SUCURSAL
		( Nombre, Id_EmpleadoEncargado, Fecha_Creacion, Direcion_Estado, Direccion_Municipio, Direccion_Colonia, Direccion_Calle, Direccion_Numero, Codigo_Postal)
	VALUES
		( @Nombre, @Id_EmpleadoEncargado, @Fecha_Creacion, @Direcion_Estado, @Direccion_Municipio, @Direccion_Colonia, @Direccion_Calle, @Direccion_Numero, @Codigo_Postal)
		SELECT @idSucursal =SCOPE_IDENTITY()

		INSERT INTO ALMACEN(Id_Sucursal)
		VALUES(@idSucursal)
	GO
	CREATE PROC PR_SUCURSAL_Editar
	@Id_Sucursal INT,
	@Nombre VARCHAR(50),
	@Id_EmpleadoEncargado INT,
	@Direcion_Estado VARCHAR(60),
	@Direccion_Municipio VARCHAR(60),
	@Direccion_Colonia VARCHAR(60),
	@Direccion_Calle VARCHAR(60),
	@Direccion_Numero VARCHAR(60),
	@Codigo_Postal VARCHAR(20) 
	AS
		UPDATE SUCURSAL 
		SET  Nombre = @Nombre, Id_EmpleadoEncargado = @Id_EmpleadoEncargado, Direcion_Estado = @Direcion_Estado, Direccion_Municipio = @Direccion_Municipio, Direccion_Colonia = @Direccion_Colonia, Direccion_Calle = @Direccion_Calle, Direccion_Numero = @Direccion_Numero, Codigo_Postal = @Codigo_Postal
		WHERE Id_Sucursal = @Id_Sucursal 	
	Go
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
	CREATE PROC PR_SUCURSAL_Eliminar
		@Id_Sucursal INT
	AS
		DELETE FROM SUCURSAL
		WHERE Id_Sucursal = @Id_Sucursal
	GO
--Buscar SUCURSAL
CREATE PROC PR_SUCURSAL_Buscar
	@Sucursal VARCHAR(50)
	
AS
SELECT [Numero de sucursal],[Nombre de la sucursal],[Id empleado encargado],[Usuario Empleado Encargado],
		[Nombre empleado encargado],[Estado],[Municipio],[Colonia],[Calle],[Direcion numero],[Codigo postal],[Fecha creacion],[Activo]  FROM Ver_Sucursal_Encargado


WHERE [Nombre de la sucursal] LIKE '%' +@Sucursal+'%'
ORDER BY [Nombre de la sucursal] ASC
GO
--Desactivar SUCURSAL
	CREATE PROC SUCURSAL_Desactivar
		@Id_Sucursal INT,
	AS
		UPDATE SUCURSAL SET Estado=0
		WHERE Id_Sucursal = @Id_Sucursal 
	GO
--Activar SUCURSAL
	CREATE PROC SUCURSAL_Activar
		@Id_Sucursal INT,
	AS
		UPDATE SUCURSAL SET Estado=1
		WHERE Id_Sucursal = @Id_Sucursal
	GO
	CREATE VIEW Ver_Sucursal_Encargado
as
	SELECT        SUCURSAL.Id_Sucursal'Numero de sucursal', SUCURSAL.Nombre 'Nombre de la sucursal',SUCURSAL.Id_EmpleadoEncargado'Id empleado encargado', EMPLEADO.Usuario 'Usuario Empleado Encargado', 
							 USUARIOS.Nombre 'Nombre empleado encargado', SUCURSAL.Direcion_Estado 'Estado',SUCURSAL.Direccion_Municipio'Municipio', SUCURSAL.Direccion_Colonia'Colonia', 
							 SUCURSAL.Direccion_Calle'Calle', SUCURSAL.Direccion_Numero'Direcion numero', SUCURSAL.Codigo_Postal'Codigo postal',SUCURSAL.Fecha_Creacion 'Fecha creacion',SUCURSAL.Sucursal_Activo'Activo'
	FROM            EMPLEADO 
					INNER JOIN SUCURSAL 
					ON EMPLEADO.Id_Empleado =SUCURSAL.Id_EmpleadoEncargado 
					INNER JOIN USUARIOS 
					ON EMPLEADO.Id_USUARIO =USUARIOS.Id_Usuario
					where SUCURSAL.Sucursal_Activo = 1
					
GO
	CREATE VIEW	Ver_Sucursal_IdAlmacen
	as
		SELECT  ALMACEN.Id_Almacen'Id almacen',SUCURSAL.Id_Sucursal'Id_Sucursal',SUCURSAL.Nombre'Nombre',SUCURSAL.Sucursal_Activo'Activo'
		FROM    ALMACEN 
				INNER JOIN  SUCURSAL 
				ON ALMACEN.Id_Sucursal = dbo.SUCURSAL.Id_Sucursal
	GO
	CREATE PROC PR_SucursalCombox_Almacen
	AS
	BEGIN
		SELECT [Id almacen],[Id_Sucursal],[Nombre],[Activo]
		FROM Ver_Sucursal_IdAlmacen
		WHERE [Activo]=1

	END
		
	GO


