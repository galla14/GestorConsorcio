SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_ConsultarPropietarios
	
AS
BEGIN
	select * from dbo.Propietario
END
GO
