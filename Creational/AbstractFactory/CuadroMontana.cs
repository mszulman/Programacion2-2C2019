using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CuadroMontana : Cuadro
    {
        public override string GetTextoCuadro()
        {
            return "Soy un Cuadro de Montaña!";
        }
    }
}
