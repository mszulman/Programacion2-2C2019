﻿using System;

namespace State
{
    public class EstadoHambriento : Estado
    {
        public override string GetNombre()
        {
            return "Bien, pero me pica el bagre";
        }
        public override Estado Alimentar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Que Rico!!!");
            return new EstadoFeliz();
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
            Console.WriteLine(":) (pero sigo teniendo hambre)");
            return this;
        }
    }
}