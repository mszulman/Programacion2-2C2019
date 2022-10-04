using System;

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
            Console.WriteLine(x.GetValorActual());
            x.Incrementar();
            x.Incrementar();
            x.Incrementar();
            Console.WriteLine(x.GetValorActual());

            Console.ReadLine();
        }
    }
}
