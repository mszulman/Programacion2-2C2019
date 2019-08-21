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
            var categoria = new CategoriaA();
            var empleo = new Empleo(persona, 10, categoria, 10000);

            persona.AddEmpleo(empleo);

            Console.WriteLine(persona.GetNetoTotal());

            Console.ReadLine();
        }
    }
}
