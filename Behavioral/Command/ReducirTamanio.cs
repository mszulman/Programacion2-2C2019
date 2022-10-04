namespace Command
{
    public class ReducirTamanio : AbstractCommand
    {
        public ReducirTamanio(EditorRichTextBox texto) : base(texto)
        {

        }
        public override void Do()
        {
            this.Texto.ReducirTamanio();
        }
        public override void Undo()
        {
            this.Texto.AumentarTamanio();
        }
    }
}
