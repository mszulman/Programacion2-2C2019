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
        private AbstractEstrategiaDeCalculo _estrategiaDeCalculo;

        public ProductoCompuesto(string nombre, AbstractEstrategiaDeCalculo estrategiaDeCalculo) : base (nombre)
        {
            _productos = new List<Producto>();
            _estrategiaDeCalculo = estrategiaDeCalculo;
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

            //_productos.ForEach(producto => precioTotal += producto.GetPrecio());

            //precioTotal = _productos.Sum(producto => producto.GetPrecio());

            //precioTotal =
            //    (from producto in _productos
            //     select producto.GetPrecio())
            //    .Sum();

            return _estrategiaDeCalculo.CalcularPrecio(precioTotal);
        }
    }
}
