namespace AbstractFactory
{
    public abstract class Fabrica
    {
        public abstract Manubrio GetManubrio();

        public abstract Cuadro GetCuadro();

        public abstract Rueda GetRueda();
    }
}
