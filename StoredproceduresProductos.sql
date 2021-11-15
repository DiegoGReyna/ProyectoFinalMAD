USE Proyecto_MAD;
Go
-------------------------------------------------------------------------------------------------------------------------------------------------------------
---Procesos Productos
--Mostrar Productos
CREATE PROC Producto_Mostrar
AS
SELECT E.Id_Empleado AS Empleado,P.CodigoProducto AS codigoProducto , P.Nombre as NombreProducto,
	C.Nombre as Categoria,P.Precio As Precio , P.Descuento As Descuento , P.Stock as Stock , P.Descripciopn as Descripcion,P.Estado as Estado
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
	C.Nombre as Categoria,P.Precio As Precio , P.Descuento As Descuento , P.Stock as Stock , P.Descripciopn as Descripcion,P.Estado as Estado
	FROM PRODUCTO P 
	INNER JOIN PRODUCTO_CATEGORIA C 
	ON P.Id_Categoria=C.Id_CategoriaProducto
	INNER JOIN EMPLEADO E
	ON E.Id_Empleado=P.Id_Empleado
	WHERE P.Nombre LIKE '%' +@valor+'%' OR P.Descripciopn LIKE '%'+@valor+'%'
	ORDER BY P.Nombre ASC
GO
------------------------------------------------------------------------------------------------------------------------------------------------
--Agregar Producto
	CREATE PROC PR_Producto_Agregar
		@Id_Empleado INT,
		@Nombre VARCHAR(50),
		@Id_Categoria INT,
		@Descripcion VARCHAR(255),
		@Stock INT,
		@Precio DEC(12,2),
		@Descuento DEC(4,2),
		@IdAlmacen INT
	AS

	DECLARE @IdProducto int 

		INSERT INTO PRODUCTO (Id_Empleado,Nombre,Id_Categoria,Descripciopn,Stock,Precio,Descuento)
		VALUES(@Id_Empleado,@Nombre,@Id_Categoria,@Descripcion,@Stock,@Precio,@Descuento)
		SELECT @IdProducto =SCOPE_IDENTITY()

		INSERT INTO ALMACEN_PRODUCTOS(Id_Almacen,Id_Codigo_Producto)
		VALUES(@IdAlmacen,@IdProducto)
	GO
--Editar Producto
	CREATE PROC PR_Producto_Editar
		@Id_AlmacenSucursal INT,
		@Id_CodigoProducto INT,
		@Id_Empleado INT,
		@Nombre VARCHAR(50),
		@Id_Categoria INT,
		@Descripcion VARCHAR(255),
		@Stock INT,
		@Precio DEC(12,2),
		@Descuento DEC(4,2)
	AS
		UPDATE PRODUCTO SET Id_Empleado=@Id_Empleado,Nombre=@Nombre,
		Id_Categoria=@Id_Categoria,Descripciopn=@Descripcion,Stock=@Stock,
		Precio=@Precio,Descuento=@Descuento
		WHERE CodigoProducto=@Id_CodigoProducto 
		
		UPDATE ALMACEN_PRODUCTOS SET Id_Almacen=@Id_AlmacenSucursal
		WHERE Id_Codigo_Producto=@Id_CodigoProducto 
				
	GO
--Eliminar Producto
	CREATE PROC Producto_Eliminar
		@Id_CodigoProducto INT
	AS
		DELETE FROM PRODUCTO
		WHERE CodigoProducto=@Id_CodigoProducto
	GO
--Desactivar Producto
	CREATE PROC Producto_Desactivar
		@Id_CodigoProducto INT
	AS
		UPDATE PRODUCTO SET Estado=0
		WHERE CodigoProducto=@Id_CodigoProducto  
	GO
--Activar Producto
	CREATE PROC Producto_Activar
		@Id_CodigoProducto INT
	AS
		UPDATE PRODUCTO SET Estado=1
		WHERE CodigoProducto=@Id_CodigoProducto  
	GO

	CREATE VIEW Ver_Producto_Categoria_AlmacenProducto
	as
		SELECT  EMPLEADO.Id_Empleado'ID de empleado',EMPLEADO.Usuario'Usuario empleado',PRODUCTO.CodigoProducto'CodigoProducto',PRODUCTO.Nombre'Nombre del Producto',PRODUCTO_CATEGORIA.Id_CategoriaProducto'Id Categoria',PRODUCTO_CATEGORIA.Nombre'Categoria',PRODUCTO.Precio'Precio',PRODUCTO.Descuento'Descuento', 
                PRODUCTO.Stock'Stock',PRODUCTO.Descripciopn'Descripcion',PRODUCTO.Estado'Estado',SUCURSAL.Id_Sucursal'Id sucursal',SUCURSAL.Nombre'Sucursal',PRODUCTO.Activo'Eliminado'
		FROM    ALMACEN_PRODUCTOS 
				INNER JOIN PRODUCTO 
				ON ALMACEN_PRODUCTOS.Id_Codigo_Producto = PRODUCTO.CodigoProducto 
				INNER JOIN EMPLEADO 
				ON PRODUCTO.Id_Empleado = EMPLEADO.Id_Empleado 
				INNER JOIN PRODUCTO_CATEGORIA 
				ON PRODUCTO.Id_Categoria = PRODUCTO_CATEGORIA.Id_CategoriaProducto 
				INNER JOIN ALMACEN 
				ON dbo.ALMACEN_PRODUCTOS.Id_Almacen = ALMACEN.Id_Almacen 
				INNER JOIN SUCURSAL 
				ON ALMACEN.Id_Sucursal = SUCURSAL.Id_Sucursal
				WHERE PRODUCTO.Activo=1

	GO
	----Mostrar productos 2


	CREATE PROC PR_Producto_Mostrar
AS
	SELECT [ID de empleado],[Usuario empleado],[CodigoProducto],[Nombre del Producto],[Id Categoria],[Categoria],[Precio],[Descuento],[Stock],[Descripcion],[Estado],[Id sucursal],[Sucursal],[Eliminado]
	FROM Ver_Producto_Categoria_AlmacenProducto
	
	ORDER BY [CodigoProducto] DESC 
	
GO

------------------------------------------------------------------------------Productos ventana Cliente----------------------------------------------------
	
	
	CREATE PROC PR_Producto_Mostrar_A_Cliente
AS
	SELECT [ID de empleado],[Usuario empleado],[CodigoProducto],[Nombre del Producto],[Id Categoria],[Categoria],[Precio],[Descuento],[Stock],[Descripcion],[Estado],[Id sucursal],[Sucursal],[Eliminado]
	FROM Ver_Producto_Categoria_AlmacenProducto
	WHERE [Stock] > 0
	ORDER BY [CodigoProducto] DESC 
	
GO


	CREATE PROC PR_BUSCAR_PRODUCTO_SUCURSAL_Y_CATEGORIA
		@Sucursal	INT,
		@Categoria	INT

	AS	
		SELECT [ID de empleado],[Usuario empleado],[CodigoProducto],[Nombre del Producto],[Id Categoria],[Categoria],[Precio],[Descuento],[Stock],[Descripcion],[Estado],[Id sucursal],[Sucursal],[Eliminado]
		FROM Ver_Producto_Categoria_AlmacenProducto
		WHERE [Id Categoria] LIKE '%' + @Categoria +'%' AND [Id sucursal] LIKE '%'+ @Sucursal +'%' AND [Stock] > 0
		ORDER BY [Nombre del Producto] ASC
	GO

	CREATE PROC PR_BUSCAR_PRODUCTO_SUCURSAL
		@Sucursal	INT
	AS	
		SELECT [ID de empleado],[Usuario empleado],[CodigoProducto],[Nombre del Producto],[Id Categoria],[Categoria],[Precio],[Descuento],[Stock],[Descripcion],[Estado],[Id sucursal],[Sucursal],[Eliminado]
		FROM Ver_Producto_Categoria_AlmacenProducto
		WHERE [Id sucursal] LIKE '%' + @Sucursal +'%' AND [Stock] > 0
		ORDER BY [Nombre del Producto] ASC
	GO

	CREATE PROC PR_BUSCAR_PRODUCTO_CATEGORIA
		@Categoria	INT
	AS	
		SELECT [ID de empleado],[Usuario empleado],[CodigoProducto],[Nombre del Producto],[Id Categoria],[Categoria],[Precio],[Descuento],[Stock],[Descripcion],[Estado],[Id sucursal],[Sucursal],[Eliminado]
		FROM Ver_Producto_Categoria_AlmacenProducto
		WHERE [Id Categoria] LIKE '%' + @Categoria +'%' AND [Stock] > 0
		ORDER BY [Nombre del Producto] ASC
	GO

	CREATE PROC PR_BUSCAR_PRODUCTO
		@Valor	VARCHAR(255)
	AS	
		SELECT [ID de empleado],[Usuario empleado],[CodigoProducto],[Nombre del Producto],[Id Categoria],[Categoria],[Precio],[Descuento],[Stock],[Descripcion],[Estado],[Id sucursal],[Sucursal],[Eliminado]
		FROM Ver_Producto_Categoria_AlmacenProducto
		WHERE [Nombre del Producto] LIKE '%' +@valor+'%' OR [Descripcion] LIKE '%'+@valor+'%'AND [Stock] > 0
		ORDER BY [Nombre del Producto] ASC
	GO
