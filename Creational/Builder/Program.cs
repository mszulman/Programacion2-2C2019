using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var constructoraEnSeco = new BuilderEnSeco();
            var constructoraEnHumedo = new BuilderEnHumedo();

            //var directorDeObra = new Director(constructoraEnSeco);
            var directorDeObra = new Director(constructoraEnHumedo);

            var casa = directorDeObra.Construir();

            //var casa = constructoraEnSeco.GetResult();
            //var casa = constructoraEnHumedo.GetResult();

            Console.WriteLine(casa.Pozo);
            Console.WriteLine(casa.Cimientos);
            Console.WriteLine(casa.Columnas);
            Console.WriteLine(casa.Paredes);
            Console.WriteLine(casa.Techo);

            Console.ReadLine();
        }
    }
}
