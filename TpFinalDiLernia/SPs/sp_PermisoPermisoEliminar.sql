CREATE OR ALTER PROCEDURE dbo.sp_PermisoPermisoEliminar
    @Id_Padre UNIQUEIDENTIFIER,
    @Id_Hijo  UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.PermisoPermiso WHERE IdPermisoPadre = @Id_Padre AND IdPermisoHijo = @Id_Hijo;
    RETURN 1;
END
GO