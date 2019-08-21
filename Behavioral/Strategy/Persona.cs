using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Persona
    {
        private List<Empleo> _empleos;

        public Persona()
        {
            _empleos = new List<Empleo>();
        }

        public void AddEmpleo(Empleo empleo)
        {
            _empleos.Add(empleo);
        }

        public decimal GetNetoTotal()
        {
            var neto = (decimal)0;
            foreach (Empleo empleo in _empleos)
                neto += empleo.CalcularNeto();

            return neto;
        }
    }
}
