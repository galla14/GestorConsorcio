using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.BE
{
    public abstract class Component
    {
        public Guid IdPermiso {  get; set; }
        public string Nombre { get; set; }

        public Component(Guid idPermiso , string nomrbe)
        {
            IdPermiso = idPermiso;
            Nombre = nomrbe;
        }

        public abstract void Agregar(Component component);
        public abstract void Eliminar(Component component);
        public abstract List<Component> ObtenerHijos();

        public abstract bool TienePermiso(string codigo);
        public override string ToString()
        {
            return Nombre;
        }

    }
}
