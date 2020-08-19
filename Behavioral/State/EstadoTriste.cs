using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class EstadoTriste : Estado
    {
        public override string GetNombre()
        {
            return "Para la m...., como queres que este?";
        }
        public override Estado Alimentar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("No, gracias");
            return this;
        }
        public override Estado DarDeTomar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gracias, pero no quiero");
            return this;
        }
        public override Estado HacerMimo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(":)");
            return new EstadoFeliz();
        }
        //public override Estado Pegar()
        //{
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine("ME DUELE!!!");
        //    return new EstadoTriste();
        //}
    }
}
