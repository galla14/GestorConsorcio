using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Consorcio.BE
{
    public class Unidad
    {
        
        public Guid idUnidad {  get; set; }
        public Propietario Propietario { get; set; }
        //public Guid idPropietario { get; set; }
        public string Piso {  get; set; }
        public string Departamento { get; set; }
        public float MedidaDpto {  get; set; }
        public bool AptoAlquiler { get; set; }
        public bool Alquilado { get; set; }
        public Unidad(Guid idUnidad, Propietario propietario, string piso, string departamento, float medidaDpto, bool aptoAlquiler, bool alquilado)
        {
            this.idUnidad = idUnidad;
            Propietario = propietario;
            Piso = piso;
            Departamento = departamento;
            MedidaDpto = medidaDpto;
            AptoAlquiler = aptoAlquiler;
            Alquilado = alquilado;
        }

        public Unidad(Propietario propietario, string piso, string departamento, float medidaDpto, bool aptoAlquiler, bool alquilado)
        {
            Propietario = propietario;
            Piso = piso;
            Departamento = departamento;
            MedidaDpto = medidaDpto;
            AptoAlquiler = aptoAlquiler;
            Alquilado = alquilado;
        }

        public string NombreCompleto
        {
            get { return Piso + " , " + Departamento; }
        }
        public override string ToString()
        {
            return Piso + ", " + Departamento;
        }
    }
}
