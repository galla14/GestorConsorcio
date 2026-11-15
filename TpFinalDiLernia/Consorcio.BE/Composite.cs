using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.BE
{
    public class Composite : Component
    {
        private List<Component> hijos = new List<Component>();
        public Composite(Guid idPermiso, string nomrbe) : base(idPermiso, nomrbe)
        {
        }

        public override void Agregar(Component component)
        {
            if (component == this)
                throw new InvalidOperationException("Un composite no puede contenerse a sí mismo.");

            
            Composite composite = component as Composite;
            if (composite != null && composite.Contiene(this))
                throw new InvalidOperationException("No se puede agregar: se generaría un ciclo.");

            if (!hijos.Contains(component))
                hijos.Add(component);
        }

        public override void Eliminar(Component component)
        {
            hijos.Remove(component);
        }

        public override List<Component> ObtenerHijos()
        {
            return new List<Component>(hijos);
        }

        public override bool TienePermiso(string codigo)
        {
            foreach (Component hijo in hijos)
            {
                if (hijo.TienePermiso(codigo))
                    return true;
            }
            return false;
        }
        public bool Contiene(Component componente)
        {
            foreach (Component hijo in hijos)
            {
                if (hijo == componente)
                    return true;

                Composite compositeHijo = hijo as Composite;
                if (compositeHijo != null && compositeHijo.Contiene(componente))
                    return true;
            }
            return false;
        }
    }
}
