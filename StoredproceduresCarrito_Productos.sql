USE Proyecto_MAD;
GO

---STORED PROCEDURES CARRITO_PRODUCTOS
---Procesos CARRITO_PRODUCTOS

--Mostrar CARRITO_PRODUCTOS

CREATE PROC CARRITO_PRODUCTOS_Mostrar
AS
SELECT E.Id_Carrito_Producto AS Carrito_Producto, E.CantidadProducto AS Cantidad_Producto, C.Id_Carrito AS Carrito, P.Id_Producto AS Producto
FROM CARRITO_PRODUCTOS E
INNER JOIN CARRITO C
ON E.Id_Carrito = C.Id_Carrito
INNER JOIN PRODUCTO P
ON P.CodigoProducto = E.Id_Producto
ORDER BY E.Id_Carrito_Producto DESC
GO

--Buscar CARRITO_PRODUCTOS

CREATE PROC CARRITO_PRODUCTOS_Buscar
  @Carrito VARCHAR(50)
SELECT E.Id_Carrito_Producto AS Carrito_Producto, E.CantidadProducto AS Cantidad_Producto, C.Id_Carrito AS Carrito,   P.Id_Producto AS Producto
  FROM CARRITO_PRODUCTOS E
  INNER JOIN CARRITO C
  ON E.Id_Carrito = C.Id_Carrito
  INNER JOIN PRODUCTO P
  ON P.CodigoProducto = E.Id_Producto
WHERE E.Id_Carrito_Producto LIKE '&' +@Carrito +'&' OR E.CantidadProducto LIKE '&'+@Carrito+'&'
GO

--Agregar CARRITO_PRODUCTOS

CREATE PROC CARRITO_PRODUCTOS_Agregar
  @Id_Carrito_Productos INT,
  @Id_Carrito INT,
  @CantidadProducto INT,
  @Id_Producto INT,
AS
  INSERT INTO CARRITO_PRODUCTOS(Id_Carrito_Productos, Id_Carrito, CantidadProducto, Id_Producto)
  VALUES(@Id_Carrito_Productos, @Id_Carrito, @CantidadProducto, @Id_Producto)
GO

--Editar CARRITO_PRODUCTOS

CREATE PROC CARRITO_PRODUCTOS_Editar
  @Id_Carrito_Productos INT,
  @Id_Carrito INT,
  @CantidadProducto INT,
  @Id_Producto INT,
AS
  UPDATE CARRITO_PRODUCTOS SET Id_Carrito_Productos = @Id_Carrito_Productos, Id_Carrito = @Id_Carrito, CantidadProducto = @CantidadProducto , Id_Producto
  WHERE Id_Carrito_Productos = @Id_Carrito_Productos
GO

--Eliminar CARRITO_PRODUCTOS

CREATE PROC CARRITO_PRODUCTOS_Eliminar
  @Id_Carrito_Productos INT
AS
  DELETE FROM CARRITO_PRODUCTOS
  WHERE Id_Carrito_Productos = @Id_Carrito_Productos
GO