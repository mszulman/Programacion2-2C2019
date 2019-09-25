using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Balanza : Maquina
    {
        public decimal Peso { get; private set; }

        public Balanza()
        {
            Peso = GetPeso();
        }

        public override void Cambiar()
        {
            Peso = GetPeso();
            Notify();
        }

        private decimal GetPeso()
        {
            int x = new Random().Next(50, 120);
            int y = new Random().Next(0, 999);

            return x + (y / 10);
        }
    }
}
