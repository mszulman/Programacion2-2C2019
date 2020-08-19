using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class Estado
    {
        public abstract string GetNombre();

        public abstract Estado Alimentar();
        public abstract Estado DarDeTomar();
        public abstract Estado HacerMimo();
        //public abstract Estado Pegar();

        //public Estado Alimentar()
        //{
        //    Console.WriteLine("NO TENGO HAMBRE!!!");
        //    return this;
        //}
        //public Estado DarDeTomar()
        //{
        //    Console.WriteLine("NO TENGO SED!!!");
        //    return this;
        //}
        //public Estado HacerMimo()
        //{
        //    Console.WriteLine("NO QUIERO MIMO!!");
        //    return this;
        //}
        public virtual Estado Pegar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ME DUELE!!!!");
            return new EstadoTriste();
        }
    }
}
