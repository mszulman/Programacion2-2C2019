namespace ConsoleApp1
{
    public class CategoriaA:Categoria
    {
        public override decimal CalcularNeto(Empleo e)
        {
            var resta = e.GetAntiguedad();
            return (e.GetBruto() * (decimal)0.8) - resta;
        }
    }
}
