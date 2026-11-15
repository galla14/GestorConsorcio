SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE dbo.sp_RolEliminar
    @Id_Permiso UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.UsuarioPermiso WHERE IdPermiso = @Id_Permiso)
        RETURN -1;

    IF EXISTS (SELECT 1 FROM dbo.PermisoPermiso WHERE IdPermisoHijo = @Id_Permiso)
        RETURN -2;

    DELETE FROM dbo.PermisoPermiso WHERE IdPermisoPadre = @Id_Permiso;
    DELETE FROM dbo.Permiso        WHERE IdPermiso = @Id_Permiso AND EsFamilia = 1;
    RETURN 1;
END
GO