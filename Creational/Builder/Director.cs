using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public Builder Builder { get; private set; }

        public Director(Builder builder)
        {
            this.Builder = builder;
        }

        public void Construir()
        {
            this.Builder.HacerPozo();
            this.Builder.PonerCimientos();
            this.Builder.LevantarColumnas();
            this.Builder.HacerParedes();
            this.Builder.PonerTecho();
        }
    }
}
