using System;

namespace Observer
{
    public class Termometro : Maquina
    {
        public decimal Temperatura { get; private set; }

        public Termometro()
        {
            Temperatura = GetTemperatura();
        }

        public override void Cambiar()
        {
            Temperatura = GetTemperatura();
            Notify();
        }

        private decimal GetTemperatura()
        {
            int x = new Random().Next(30, 42);
            int y = new Random().Next(0, 9);

            return x + (y / 10);
        }
    }
}
