using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class GoogleMaps
    {
        public object DameMapa(string longitud, int latitud)
        {
            return "Hello, my name is google, nice to meet you";
        }
    }
}
