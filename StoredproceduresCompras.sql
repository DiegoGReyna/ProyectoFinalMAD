USE Proyecto_MAD;
GO

---STORED PROCEDURES COMPRAS
---Procesos COMPRAS

CREATE TYPE TYPE_DETALLE_INGRESO AS TABLE
(Id_Articulo INT,
Nombre VARCHAR(50),
stock INT,
Precio  DEC(12,2),
cantidad INT,
Descuento  DEC(12,2),
TotalSinDescuento  DEC(12,2),
ahorrado  DEC(12,2),
TotalConDescuento  DEC(12,2)

);
GO

Drop TYPE TYPE_DETALLE_INGRESO
go














-----------------------------------------------------------------
CREATE PROC COMPRAS_Mostrar
AS
SELECT 
C.CodigoDeBarras AS Codigo_De_Barras, P.Id_Carrito_Productos AS Carrito_Productos, C.Total AS Total, C.TotalAhorrado AS Total_Ahorrado, C.EstadoDepago AS Estado_De_Pago
FROM COMPRAS C
INNER JOIN CARRITO_PRODUCTOS
ON C.Id_Carrito_Productos = P.Id_Carrito_Productos
ORDER BY C.CodigoDeBarras DESC
GO

--Buscar COMPRAS

CREATE PROC COMPRAS_Buscar
  @Compras VARCHAR(50)
SELECT 
C.CodigoDeBarras AS Codigo_De_Barras, P.Id_Carrito_Productos AS Carrito_Productos, C.Total AS Total, C.TotalAhorrado AS Total_Ahorrado, C.EstadoDepago AS Estado_De_Pago
FROM COMPRAS C
INNER JOIN CARRITO_PRODUCTOS P
ON C.Id_Carrito_Productos = P.Id_Carrito_Productos
WHERE C.CodigoDeBarras LIKE '&'+@Compras+'&' OR P.Id_Carrito_Productos LIKE '&'+@Compras+'&'
GO

--Agregar COMPRAS

CREATE PROC CARRITO_PRODUCTOS_Agregar
  @CodigoDeBarras INT,
  @Id_Carrito_Productos INT,
  @Total INT,
  @TotalAhorrado INT,
  @EstadoDepago BIT 
AS
  INSERT INTO COMRPAS(CodigoDeBarras, Id_Carrito_Productos, Total, TotalAhorrado, EstadoDepago)
  VALUES(@CodigoDeBarras, @Id_Carrito_Productos, @Total, @TotalAhorrado, @EstadoDepago)
GO

--Editar COMPRAS

CREATE PROC COMPRAS_Editar
  @CodigoDeBarras INT,
  @Id_Carrito_Productos INT,
  @Total INT,
  @TotalAhorrado INT,
  @EstadoDepago BIT 
AS
  UPDATE COMPRAS SET 
CodigoDeBarras = @CodigoDeBarras, Id_Carrito_Productos = @Id_Carrito_Productos, Total = @Total, TotalAhorrado = @TotalAhorrado, EstadoDepago = @EstadoDepago
  WHERE CodigoDeBarras = @CodigoDeBarras
GO

--Eliminar COMPRAS

CREATE PROC COMPRAS_Eliminar
  @CodigoDeBarras INT,
AS
  DELETE FROM COMPRAS
  WHERE CodigoDeBarras = @CodigoDeBarras
GO