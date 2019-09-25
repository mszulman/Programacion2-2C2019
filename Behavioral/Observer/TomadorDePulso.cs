using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class TomadorDePulso : Maquina
    {
        public int Pulso { get; private set; }
        public override void Cambiar()
        {
            Pulso = new Random().Next(50, 120);
            Notify();
        }
    }
}
