namespace AbstractFactory
{
    public class FabricaCarrera : Fabrica
    {
        public override Cuadro GetCuadro()
        {
            return new CuadroCarrera();
        }

        public override Manubrio GetManubrio()
        {
            return new ManubrioCarrera();
        }

        public override Rueda GetRueda()
        {
            return new RuedaCarrera();
        }
    }
}
