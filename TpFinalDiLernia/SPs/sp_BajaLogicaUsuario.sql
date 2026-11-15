SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_BajaLogicaUsuario
	@NombreUsuario NVARCHAR(12)
AS
BEGIN
	
	IF NOT EXISTS(SELECT * FROM dbo.Usuario WHERE NombreUsuario = @NombreUsuario)
		BEGIN
			return -1;
		END

	SET NOCOUNT ON;
	UPDATE dbo.Usuario
	SET Activo = 0
	WHERE NombreUsuario = @NombreUsuario

	return 1;
END
GO
