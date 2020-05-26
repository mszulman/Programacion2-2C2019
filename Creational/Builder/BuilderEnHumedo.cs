using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderEnHumedo : Builder
    {
        private Casa _casa;

        public BuilderEnHumedo()
        {
            _casa = new Casa();
        }

        public override Casa GetResult()
        {
            return _casa;
        }

        public override void HacerParedes()
        {
            _casa.Paredes = "Paredes En Humedo";
        }

        public override void HacerPozo()
        {
            _casa.Pozo = "Pozo En Humedo";
        }

        public override void LevantarColumnas()
        {
            _casa.Columnas = "Columnas En Humedo";
        }

        public override void PonerCimientos()
        {
            _casa.Cimientos = "Cimientos En Humedo";
        }

        public override void PonerTecho()
        {
            _casa.Techo = "Techo En Humedo";
        }
    }
}
