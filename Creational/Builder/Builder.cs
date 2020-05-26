using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Builder
    {
        public abstract void HacerPozo();
        public abstract void PonerCimientos();
        public abstract void LevantarColumnas();
        public abstract void HacerParedes();
        public abstract void PonerTecho();

        public abstract Casa GetResult();
    }
}
