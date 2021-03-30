namespace ConsoleApp1
{
    public class CategoriaB : Categoria
    {
        public override decimal CalcularNeto(Empleo e)
        {
            var resta = e.GetAntiguedad();
            return (((e.GetBruto() * (decimal)0.8) - resta) * (decimal)1.25);
        }
    }
}
