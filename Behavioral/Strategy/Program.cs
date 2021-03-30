using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();
            var categoriaA = new CategoriaA();
            var categoriaB = new CategoriaB();
            var empleo = new Empleo(persona, 10, categoriaB, 10000);
            var empleo2 = new Empleo(persona, 23, categoriaA, 70000);

            persona.AddEmpleo(empleo);
            //persona.AddEmpleo(empleo2);

            Console.WriteLine(persona.GetNetoTotal());

            Console.ReadLine();
        }
    }
}
