CREATE OR ALTER PROCEDURE dbo.sp_PermisoPermisoInsertar
    @Id_Padre UNIQUEIDENTIFIER,
    @Id_Hijo  UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.PermisoPermiso WHERE IdPermisoPadre = @Id_Padre AND IdPermisoHijo = @Id_Hijo)
        RETURN -1;

    INSERT INTO dbo.PermisoPermiso (IdPermisoPadre, IdPermisoHijo) VALUES (@Id_Padre, @Id_Hijo);
    RETURN 1;
END
GO