CREATE DATABASE Proyecto_MAD;
USE Proyecto_MAD;
go
-------------------tablas Usuario

CREATE TABLE DIRECCION_USUARIOS(
	Id_Direccion_Usuarios INT PRIMARY KEY IDENTITY NOT NULL,
	Estado VARCHAR(60)  NOT NULL,
	Municipio  VARCHAR(60)  NOT NULL,
	Colonia VARCHAR(60) NOT NULL,
	CodigoPostal VARCHAR(60) NOT NULL,
	Calle VARCHAR(150)NOT NULL,
	NUMERO_CASA VARCHAR(60) NOT NULL,
);
GO

CREATE TABLE USUARIOS(
	Id_Usuario INT PRIMARY KEY IDENTITY NOT NULL,
	Id_DIRECCION_USUARIOS INT NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Apellido_Paterno VARCHAR(50) NOT NULL,
	Apellido_Materno VARCHAR(50)NOT NULL,
	Contrasena VARCHAR(60) NOT NULL,
	Fecha_Nacimiento DATETIME NOT NULL,
	Fecha_Creacion DATETIME NOT NULL,
	CURP VARCHAR(20) NOT NULL,
	USUARIO_ACTIVO BIT DEFAULT(1) ,
	Estado_CuentaUsuario BIT DEFAULT(1),
	Fecha_UltimaModificacion DATETIME DEFAULT GETDATE(),
	CONSTRAINT FK_USUARIOS_Id_DIRECCION_USUARIOS 
	FOREIGN KEY(Id_DIRECCION_USUARIOS) REFERENCES DIRECCION_USUARIOS(Id_Direccion_Usuarios)

	
);
GO

-----------------tabla Empleado
CREATE TABLE EMPLEADO(
	Id_Empleado INT PRIMARY KEY IDENTITY NOT NULL,
	Usuario VARCHAR(50)NOT NULL,
	RFC VARCHAR(20) NOT NULL,
	Id_USUARIO INT NOT NULL,
	Es_Administrador BIT Default(1)
	CONSTRAINT FK_EMPLEADO_Id_USUARIO
	FOREIGN KEY(Id_USUARIO) REFERENCES USUARIOS(Id_Usuario)
);
GO
----------------Acciones Empleado---------------
CREATE TABLE CLASE_ACCION_EMPLEADO(
Id_ClaseAccion INT PRIMARY KEY IDENTITY NOT NULL,
Nombre VARCHAR(50) NOT NULL

);
GO

CREATE TABLE ACCIONES_EMPLEADO(
	Id_AccionesEmpleado INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Empleado INT NOT NULL,
	Id_ClaseAccionEmpleado INT NOT NULL,
	CONSTRAINT FK_ACCIONES_EMPLEADO_Id_Empleado
	FOREIGN KEY(Id_Empleado) REFERENCES EMPLEADO(Id_Empleado),
	CONSTRAINT FK_ACCIONES_EMPLEADO_Id_ClaseAccionEmpleado
	FOREIGN KEY(Id_ClaseAccionEmpleado) REFERENCES CLASE_ACCION_EMPLEADO(Id_ClaseAccion),
);
GO
---TABLA HORARIO EMPLEADO 
CREATE TABLE DatosEmpleado_Horario(
	Id_Horario INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Empleado INT NOT NULL,
	FECHA	VARCHAR(100)NOT NULL,
	Registro_Entrada VARCHAR(50)NOT NULL,
	Registro_Salida VARCHAR(50)NOT NULL,
	Horas_Trabajadas VARCHAR(20)NOT NULL,
	CONSTRAINT FK_DatosEmpleado_Horario_Id_Empleado
	FOREIGN KEY(Id_Empleado) REFERENCES EMPLEADO(Id_Empleado),
);
go
---TABLA SUCURSAL  
CREATE TABLE SUCURSAL(
	Id_Sucursal INT PRIMARY KEY IDENTITY NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Id_EmpleadoEncargado INT NOT NULL,
	Fecha_Creacion DATETIME DEFAULT GETDATE(),	
	Direcion_Estado VARCHAR(60) NOT NULL,
	Direccion_Municipio VARCHAR(60) NOT NULL,
	Direccion_Colonia VARCHAR(60) NOT NULL,
	Direccion_Calle VARCHAR(60) NOT NULL,
	Direccion_Numero VARCHAR(60) NOT NULL,
	Sucursal_Activo BIT DEFAULT(1),
	Codigo_Postal VARCHAR(20) NOT NULL
	CONSTRAINT FK_SUCURSAL_Id_EmpleadoEncargado
	FOREIGN KEY(Id_EmpleadoEncargado) REFERENCES EMPLEADO(Id_Empleado),
);
GO


CREATE TABLE ALMACEN(
	Id_Almacen INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Sucursal INT NOT NULL,
	CONSTRAINT FK_ALMACENL_Id_Sucursal
	FOREIGN KEY(Id_Sucursal) REFERENCES SUCURSAL(Id_Sucursal),
);
GO
CREATE TABLE PRODUCTO_CATEGORIA(
	Id_CategoriaProducto INT PRIMARY KEY IDENTITY NOT NULL,
	Nombre VARCHAR(50) NOT NULL,

);
GO

CREATE TABLE PRODUCTO(
	CodigoProducto INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Empleado INT NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Id_Categoria INT NOT NULL,
	Descripciopn VARCHAR(255) NULL,
	Stock INT DEFAULT 1 NOT NULL,
	Precio  DEC(12,2) NOT NULL,
	Estado BIT DEFAULT(1),
	Descuento DEC(4,2)NULL,
	Activo BIT DEFAULT(1)NOT NULL
	CONSTRAINT FK_PRODUCTO_Id_EmpleadoEncargado
	FOREIGN KEY(Id_Empleado) REFERENCES EMPLEADO(Id_Empleado),
	CONSTRAINT FK_PRODUCTO_Id_Categoria
	FOREIGN KEY(Id_Categoria) REFERENCES PRODUCTO_CATEGORIA(Id_CategoriaProducto),


);
GO



CREATE TABLE ALMACEN_PRODUCTOS(
	Id_Almacen INT NOT NULL,
	Id_Codigo_Producto INT NOT NULL,
	CONSTRAINT FK_ALMACEN_PRODUCTOS_Id_Almacen
	FOREIGN KEY(Id_Almacen) REFERENCES ALMACEN(Id_Almacen),

	CONSTRAINT FK_ALMACEN_PRODUCTOS_Id_Codigo_Producto
	FOREIGN KEY(Id_Codigo_Producto) REFERENCES PRODUCTO(CodigoProducto),

);
GO

CREATE TABLE EMPLEADO_SUCURSAL(
	Id_Sucursal INT NOT NULL,
	Id_Empleado INT NOT NULL,

	CONSTRAINT FK_EMPLEADO_SUCURSAL_Id_Sucursal
	FOREIGN KEY(Id_Sucursal) REFERENCES SUCURSAL(Id_Sucursal),

	CONSTRAINT FK_EMPLEADO_SUCURSAL_Id_Empleado
	FOREIGN KEY(Id_Empleado) REFERENCES EMPLEADO(Id_Empleado),

);
GO

---TABLA PRODUCTOS



---TABLA CLIENTE
CREATE TABLE CLIENTE(
	Id_Cliente INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Usuario INT,
	CorreoElectronico VARCHAR(50) NOT NULL,
	Celular VARCHAR(50)NOT NULL
	CONSTRAINT FK_CLIENTE_Id_Usuario
	FOREIGN KEY(Id_Usuario) REFERENCES USUARIOS(Id_Usuario),
);
GO

---TABLA ACCIONES CLIENTE
CREATE TABLE CLASE_ACCIONES_CLIENTE(
	Id_Clase INT PRIMARY KEY IDENTITY NOT NULL,
	Nombre VARCHAR(50) NOT NULL
);
GO

CREATE TABLE ACCIONES_CLIENTE(
	Id_AccionCliente INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Cliente INT NOT NULL,
	Id_ClaseAcciones INT NOT NULL,

	CONSTRAINT FK_ACCIONES_CLIENTE_Id_Cliente
	FOREIGN KEY(Id_Cliente) REFERENCES CLIENTE(Id_Cliente),
	CONSTRAINT FK_ACCIONES_CLIENTE_Id_ClaseAcciones
	FOREIGN KEY(Id_ClaseAcciones) REFERENCES CLASE_ACCIONES_CLIENTE(Id_Clase),
);
GO


---tabla carrito--editar
CREATE TABLE CARRITO(
	Id_Carrito INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Cliente INT NOT NULL,
	Carrito_Activo BIT DEFAULT(1)
	CONSTRAINT FK_CARRITO_Id_Cliente
	FOREIGN KEY(Id_Cliente) REFERENCES CLIENTE(Id_Cliente),
	
);
GO

CREATE TABLE CARRITO_PRODUCTOS(
	Id_Carrito_Productos INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Carrito INT NOT NULL,
	Id_CodigoCompra INT NOT NULL,
	CantidadProducto INT NOT NULL,
	Id_Producto INT NOT NULL,
	Precio  DEC(12,2)NOT NULL,
	Descuento DEC(4,2)NOT NULL,
	PrecioConDescuento DEC(12,2)NOT NULL
	CONSTRAINT FK_CARRITO_PRODUCTOS_Id_Carrito
	FOREIGN KEY(Id_Carrito) REFERENCES CARRITO(Id_Carrito),

	CONSTRAINT FK_CARRITO_PRODUCTOS_Id_Producto
	FOREIGN KEY(Id_Producto) REFERENCES PRODUCTO(CodigoProducto),

	CONSTRAINT FK_CARRITO_PRODUCTOS_Id_CompraFormaPagoEnvio
	FOREIGN KEY(Id_CodigoCompra) REFERENCES COMPRAS_FORMA_DE_PAGOyENVIO(Id_CodigoDeBarras),
);
GO


------------------------------------------------------------
---TABLA COMPRAS----editar
CREATE TABLE FORMA_DE_PAGO(
	Id_Forma_De_Pago INT PRIMARY KEY IDENTITY NOT NULL,
	Forma_De_Pago VARCHAR(50) NOT NULL
);
GO

CREATE TABLE FORMA_DE_ENVIO(
	Id_Forma_De_Envio INT PRIMARY KEY IDENTITY NOT NULL,
	Forma_De_Envio VARCHAR(50) NOT NULL
);
GO

-------------------------------------------Tabla Eliminada---------------------------------------------------------
CREATE TABLE COMPRAS(																			----
	CodigoDeBarras INT PRIMARY KEY IDENTITY NOT NULL,											----
	Id_Carrito_Productos INT NOT NULL,															----
	Total DEC(12,2) NOT NULL,																	----
	TotalSinDescuento DEC(12,2) NOT NULL,														----
	TotalAhorrado DEC(12,2) NOT NULL,															----
	EstadoDepago BIT DEFAULT (0),																----
	CONSTRAINT FK_COMPRAS_Id_Carrito															----
	FOREIGN KEY(Id_Carrito_Productos) REFERENCES CARRITO_PRODUCTOS(Id_Carrito_Productos),		----
);																								----
GO																								----
----------------------------------------------------------------------------------------------------

CREATE TABLE COMPRAS_FORMA_DE_PAGOyENVIO(
	Id_CodigoDeBarras INT PRIMARY KEY IDENTITY NOT NULL,													
	Total DEC(12,2) NOT NULL,																	
	TotalSinDescuento DEC(12,2) NOT NULL,														
	TotalAhorrado DEC(12,2) NOT NULL,
	DireccionEntrega VARCHAR(250) NOT NULL,	
	FechaCompras DATETIME DEFAULT GETDATE(),
	EstadoDepago BIT DEFAULT (0),
	Id_Forma_De_Pago INT NOT NULL,
	Id_Forma_De_Envio INT NOT NULL
	CONSTRAINT FK_COMPRAS_FORMA_DE_PAGOyENVIO_Id_Forma_De_Pago
	FOREIGN KEY(Id_Forma_De_Pago) REFERENCES FORMA_DE_PAGO(Id_Forma_De_Pago),
	CONSTRAINT FK_COMPRAS_FORMA_DE_PAGOyENVIO_Id_Forma_De_Envio
	FOREIGN KEY(Id_Forma_De_Envio) REFERENCES FORMA_DE_ENVIO(Id_Forma_De_Envio),
);
GO
-------------------------------------------------------------------------------------------------


---TABLA RECIBO
CREATE TABLE RECIBO(
	Id_Recibo INT PRIMARY KEY IDENTITY NOT NULL,
	Id_Carrito_Productos INT NOT NULL,
	Id_Compras_FormaDePagoyEnvio INT NOT NULL,
	CONSTRAINT FK_RECIBO_Id_Carrito
	FOREIGN KEY(Id_Carrito_Productos) REFERENCES CARRITO_PRODUCTOS(Id_Carrito_Productos),
	CONSTRAINT FK_RECIBO_Id_Compras_FormaDePagoyEnvio
	FOREIGN KEY(Id_Compras_FormaDePagoyEnvio) REFERENCES COMPRAS_FORMA_DE_PAGOyENVIO(Id_Compras_FormaDePagoyEnvio),
);
GO


--DICCIONARIO SQL 
SELECT 
		'DATADICTIONARY' AS [REPORT],
		@@SERVERNAME AS [ServerName],
		DB_NAME() AS [DatabaseName],
		t.name AS [TableName], 
		schema_name(t.schema_id) AS [SchemaName], 
		c.name AS [ColumnName], 
		st.name AS [DataType], 
		c.max_length AS [MaxLength], 
		CASE 
			WHEN c.is_nullable = 0 THEN 'NO'
			ELSE 'YES'
		END AS [IsNull],
		CASE 
			WHEN c.is_identity = 0 THEN 'NO'
			ELSE 'YES'
		END AS [IsIdentity], 
		isnull(ep.value, '-- add description here') AS [Description]
	FROM [sys].[tables] t
	INNER JOIN [sys].[columns] c
		ON t.object_id= c.object_id 
	INNER JOIN [sys].[systypes] st 
		ON c.system_type_id= st.xusertype 
	INNER JOIN [sys].[objects] o 
		ON t.object_id= o.object_id 
	LEFT JOIN [sys].[extended_properties] ep 
		ON o.object_id = ep.major_id 
		AND c.column_Id = ep.minor_id
	WHERE t.name <> 'sysdiagrams' 
	ORDER BY 
		t.name,
		c.column_Id

	GO
