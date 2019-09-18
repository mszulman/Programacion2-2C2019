using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FabricaCiudad : Fabrica
    {
        public override Cuadro GetCuadro()
        {
            return new CuadroCiudad();
        }

        public override Manubrio GetManubrio()
        {
            return new ManubrioCiudad();
        }

        public override Rueda GetRueda()
        {
            return new RuedaCiudad();
        }
    }
}
