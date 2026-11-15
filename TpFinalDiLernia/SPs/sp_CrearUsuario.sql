SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_CrearUsuario
	@Id_Usuario UNIQUEIDENTIFIER,
	@NombreUsuario NVARCHAR(12),
	@Password NVARCHAR(12),
	@Rol NVARCHAR(50),
	@Activo bit,
	@IntentosFallidos INT,
	@Bloqueado bit,
	@FechaAlta DateTime
AS
BEGIN
	
	SET NOCOUNT ON;

    BEGIN TRY
		IF EXISTS(SELECT * FROM dbo.Usuario WHERE NombreUsuario = @NombreUsuario)
			BEGIN
				RETURN -1;
			END

		INSERT INTO dbo.Usuario
		VALUES(@Id_Usuario,@NombreUsuario,@Password,@Rol,@Activo,@IntentosFallidos,@Bloqueado,@FechaAlta)
		RETURN 1;
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO
