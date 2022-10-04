namespace Composite
{
    public class Estrategia25Porciento : AbstractEstrategiaDeCalculo
    {
        public override decimal CalcularPrecio(decimal precio)
        {
            return precio * (decimal)0.75;
        }
    }
}
