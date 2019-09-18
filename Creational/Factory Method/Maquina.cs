using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Maquina
    {
        public Molde MoldeSeleccionado { get; private set; }

        public Maquina(Molde molde)
        {
            MoldeSeleccionado = molde;
        }

        public void SetMolde(Molde molde)
        {
            MoldeSeleccionado = molde;
        }

        public Juguete Crear()
        {
            return MoldeSeleccionado.Crear();
        }
    }
}
