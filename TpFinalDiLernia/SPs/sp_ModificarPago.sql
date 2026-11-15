SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_ModificarPago
	@Id_Pago UNIQUEIDENTIFIER,
	@Id_Expensa UNIQUEIDENTIFIER,
	@FechaPago DATETIME,
	@Monto DECIMAL (12,2),
	@MedioPago NVARCHAR(50),
	@NroComprobante INT,
	@Observaciones NVARCHAR(50)
AS
BEGIN
	
	SET NOCOUNT ON;

	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM dbo.Pago WHERE IdPago = @Id_Pago)
			BEGIN
				RETURN -1;
			END

		UPDATE dbo.Pago
		SET
			IdExpensas = @Id_Expensa,
			FechaPago = @FechaPago,
			Monto = @Monto,
			MedioPago = @MedioPago,
			NroComprobante = @NroComprobante,
			Observaciones = @Observaciones
		WHERE IdPago = @Id_Pago
	END TRY
	BEGIN CATCH
		THROW
	END CATCH

END
GO
