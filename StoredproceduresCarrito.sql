USE Proyecto_MAD;
GO

---STORED PROCEDURES CARRITO
---Procesos Carrito

--Mostrar Carrito

CREATE PROC Carrito_Mostrar
AS
  SELECT C.Id_Carrito AS Carrito, E.Id_Cliente AS Cliente
  FROM CARRITO C
  INNER JOIN CLIENTE E
  ON C.Id_Cliente = E.Id_Cliente
  ORDER BY C.Id_Carrito DESC
GO

--Buscar Carrito

CREATE PROC Carrito_Buscar
@Carrito INT
AS
  SELECT C.Id_Carrito AS Carrito, E.Id_Cliente AS Cliente
  FROM CARRITO C
  INNER JOIN CLIENTE E
  ON C.Id_Cliente = E.Id_Cliente
  WHERE C.Id_Carrito LIKE '&' +@Carrito+'&'
  ORDER BY C.Id_Carrito ASC   
GO

--Agregar Carrito

CREATE PROC Carrito_Agregar
  @Id_Carrito INT
  @Id_Cliente INT 
AS
  INSERT INTO CARRITO(Id_Carrito, Id_Cliente)
  VALUES(@Id_Carrito, @Id_Cliente)
GO

--Editar Carrito

CREATE PROC Carrito_Editar
  @Id_Carrito INT
  @Id_Cliente INT 
AS
UPDATE CARRITO SET Id_Carrito = @Id_Carrito, Id_Cliente = @Id_Cliente
WHERE Id_Carrito = @Id_Carrito
GO

--Eliminar Carrito

CREATE PROC Carrito_Eliminar
  @Id_Carrito INT
AS
  DELETE FROM CARRITO
  WHERE Id_Carrito = @Id_Carrito
GO