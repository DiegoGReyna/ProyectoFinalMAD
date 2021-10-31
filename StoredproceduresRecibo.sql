USE Proyecto_MAD;
Go

---Procesos Recibo

--Mostrar Recibo
CREATE PROC Recibo_Mostrar
AS
SELECT 
R.Id_Recibo AS Recibo, C.Id_Carrito_Productos AS CarritoProductos, P.Id_Compras_FormaDePagoyEnvio AS FormaDePagoyEnvio
	FROM RECIBO R 
	INNER JOIN CARRITO_PRODUCTOS C 
	ON R.Id_Carrito_Productos = C.Id_Carrito_Productos
	INNER JOIN EMPLEADO P
	ON R.Id_Compras_FormaDePagoyEnvio = P.Id_Compras_FormaDePagoyEnvio
	ORDER BY R.Id_Recibo DESC 
GO

--Buscar Recibo

CREATE PROC Recibo_Buscar
	@Recibo	VARCHAR(50)
AS
SELECT 
R.Id_Recibo AS Recibo, C.Id_Carrito_Productos AS CarritoProductos, P.Id_Compras_FormaDePagoyEnvio AS FormaDePagoyEnvio
	FROM RECIBO R 
	INNER JOIN CARRITO_PRODUCTOS C 
	ON R.Id_Carrito_Productos = C.Id_Carrito_Productos
	INNER JOIN EMPLEADO P
	ON R.Id_Compras_FormaDePagoyEnvio = P.Id_Compras_FormaDePagoyEnvio
	WHERE R.Id_Recibo LIKE '&' +@Recibo+'&' 
	ORDER BY R.Id_Recibo ASC
GO