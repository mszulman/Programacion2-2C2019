namespace ConsoleApp1
{
    public class Empleo
    {
        private Persona _persona;
        private int _antiguedad;
        private Categoria _categoria;
        private decimal _bruto;

        public int GetAntiguedad()
        {
            return _antiguedad;
        }
        public decimal GetBruto()
        {
            return _bruto;
        }
        public void setCategoria(Categoria c)
        {
            this._categoria = c;
        }

        public Empleo(Persona persona, int antiguedad, Categoria categoria, decimal bruto)
        {
            _persona = persona;
            _antiguedad = antiguedad;
            _categoria = categoria;
            _bruto = bruto;
        }

        public decimal CalcularNeto()
        {
            return _categoria.CalcularNeto(this);
        }
    }
}
