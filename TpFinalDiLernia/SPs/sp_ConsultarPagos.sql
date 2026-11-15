SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_ConsultarPagos
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT  *
	FROM    dbo.Pago pg
			INNER JOIN dbo.Expensas expen ON expen.idExpensas = pg.IdExpensas
	        INNER JOIN dbo.Unidad u      ON u.IdUnidad = expen.IdUnidad
	        INNER JOIN dbo.Propietario p ON p.IdPropietario = u.IdPropietario;
			
END
GO
