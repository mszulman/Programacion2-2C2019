using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class AbstractEstrategiaDeCalculo
    {
        public abstract decimal CalcularPrecio(decimal precio);
    }
}
