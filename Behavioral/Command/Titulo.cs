namespace Command
{
    public class Titulo : AbstractCommand
    {
        public Titulo(EditorRichTextBox texto) : base(texto)
        {

        }
        public override void Do()
        {
            this.Texto.AumentarTamanio();
            this.Texto.AumentarTamanio();
            this.Texto.AumentarTamanio();
            this.Texto.AumentarTamanio();
            this.Texto.AumentarTamanio();
            this.Texto.Negrita();
            this.Texto.Subrayado();
        }
        public override void Undo()
        {
            this.Texto.SacarSubrayado();
            this.Texto.SacarNegrita();
            this.Texto.ReducirTamanio();
            this.Texto.ReducirTamanio();
            this.Texto.ReducirTamanio();
            this.Texto.ReducirTamanio();
            this.Texto.ReducirTamanio();
        }
    }
}
