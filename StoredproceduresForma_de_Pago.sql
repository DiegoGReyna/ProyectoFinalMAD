USE Proyecto_MAD;
GO

--Stored Procedures Forma_de_Pago
---Mostrar Forma_de_Pago

	CREATE PROC Forma_de_Pago_Mostrar
		AS
		SELECT Id_Forma_De_Pago AS ID , Forma_De_Pago
		FROM FORMA_DE_PAGO 
		ORDER BY Id_Forma_De_Pago DESC
	GO

---Buscar Forma_de_Pago
	
	CREATE PROC Forma_de_Pago_Buscar
	@FormaDePago VARCHAR(50)
		AS
		SELECT Id_Forma_De_Pago as ID , Forma_De_Pago
		FROM FORMA_DE_PAGO
		WHERE Forma_De_Pago like '%' + @FormaDePago + '%'
		ORDER BY Forma_De_Pago ASC
	GO

--- Agregar Forma_de_Pago
 
	CREATE PROC Forma_de_Pago_Insertar
		@Nombre VARCHAR(50)
		AS
		INSERT INTO FORMA_DE_PAGO (Nombre) VALUES(@Nombre)
	GO

---Editar Forma_de_Pago
	CREATE PROC Forma_de_Pago
		@Id_Forma_De_Pago  INT,
		@Forma_De_Pago VARCHAR(50)
		AS
		UPDATE FORMA_DE_PAGO SET Nombre =@Nombre
		WHERE Id_Forma_De_Pago = @Id_Forma_De_Pago
	GO   

---Eliminar Forma_de_Pago
	CREATE PROC Forma_de_Pago
		@Id_Forma_De_Pago INT
		AS
		DELETE FROM FORMA_DE_PAGO
		WHERE  Id_Forma_De_Pago = @Id_Forma_De_Pago
	GO