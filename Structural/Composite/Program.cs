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
            var estrategia = new EstrategiaTeLoRegalo();


            var mcChombo1 = new ProductoCompuesto("Chombo 1", estrategia);
            mcChombo1.AddProducto(hamburguesa);
            mcChombo1.AddProducto(papas);
            mcChombo1.AddProducto(gaseosa);

            // Configuración de Mc Chombo
            var estrategia2 = new Estrategia10Porciento();


            var mcChombo2 = new ProductoCompuesto("Chombo 2", estrategia2);
            mcChombo2.AddProducto(hamburguesa);
            mcChombo2.AddProducto(papas);
            mcChombo2.AddProducto(gaseosa);

            // Configuración de Factura (Pedido)
            var factura = new Factura();
            factura.AddItem(mcChombo1, 2);
            factura.AddItem(mcChombo2, 1);
            //factura.AddItem(hamburguesa, 1);
            //factura.AddItem(papas, 2);

            factura.ImprimirFactura();
        }
    }
}
