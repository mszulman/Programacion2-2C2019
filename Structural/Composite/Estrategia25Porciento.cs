using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Estrategia25Porciento : AbstractEstrategiaDeCalculo
    {
        public override decimal CalcularPrecio(decimal precio)
        {
            return precio * (decimal)0.75;
        }
    }
}
