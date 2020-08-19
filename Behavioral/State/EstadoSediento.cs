using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class EstadoSediento : Estado
    {
        public override string GetNombre()
        {
            return "Uffff, tengo una sed que no te imaginas";
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
            Console.WriteLine("Ahhhh");
            return new EstadoFeliz();
        }
        public override Estado HacerMimo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(":) (pero sigo teniendo sed)");
            return this;
        }
        //public override Estado Pegar()
        //{
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine("ME DUELE!!!");
        //    return new EstadoTriste();
        //}
    }
}
