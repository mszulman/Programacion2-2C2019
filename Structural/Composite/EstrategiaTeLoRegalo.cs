namespace Composite
{
    public class EstrategiaTeLoRegalo : AbstractEstrategiaDeCalculo
    {
        public override decimal CalcularPrecio(decimal precio)
        {
            return precio * (decimal)0.1;
        }
    }
}
