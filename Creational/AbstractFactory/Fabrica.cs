using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Fabrica
    {
        public abstract Manubrio GetManubrio();

        public abstract Cuadro GetCuadro();

        public abstract Rueda GetRueda();
    }
}
