USE Proyecto_MAD;
GO

---STORED PROCEDURES COMPRAS_FORMA_DE_PAGOyENVIO
---Procesos COMPRAS_FORMA_DE_PAGOyENVIO

--Mostrar COMPRAS_FORMA_DE_PAGOyENVIO

CREATE PROC COMPRAS_FORMA_DE_PAGOyENVIO_Mostrar

AS

SELECT 

C.Id_Compras_FormaDePagoyEnvio AS Compras_Forma_De_Pago_y_Envio, B.Id_Compras AS Compras, C.FechaCompras AS FechaCompras, F.Id_Forma_De_Pago AS Forma_De_Pago, E.Id_Forma_De_Envio AS Forma_De_Envio

FROM COMPRAS_FORMA_DE_PAGOyENVIO C

INNER JOIN COMPRAS B

ON C.Id_Compras = B.CodigoDeBarras

INNER JOIN FORMA_DE_PAGO F

ON F.Id_Forma_De_Pago = C.Id_Forma_De_Pago 

INNER JOIN FORMA_DE_ENVIO E

ON E.Id_Forma_De_Envio = C.Id_Forma_De_Envio 

ORDER BY C.Id_Compras_FormaDePagoyEnvio DESC

GO

--Buscar COMPRAS_FORMA_DE_PAGOyENVIO

CREATE PROC COMPRAS_FORMA_DE_PAGOyENVIO_Buscar

  @FormaDeEnvio VARCHAR(50)

SELECT 

C.Id_Compras_FormaDePagoyEnvio AS Compras_Forma_De_Pago_y_Envio, B.Id_Compras AS Compras, C.FechaCompras AS FechaCompras, F.Id_Forma_De_Pago AS Forma_De_Pago, E.Id_Forma_De_Envio AS Forma_De_Envio

FROM COMPRAS_FORMA_DE_PAGOyENVIO C

INNER JOIN COMPRAS B

ON C.Id_Compras = B.CodigoDeBarras

INNER JOIN FORMA_DE_PAGO F

ON F.Id_Forma_De_Pago = C.Id_Forma_De_Pago 

INNER JOIN FORMA_DE_ENVIO E

ON E.Id_Forma_De_Envio = C.Id_Forma_De_Envio 

WHERE C.Id_Compras_FormaDePagoyEnvio LIKE '&'+@FormaDeEnvio+'&'
GO

--Agregar COMPRAS_FORMA_DE_PAGOyENVIO

CREATE PROC COMPRAS_FORMA_DE_PAGOyENVIO_Agregar
  @Id_Compras_FormaDePagoyEnvio INT,
  @Id_Compras INT,
  @FechaCompras DATE,
  @Id_Forma_De_Pago INT,
  @Id_Forma_De_Envio INT 

AS
  INSERT INTO COMPRAS_FORMA_DE_PAGOyENVIO(Id_Compras_FormaDePagoyEnvio, Id_Compras, FechaCompras, Id_Forma_De_Pago, Id_Forma_De_Envio)
  VALUES(@Id_Compras_FormaDePagoyEnvio, @Id_Compras, @FechaCompras, @Id_Forma_De_Pago, @Id_Forma_De_Envio)
GO

--Editar COMPRAS_FORMA_DE_PAGOyENVIO

CREATE PROC COMPRAS_FORMA_DE_PAGOyENVIO_Editar
  @Id_Compras_FormaDePagoyEnvio INT,
  @Id_Compras INT,
  @FechaCompras DATE,
  @Id_Forma_De_Pago INT,
  @Id_Forma_De_Envio INT 
AS
  UPDATE COMPRAS_FORMA_DE_PAGOyENVIO SET Id_Compras_FormaDePagoyEnvio = @Id_Compras_FormaDePagoyEnvio, Id_Compras =  @Id_Compras, FechaCompras = @FechaCompras, Id_Forma_De_Pago = @Id_Forma_De_Pago, Id_Forma_De_Envio = @Id_Forma_De_Envio
  WHERE Id_Compras_FormaDePagoyEnvio = @Id_Compras_FormaDePagoyEnvio
GO

--Eliminar COMPRAS_FORMA_DE_PAGOyENVIO

CREATE PROC COMPRAS_FORMA_DE_PAGOyENVIO_Eliminar
  @Id_Compras_FormaDePagoyEnvio INT
AS
  DELETE FROM COMPRAS_FORMA_DE_PAGOyENVIO
  WHERE Id_Compras_FormaDePagoyEnvio = @Id_Compras_FormaDePagoyEnvio
GO