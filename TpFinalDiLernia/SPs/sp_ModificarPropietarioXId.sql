SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_ModificarPropietarioXId
	@Id_Propietario UNIQUEIDENTIFIER,
	@Nombre NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@Dni NVARCHAR(50),
	@NroCelular NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		IF NOT EXISTS(select * from dbo.Propietario where IdPropietario = @Id_Propietario)
			BEGIN
				return -2;
			END

		UPDATE dbo.Propietario
		SET 
			Nombre = @Nombre, 
			Apellido =@Apellido, 
			dni = @Dni,
			NroCelular = @NroCelular
		WHERE IdPropietario = @Id_Propietario

		return 1;

	END TRY
	BEGIN CATCH 
		THROW;
	END CATCH

END
GO
