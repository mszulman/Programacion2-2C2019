namespace Factory_Method
{
    public class MoldeAutito : Molde
    {
        public override Juguete Crear()
        {
            return new Autito();
        }
    }
}
