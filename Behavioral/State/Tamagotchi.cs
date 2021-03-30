using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Tamagotchi
    {
        //private Estado estado;
        //public Estado getEstado()
        //{
        //    return estado;
        //}
        //private void setEstado(Estado estado)
        //{
        //    this.estado = estado;
        //}
        public Estado Estado { get; private set; }

        public Tamagotchi(Estado estado)
        {
            this.Estado = estado;
        }

        public void Alimentar()
        {
            //this.Estado = this.Estado.Alimentar();
            var siguienteEstado = this.Estado.Alimentar();
            this.Estado = siguienteEstado;
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
