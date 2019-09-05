using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        public BingMaps Mapper { get; private set; }

        public void SetMapper(BingMaps bingMaps)
        {
            this.Mapper = bingMaps;
        }

        public string HaceAlgo()
        {
            return this.Mapper.GetMap(1, 2);
        }
    }
}
