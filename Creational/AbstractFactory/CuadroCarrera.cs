using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CuadroCarrera : Cuadro
    {
        public override string GetTextoCuadro()
        {
            return "Soy un Cuadro de Carrera!";
        }
    }
}
