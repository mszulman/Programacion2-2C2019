using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Producto
    {
       
        public string Nombre { get; private set; }

        public Producto(string nombre)
        {
            this.Nombre = nombre;
        }

        public abstract decimal GetPrecio();
    }
}
