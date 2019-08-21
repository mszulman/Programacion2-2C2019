using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Tamagotchi
    {
        public Estado Estado { get; private set; }

        public Tamagotchi(Estado estado)
        {
            this.Estado = estado;
        }

        public void Alimentar()
        {
            this.Estado = this.Estado.Alimentar();
        }
        public void DarDeTomar()
        {
            this.Estado = this.Estado.DarDeTomar();
        }
        public void HacerMimo()
        {
            this.Estado = this.Estado.HacerMimo();
        }
        public void Pegar()
        {
            this.Estado = this.Estado.Pegar();
        }

        public string ComoEstas()
        {
            return this.Estado.GetNombre();
        }
    }
}
