using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FabricaCarrera : Fabrica
    {
        public override Cuadro GetCuadro()
        {
            return new CuadroCarrera();
        }

        public override Manubrio GetManubrio()
        {
            return new ManubrioCarrera();
        }

        public override Rueda GetRueda()
        {
            return new RuedaCarrera();
        }
    }
}
