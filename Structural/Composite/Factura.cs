using System;
using System.Collections.Generic;

namespace Composite
{
    public class Factura
    {
        private List<ItemFactura> _items;

        public Factura()
        {
            this._items = new List<ItemFactura>();
        }

        public void AddItem(Producto producto, int cantidad)
        {
            this._items.Add(new ItemFactura(producto, cantidad));
        }

        public void ImprimirFactura()
        {
            Console.WriteLine("Factura");
            Console.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine();

            var total = (decimal)0;
            foreach (ItemFactura item in this._items)
            {
                Console.WriteLine(item.GetLineaFactura());
                total += item.GetPrecioItem();
            }
            Console.WriteLine();
            Console.WriteLine("Total: $" + total);

            //this._items.ForEach(item => Console.WriteLine(item.GetLineaFactura()));

            Console.ReadLine();
        }
    }

    public class ItemFactura
    {
        public Producto Producto { get; private set; }
        public int Cantidad { get; private set; }

        public ItemFactura(Producto producto, int cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
        }

        public decimal GetPrecioItem()
        {
            return Producto.GetPrecio() * this.Cantidad;
        }
        public string GetLineaFactura()
        {
            string retorno = Cantidad + " x " + Producto.Nombre + " ($ " + Producto.GetPrecio() + ") = $" + GetPrecioItem();
            retorno += Producto.ImprimirContenido();
            return retorno;

        }
    }
}
