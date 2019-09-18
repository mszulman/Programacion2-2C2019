using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Singleton.GetInstance();

            Console.WriteLine(s.GetValorActual());
            s.Incrementar();
            s.Incrementar();
            s.Incrementar();

            Console.WriteLine(s.GetValorActual());

            var x = Singleton.GetInstance();
            x.Incrementar();
            x.Incrementar();
            x.Incrementar();
            Console.WriteLine(x.GetValorActual());

            Console.ReadLine();
        }
    }
}
