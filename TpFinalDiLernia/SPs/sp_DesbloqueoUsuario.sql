SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_DesbloqueoUsuario
	@NombreUsuario NVARCHAR(12)
AS
BEGIN
	
	SET NOCOUNT ON;
	IF EXISTS(SELECT * FROM dbo.Usuario WHERE NombreUsuario = @NombreUsuario)
		BEGIN
			UPDATE dbo.Usuario
			SET Bloqueado = 0, IntentosFallidos = 0
			WHERE NombreUsuario=@NombreUsuario
		END

    
END
GO
