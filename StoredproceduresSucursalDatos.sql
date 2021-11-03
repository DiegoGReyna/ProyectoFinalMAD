USE Proyecto_MAD;
Go

---Procesos SUCURSAL

--Mostrar SUCURSAL
CREATE PROC SUCURSAL_Mostrar
AS
SELECT
 
S.Id_Sucursal AS Sucursal, S.Nombre AS Nombre, E.Id_EmpleadoEncargado  AS Empleado_Encargado, S.Fecha_Creacion AS Fecha_Creacion,	S.Direcion_Estado AS Direcion_Estado, S.Direccion_Municipio AS Direccion_Municipio, S.Direccion_Colonia AS Direccion_Colonia, S.Direccion_Calle AS Direccion_Calle, S.Direccion_Numero AS Direccion_Numero, S.Codigo_Postal AS Codigo_Postal 

	FROM SUCURSAL S

	INNER JOIN EMPLEADO E

	ON S.Id_EmpleadoEncargado = E.Id_Empleado

	ORDER BY S.Id_Sucursal DESC 
GO



--Buscar SUCURSAL
CREATE PROC SUCURSAL_Buscar
	@Sucursal VARCHAR(50)
	
AS
SELECT 

S.Id_Sucursal AS Sucursal, S.Nombre AS Nombre, E.Id_EmpleadoEncargado AS Empleado_Encragado, S.Fecha_Creacion AS Fecha_Creacion,	S.Direcion_Estado AS Direcion_Estado, S.Direccion_Municipio AS Direccion_Municipio, S.Direccion_Colonia AS Direccion_Colonia, S.Direccion_Calle AS Direccion_Calle, S.Direccion_Numero AS Direccion_Numero, S.Codigo_Postal AS Codigo_Postal 

	FROM SUCURSAL S

	INNER JOIN EMPLEADO E

	ON S.Id_EmpleadoEncargado = E.Id_Empleado

WHERE S.Id_Sucursal LIKE '%' +@Sucursal+'%' OR S.Nombre LIKE '%'+@Sucursal+'%' ORDER BY P.Nombre ASC
GO

--Agregar SUCURSAL
CREATE PROC SUCURSAL_Agregar
	@Id_Sucursal INT,
	@Nombre VARCHAR(50),
	@Id_EmpleadoEncargado INT,
	@Fecha_Creacion DATE,	
	@Direcion_Estado VARCHAR(60),
	@Direccion_Municipio VARCHAR(60),
	@Direccion_Colonia VARCHAR(60),
	@Direccion_Calle VARCHAR(60),
	@Direccion_Numero INT,
	@Codigo_Postal VARCHAR(20) 
AS
INSERT INTO SUCURSAL
(Id_Sucursal, Nombre, Id_EmpleadoEncargado, Fecha_Creacion, Direcion_Estado, Direccion_Municipio, Direccion_Colonia, Direccion_Calle, Direccion_Numero, Codigo_Postal)
VALUES
(@Id_Sucursal, @Nombre, @Id_EmpleadoEncargado, @Fecha_Creacion, @Direcion_Estado, @Direccion_Municipio, @Direccion_Colonia, @Direccion_Calle, @Direccion_Numero, @Codigo_Postal)
	GO

--Editar SUCURSAL
CREATE PROC SUCURSAL_Editar
	@Id_Sucursal INT,
	@Nombre VARCHAR(50),
	@Id_EmpleadoEncargado INT,
	@Fecha_Creacion DATE,	
	@Direcion_Estado VARCHAR(60),
	@Direccion_Municipio VARCHAR(60),
	@Direccion_Colonia VARCHAR(60),
	@Direccion_Calle VARCHAR(60),
	@Direccion_Numero INT,
	@Codigo_Postal VARCHAR(20) 
AS
UPDATE SUCURSAL SET 
Id_Sucursal = @Id_Sucursal, Nombre = @Nombre, Id_EmpleadoEncargado = @Id_EmpleadoEncargado, Fecha_Creacion = @Fecha_Creacion, Direcion_Estado = @Direcion_Estado, Direccion_Municipio = @Direccion_Municipio, Direccion_Colonia = @Direccion_Colonia, Direccion_Calle = @Direccion_Calle, Direccion_Numero = @Direccion_Numero, Codigo_Postal = @Codigo_Postal
WHERE Id_Sucursal = @Id_Sucursal 		
	GO

--Eliminar SUCURSAL
	CREATE PROC SUCURSAL_Eliminar
		@Id_Sucursal INT,
	AS
		DELETE FROM SUCURSAL
		WHERE Id_Sucursal = @Id_Sucursal
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