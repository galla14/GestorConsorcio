CREATE OR ALTER PROCEDURE dbo.sp_ConsultarTodosUsuarios
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM   dbo.Usuario
    ORDER BY NombreUsuario;
END
GO