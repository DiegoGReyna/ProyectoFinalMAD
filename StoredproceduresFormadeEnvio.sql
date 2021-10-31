USE Proyecto_MAD;

GO

--Stored Procedures Categoria
---Mostrar Forma_de_Envio

	CREATE PROC Forma_de_Envio_Mostrar
		AS
		SELECT Id_Forma_De_Envio as ID, Forma_De_Envio
		FROM FORMA_DE_ENVIO
		ORDER BY Id_Forma_De_Envio DESC
	GO

---Buscar Forma_de_Envio	
	CREATE PROC Forma_de_Envio_Buscar
	@NombreFormadeEnvio VARCHAR(50)
		AS
		SELECT Id_Forma_De_Envio as ID , Forma_De_Envio
		FROM FORMA_DE_ENVIO
		WHERE Forma_De_Envio like '%' + @NombreFormadeEnvio + '%'
		ORDER BY Forma_De_Envio ASC
	GO

--- Agregar Forma_de_Envio 
	CREATE PROC Forma_de_Envio_Insertar
		@NombreFormadeEnvio VARCHAR(50)
		AS
		INSERT INTO FORMA_DE_ENVIO (NombreFormadeEnvio) VALUES(@NombreFormadeEnvio)
	GO

---Editar Forma_de_Envio
	CREATE PROC Forma_de_Envio_Editar
		@Id_Forma_De_Envio INT,
		@Forma_De_Envio VARCHAR(50)
		AS
		UPDATE FORMA_DE_ENVIO SET Forma_De_Envio =@Forma_De_Envio
		WHERE Id_Forma_De_Envio = @Id_Forma_De_Envio
	GO   

---Eliminar Forma_de_Envio 
	CREATE PROC Forma_de_Envio_Eliminar
		@Id_Forma_De_Envio INT
		AS
		DELETE FROM FORMA_DE_ENVIO
		WHERE  Id_Forma_De_Envio = @Id_Forma_De_Envio
	GO