using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ProductoCompuesto : Producto
    {
        private List<Producto> _productos;

        public ProductoCompuesto(string nombre) : base (nombre)
        {
            _productos = new List<Producto>();
        }

        public void AddProducto (Producto producto)
        {
            _productos.Add(producto);
        }
        public void RemoveProducto(Producto producto)
        {
            _productos.Remove(producto);
        }

        public override decimal GetPrecio()
        {
            decimal precioTotal = 0;

            foreach (Producto producto in _productos)
                precioTotal += producto.GetPrecio();

            //_productos.ForEach(x => precioTotal += x.GetPrecio());

            //var precioTotal = _productos.Sum(x => x.GetPrecio());

            //var precioTotal =
            //    (from producto in _productos
            //    select producto.GetPrecio())
            //    .Sum();

            return precioTotal * (decimal)0.9;
        }
    }
}
