using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Abstract Subject
    public abstract class Maquina
    {
        private List<Medico> _observers = new List<Medico>();

        public void Suscribir(Medico medico)
        {
            _observers.Add(medico);
        }

        public void Desuscribir(Medico medico)
        {
            _observers.Remove(medico);
        }

        public void Notify()
        {
            foreach (var medico in _observers)
                medico.Update();
        }

        // Metodos fuera del patrón, para poder implementarlo y que funcione
        public abstract void Cambiar();
    }
}
