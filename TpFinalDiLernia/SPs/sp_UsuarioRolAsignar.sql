CREATE OR ALTER PROCEDURE dbo.sp_UsuarioRolAsignar
    @Id_Usuario UNIQUEIDENTIFIER,
    @Id_Permiso UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.UsuarioPermiso WHERE IdUsuario = @Id_Usuario;

    INSERT INTO dbo.UsuarioPermiso (IdUsuario, IdPermiso) VALUES (@Id_Usuario, @Id_Permiso);

    UPDATE dbo.Usuario
    SET    Rol = (SELECT Nombre FROM dbo.Permiso WHERE IdPermiso = @Id_Permiso)
    WHERE  IdUsuario = @Id_Usuario;

    RETURN 1;
END
GO