USE GestorConsorcio;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE sp_InsertarPropietario
	@Id_Propietario UNIQUEIDENTIFIER,
	@Nombre         NVARCHAR(50),
	@Apellido       NVARCHAR(50),
	@Dni            NVARCHAR(15),
	@NroCelular     NVARCHAR(20)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		-- Id duplicado
		IF EXISTS (SELECT 1 FROM dbo.Propietario WHERE IdPropietario = @Id_Propietario)
			RETURN -1;

		-- DNI duplicado
		IF EXISTS (SELECT 1 FROM dbo.Propietario WHERE Dni = @Dni)
			RETURN -2;

		INSERT INTO dbo.Propietario (IdPropietario, Nombre, Apellido, Dni, NroCelular)
		VALUES (@Id_Propietario, @Nombre, @Apellido, @Dni, @NroCelular);

		RETURN 1;
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO