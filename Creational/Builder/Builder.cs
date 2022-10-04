namespace Builder
{
    public abstract class Builder
    {
        public abstract void HacerPozo();
        public abstract void PonerCimientos();
        public abstract void LevantarColumnas();
        public abstract void HacerParedes();
        public abstract void PonerTecho();

        public abstract Casa GetResult();
    }
}
