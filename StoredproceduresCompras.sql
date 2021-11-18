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

CREATE PROC PR_RealizarCompra
@IdCarritoProductos INT OUTPUT,
@IdCodigoDebarrasCompras INT OUTPUT,
@IdCliente INT,
@IdFormaDePago INT,
@IdFormaDeEnvio INT,
@EstadoDePago BIT,
@DireccionEntrega VARCHAR(250),
@TotalConDescuento  DEC(12,2),
@TotalAhorrado  DEC(12,2),
@TotalSinDescuento  DEC(12,2),
@productoCarrito TYPE_DETALLE_INGRESO READONLY

AS	
	DECLARE @IdCarrito int 

	INSERT INTO CARRITO(Id_Cliente,Carrito_Activo)
	VALUES(@IdCliente,'True')
	SET @IdCarrito =SCOPE_IDENTITY()

	INSERT INTO COMPRAS_FORMA_DE_PAGOyENVIO(TotalSinDescuento,TotalAhorrado,Total,DireccionEntrega,FechaCompras,EstadoDepago,Id_Forma_De_Pago,Id_Forma_De_Envio)
	VALUES( @TotalSinDescuento,@TotalAhorrado,@TotalConDescuento,@DireccionEntrega,GETDATE(),@EstadoDePago,@IdFormaDePago,@IdFormaDeEnvio)
	SET  @IdCodigoDebarrasCompras =@@IDENTITY;

	INSERT CARRITO_PRODUCTOS(Id_CodigoCompra,Id_Carrito,CantidadProducto,Id_Producto,Precio,Descuento,PrecioConDescuento)
	SELECT @IdCodigoDebarrasCompras,@IdCarrito,PR.cantidad,PR.Id_Articulo,PR.Precio,PR.Descuento,Pr.TotalConDescuento
	FROM @productoCarrito PR
	SET @IdCarritoProductos=@@IDENTITY;

	

	UPDATE CARRITO SET Carrito_Activo='False'
	WHERE Id_Carrito=@IdCarrito

GO 


CREATE PROC PR_Recivo_Compras_Final
	@CodigoDeBarras INT
AS
	SELECT  COMPRAS_FORMA_DE_PAGOyENVIO.Id_CodigoDeBarras,CARRITO_PRODUCTOS.Id_Carrito_Productos,PRODUCTO.Nombre,CARRITO_PRODUCTOS.CantidadProducto,CARRITO_PRODUCTOS.Precio, 
            CARRITO_PRODUCTOS.Descuento,CARRITO_PRODUCTOS.PrecioConDescuento,COMPRAS_FORMA_DE_PAGOyENVIO.DireccionEntrega,COMPRAS_FORMA_DE_PAGOyENVIO.FechaCompras, 
            COMPRAS_FORMA_DE_PAGOyENVIO.Total,COMPRAS_FORMA_DE_PAGOyENVIO.TotalSinDescuento,COMPRAS_FORMA_DE_PAGOyENVIO.EstadoDepago, 
            COMPRAS_FORMA_DE_PAGOyENVIO.Id_Forma_De_Pago,COMPRAS_FORMA_DE_PAGOyENVIO.Id_Forma_De_Envio,CLIENTE.Celular,CLIENTE.CorreoElectronico ,
			CONCAT(USUARIOS.Nombre,' ',USUARIOS.Apellido_Paterno,' ',USUARIOS.Apellido_Materno) as Cliente,COMPRAS_FORMA_DE_PAGOyENVIO.TotalAhorrado ,
			FORMA_DE_ENVIO.Forma_De_Envio,FORMA_DE_PAGO.Forma_De_Pago

	FROM	COMPRAS_FORMA_DE_PAGOyENVIO 
			INNER JOIN CARRITO_PRODUCTOS 
			ON COMPRAS_FORMA_DE_PAGOyENVIO.Id_CodigoDeBarras = CARRITO_PRODUCTOS.Id_CodigoCompra 
			INNER JOIN PRODUCTO 
			ON CARRITO_PRODUCTOS.Id_Producto = PRODUCTO.CodigoProducto 
			INNER JOIN CARRITO 
			ON CARRITO_PRODUCTOS.Id_Carrito = CARRITO.Id_Carrito 
			INNER JOIN CLIENTE 
			ON CARRITO.Id_Cliente = CLIENTE.Id_Cliente 
			INNER JOIN USUARIOS 
			ON CLIENTE.Id_Usuario = USUARIOS.Id_Usuario 
			INNER JOIN FORMA_DE_ENVIO 
			ON COMPRAS_FORMA_DE_PAGOyENVIO.Id_Forma_De_Envio = FORMA_DE_ENVIO.Id_Forma_De_Envio 
			INNER JOIN FORMA_DE_PAGO 
			ON COMPRAS_FORMA_DE_PAGOyENVIO.Id_Forma_De_Pago = FORMA_DE_PAGO.Id_Forma_De_Pago

	WHERE COMPRAS_FORMA_DE_PAGOyENVIO.Id_CodigoDeBarras=@CodigoDeBarras
go


CREATE VIEW Ver_Historial_Recivos

As
	SELECT  COMPRAS_FORMA_DE_PAGOyENVIO.Id_CodigoDeBarras'Codigo de barras', CLIENTE.Id_Cliente'Id Cliente',COMPRAS_FORMA_DE_PAGOyENVIO.FechaCompras'Fecha de compra',COMPRAS_FORMA_DE_PAGOyENVIO.DireccionEntrega'Direccion entrega', 
            COMPRAS_FORMA_DE_PAGOyENVIO.TotalSinDescuento'Total sin descuento',COMPRAS_FORMA_DE_PAGOyENVIO.TotalAhorrado'Ahorrado',COMPRAS_FORMA_DE_PAGOyENVIO.Total'Importe total', 
            COMPRAS_FORMA_DE_PAGOyENVIO.EstadoDepago'Estado pago'
	FROM	COMPRAS_FORMA_DE_PAGOyENVIO 
			INNER JOIN CARRITO_PRODUCTOS 
			ON COMPRAS_FORMA_DE_PAGOyENVIO.Id_CodigoDeBarras = CARRITO_PRODUCTOS.Id_CodigoCompra 
			INNER JOIN CARRITO 
			ON CARRITO_PRODUCTOS.Id_Carrito = CARRITO.Id_Carrito 
			INNER JOIN CLIENTE 
			ON CARRITO.Id_Cliente = CLIENTE.Id_Cliente
go

CREATE PROC PR_Historial_Recivos
	@IdCliente INT
AS
	SELECT [Codigo de barras],[Id Cliente],[Fecha de compra],[Direccion entrega],[Total sin descuento],[Ahorrado],[Importe total],[Estado pago]
	FROM	Ver_Historial_Recivos
	where [Id Cliente]=@IdCliente
	GroUP BY [Codigo de barras],[Id Cliente],[Fecha de compra],[Direccion entrega],[Total sin descuento],[Ahorrado],[Importe total],[Estado pago]
	
go



































-----------------------------------------------------------------
