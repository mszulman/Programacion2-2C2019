using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();
            var categoriaA = new CategoriaA();
            var categoriaB = new CategoriaB();
            var empleo = new Empleo(persona, 10, categoriaA, 10000);
            //var empleo2 = new Empleo(persona, 23, categoriaA, 70000);

            //persona.AddEmpleo(empleo);

            Console.WriteLine(empleo.CalcularNeto());

            empleo.setCategoria(categoriaB);

            Console.WriteLine(empleo.CalcularNeto());


            Console.ReadLine();
        }
    }
}
