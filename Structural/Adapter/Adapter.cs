using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : BingMaps
    {
        private GoogleMaps _googleMaps;

        public Adapter(GoogleMaps googleMaps)
        {
            this._googleMaps = googleMaps;
        }

        public override string GetMap(int latitud, int longitud)
        {
            return (string)_googleMaps.DameMapa(longitud.ToString(), latitud);
        }
    }
}