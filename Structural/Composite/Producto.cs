using System;

namespace Composite
{
    public abstract class Producto
    {

        public string Nombre { get; private set; }

        public Producto(string nombre)
        {
            this.Nombre = nombre;
        }

        public abstract decimal GetPrecio();
        public virtual string ImprimirContenido()
        {
            return Environment.NewLine;
        }
    }
}
