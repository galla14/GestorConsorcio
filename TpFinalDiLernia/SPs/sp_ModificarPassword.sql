SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_ModificarPassword
	@Id_Usuario uniqueidentifier,
	@NombreUsuario NVARCHAR(12),
	@Password NVARCHAR(12)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM dbo.Usuario WHERE (NombreUsuario = @NombreUsuario AND IdUsuario=@Id_Usuario))
			BEGIN
				RETURN -1;
			END

		UPDATE dbo.Usuario
		SET Password = @Password
		WHERE IdUsuario = @Id_Usuario
	END TRY
	BEGIN CATCH
		THROW
	END CATCH

END
GO
