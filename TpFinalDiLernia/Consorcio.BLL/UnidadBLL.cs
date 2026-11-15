namespace Consorcio.BLL
{
    using Consorcio.BE;
    using Consorcio.DAL;

    public class UnidadBLL
    {
        UnidadDAL unidadDAL = new UnidadDAL();
        public List<Unidad> ConsultarUnidad()
        {
            return unidadDAL.ConsultarUnidades();
        }
        public int InsertarUnidad(Unidad unidad)
        {
            ValidarCampos(unidad);
            return unidadDAL.InsertarUnidad(unidad);
        }
        public int ElimininarUnidad(Guid idunidad)
        {
            return unidadDAL.EliminarUnidad(idunidad);
        }
        public int ModificarUnidad(Unidad unidad)
        {
            ValidarCampos(unidad);
            return unidadDAL.ModificarUnidad(unidad);
        }

        private void ValidarCampos(Unidad unidad)
        {
            if (unidad.Propietario == null || string.IsNullOrWhiteSpace(unidad.Piso) || string.IsNullOrWhiteSpace(unidad.Departamento))
                throw new Exception("Faltan campos obligatorios.");
        }
    }
}
