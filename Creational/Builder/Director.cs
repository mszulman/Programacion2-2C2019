namespace Builder
{
    public class Director
    {
        public Builder Builder { get; private set; }

        public Director(Builder builder)
        {
            this.Builder = builder;
        }

        public Casa Construir()
        {
            this.Builder.HacerPozo();
            this.Builder.PonerCimientos();
            this.Builder.LevantarColumnas();
            this.Builder.HacerParedes();
            this.Builder.PonerTecho();

            return this.Builder.GetResult();
        }
    }
}
