namespace Command
{
    public class Italica : AbstractCommand
    {
        public Italica(EditorRichTextBox texto) : base(texto)
        {

        }
        public override void Do()
        {
            this.Texto.Italica();
        }
        public override void Undo()
        {
            this.Texto.SacarItalica();
        }
    }
}
