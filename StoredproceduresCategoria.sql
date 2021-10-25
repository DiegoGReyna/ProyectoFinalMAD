USE Proyecto_MAD;

GO

--Stored Procedures Categoria
---Mostrar Categorias

	CREATE PROC Categoria_Mostrar
		as
		SELECT Id_CategoriaProducto as ID , Nombre
		FROM PRODUCTO_CATEGORIA 
		ORDER BY Id_CategoriaProducto DESC
	go
---Buscar Categoria	
	CREATE PROC Categoria_Buscar
	@NombreCategoria VARCHAR(50)
		AS
		SELECT Id_CategoriaProducto as ID , Nombre
		FROM PRODUCTO_CATEGORIA
		WHERE Nombre like '%' + @NombreCategoria + '%'
		ORDER BY Nombre ASC
	GO
--- Agregar Categoria 
	CREATE PROC Categoria_Insertar
		@Nombre VARCHAR(50)
		AS
		INSERT INTO PRODUCTO_CATEGORIA (Nombre) VALUES(@Nombre)
	GO
---Editar Categorias
	CREATE PROC Categoria_Editar
		@Id_CategoriaProducto INT,
		@Nombre VARCHAR(50)
		AS
		UPDATE PRODUCTO_CATEGORIA SET Nombre =@Nombre
		WHERE Id_CategoriaProducto=@Id_CategoriaProducto
	GO   
---Eliminar Categorias 
	CREATE PROC Categoria_Eliminar
		@Id_CategoriaProducto INT
		AS
		DELETE FROM PRODUCTO_CATEGORIA
		WHERE  Id_CategoriaProducto=@Id_CategoriaProducto
	GO



