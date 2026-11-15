using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.BE
{
    public class Leaf : Component
    {
        public string Codigo {  get; set; }
        public Leaf(Guid idPermiso, string nombre, string codigo) : base(idPermiso,nombre)
        {
            Codigo = codigo;
        }

        public override void Agregar(Component component)
        {
            throw new InvalidOperationException("Una hoja no puede contener otros permisos");
        }

        public override void Eliminar(Component componente)
        {
            throw new InvalidOperationException("Una hoja no contiene otros permisos.");
        }
        public override List<Component> ObtenerHijos()
        {
            return new List<Component>();   
        }
        public override bool TienePermiso(string codigo)
        {
            return Codigo == codigo;
        }

    }
}
