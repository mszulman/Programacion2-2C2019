using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private int _contador;

        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            lock (_instance)
            {
                if (_instance is null)
                    _instance = new Singleton();

                return _instance;
            }
        }
        private Singleton()
        {
            _contador = 0;
        }

        public void Incrementar()
        {
            _contador++;
        }

        public string GetValorActual()
        {
            return "El valor actual es " + _contador.ToString();
        }
    }
}
