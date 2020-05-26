using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderEnSeco : Builder
    {
        private Casa _casa;

        public BuilderEnSeco()
        {
            _casa = new Casa();
        }

        public override Casa GetResult()
        {
            return _casa;
        }

        public override void HacerParedes()
        {
            _casa.Paredes = "Paredes En Seco";
        }

        public override void HacerPozo()
        {
            _casa.Pozo = "Pozo En Seco";
        }

        public override void LevantarColumnas()
        {
            _casa.Columnas = "Columnas En Seco";
        }

        public override void PonerCimientos()
        {
            _casa.Cimientos = "Cimientos En Seco";
        }

        public override void PonerTecho()
        {
            _casa.Techo = "Techo En Seco";
        }
    }
}
