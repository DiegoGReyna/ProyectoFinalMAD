USE Proyecto_MAD;
Go

---Procesos Productos

--Mostrar Productos
CREATE PROC Producto_Mostrar
AS
SELECT E.Id_Empleado AS Empleado,P.CodigoProducto AS codigoProducto , P.Nombre as NombreProducto,
	C.Nombre as Categoria,P.Precio As Precio , P.Descuento As Descuento , p.Stock as Stock , p.Descripciopn as Descripcion
	FROM PRODUCTO P 
	INNER JOIN PRODUCTO_CATEGORIA C 
	ON P.Id_Categoria=C.Id_CategoriaProducto
	INNER JOIN EMPLEADO E
	ON E.Id_Empleado=P.Id_Empleado
	ORDER BY P.CodigoProducto DESC 
GO


--Buscar Producto

CREATE PROC Producto_Buscar
	@valor	VARCHAR(50)
AS
SELECT E.Id_Empleado AS Empleado,P.CodigoProducto AS codigoProducto , P.Nombre as NombreProducto,
	C.Nombre as Categoria,P.Precio As Precio , P.Descuento As Descuento , p.Stock as Stock , p.Descripciopn as Descripcion
	FROM PRODUCTO P 
	INNER JOIN PRODUCTO_CATEGORIA C 
	ON P.Id_Categoria=C.Id_CategoriaProducto
	INNER JOIN EMPLEADO E
	ON E.Id_Empleado=P.Id_Empleado
	WHERE P.Nombre LIKE '&' +@valor+'&' OR P.Descripciopn LIKE '&'+@valor+'&'
	ORDER BY P.CodigoProducto ASC
GO

--Agregar Producto
	CREATE PROC Producto_Agregar
		@Id_Empleado INT,
		@Nombre VARCHAR(50),
		@Id_Categoria INT,
		@Descripcion VARCHAR(255),
		@Stock INT,
		@Precio DEC(11,2),
		@Descuento DEC(2,2)
	AS
		INSERT INTO PRODUCTO (Id_Empleado,Nombre,Id_Categoria,Descripciopn,Stock,Precio,Descuento)
		VALUES(@Id_Empleado,@Nombre,@Id_Categoria,@Descripcion,@Stock,@Precio,@Descuento)
	GO
--Editar Producto
	CREATE PROC Producto_Editar
		@Id_CodigoProducto INT,
		@Id_Empleado INT,
		@Nombre VARCHAR(50),
		@Id_Categoria INT,
		@Descripcion VARCHAR(255),
		@Stock INT,
		@Precio DEC(11,2),
		@Descuento DEC(2,2)
	AS
		UPDATE PRODUCTO SET Id_Empleado=@Id_Empleado,Nombre=@Nombre,
		Id_Categoria=@Id_Categoria,@Descripcion=Descripciopn,@Stock=Stock,
		@Precio=Precio,@Descuento=Descuento
		WHERE CodigoProducto=@Id_CodigoProducto 		
	GO
--Eliminar Producto
	CREATE PROC Producto_Eliminar
		@Id_CodigoProducto INT
	AS
		DELETE FROM PRODUCTO
		WHERE CodigoProducto=@Id_CodigoProducto
	GO
--Activar Producto
	CREATE PROC Producto_Desactivar
		@Id_CodigoProducto INT
	AS
		UPDATE PRODUCTO SET Estado=0
		WHERE CodigoProducto=@Id_CodigoProducto  
	GO
--Desactivar Producto
	CREATE PROC Producto_Activar
		@Id_CodigoProducto INT
	AS
		UPDATE PRODUCTO SET Estado=1
		WHERE CodigoProducto=@Id_CodigoProducto  
	GO
