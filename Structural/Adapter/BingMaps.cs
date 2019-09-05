using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BingMaps
    {
        public virtual string GetMap(int latitud, int longitud)
        {
            return "Soy Bing y te devuelvo un mapa!";
        }
    }
}
