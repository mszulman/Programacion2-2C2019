using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.SetMapper(new BingMaps());

            Console.WriteLine("Mapeando ...");
            Console.WriteLine(client.HaceAlgo());
            Console.WriteLine(client.HaceAlgo());
            Console.WriteLine(client.HaceAlgo());
            Console.WriteLine(client.HaceAlgo());

            client.SetMapper(new Adapter(new GoogleMaps()));

            Console.WriteLine(client.HaceAlgo());
            Console.WriteLine(client.HaceAlgo());
            Console.WriteLine(client.HaceAlgo());
            Console.WriteLine(client.HaceAlgo());

            Console.ReadLine();
        }
    }
}
