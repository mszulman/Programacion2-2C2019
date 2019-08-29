using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var hamburguesa = new ProductoSimple("Big Mac", 50);
            var papas = new ProductoSimple("Papas Fritas", 25);
            var gaseosa = new ProductoSimple("Coca Cola", 10);

            // Configuración de Mc Chombo
            var mcChombo1 = new ProductoCompuesto("Chombo 1");
            mcChombo1.AddProducto(hamburguesa);
            mcChombo1.AddProducto(papas);
            mcChombo1.AddProducto(gaseosa);

            // Configuración de Factura (Pedido)
            var factura = new Factura();
            factura.AddItem(mcChombo1, 1);
            factura.AddItem(hamburguesa, 1);
            factura.AddItem(papas, 2);

            factura.ImprimirFactura();
        }
    }
}
