namespace Composite
{
    public class ProductoSimple : Producto
    {
        protected decimal _precio;
        public ProductoSimple(string nombre, decimal precio)
            : base(nombre)
        {
            _precio = precio;
        }

        public override decimal GetPrecio()
        {
            return _precio;
        }
    }
}
