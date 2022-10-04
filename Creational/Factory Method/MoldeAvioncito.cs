namespace Factory_Method
{
    public class MoldeAvioncito : Molde
    {
        public override Juguete Crear()
        {
            return new Avioncito();
        }
    }
}
