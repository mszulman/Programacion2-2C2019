namespace Composite
{
    public class Estrategia10Porciento : AbstractEstrategiaDeCalculo
    {
        public override decimal CalcularPrecio(decimal precio)
        {
            return precio * (decimal)0.9;
        }
    }
}
