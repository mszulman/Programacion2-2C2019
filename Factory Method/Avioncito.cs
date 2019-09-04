using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Avioncito : Juguete
    {
        public override string Jugar()
        {
            return ("Vuela vuela! (sonido de avioncito)");
        }
    }
}
