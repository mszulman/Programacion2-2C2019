namespace AbstractFactory
{
    public class FabricaMontana : Fabrica
    {
        public override Cuadro GetCuadro()
        {
            return new CuadroMontana();
        }

        public override Manubrio GetManubrio()
        {
            return new ManubrioMontana();
        }

        public override Rueda GetRueda()
        {
            return new RuedaMontana();
        }
    }
}
