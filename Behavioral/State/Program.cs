using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //var estadoInicial = new EstadoFeliz();
            //var estadoInicial = new EstadoTriste();
            var estadoInicial = new EstadoHambriento();
            //var estadoInicial = new EstadoSediento();

            var mascotita = new Tamagotchi(estadoInicial);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mascotita, como estas?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(mascotita.ComoEstas());
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Te doy de comer");
            //mascotita.Alimentar();
            Console.WriteLine("Te doy de tomar");
            mascotita.DarDeTomar();
            //Console.WriteLine("Te hago un mimo");
            //mascotita.HacerMimo();
            //Console.WriteLine("Te pego");
            //mascotita.Pegar();

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mascotita, como estas?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(mascotita.ComoEstas());
            Console.ReadLine();
        }
    }
}
