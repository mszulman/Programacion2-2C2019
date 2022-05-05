using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ProductoSimple : Producto
    {
        protected decimal _precio;
        public ProductoSimple(string nombre, decimal precio)
            : base (nombre)
        {
            _precio = precio;
        }

        public override decimal GetPrecio()
        {
            return _precio;
        }
    }
}
