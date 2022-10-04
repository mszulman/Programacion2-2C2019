namespace Command
{
    public class Negrita : AbstractCommand
    {
        public Negrita(EditorRichTextBox texto) : base(texto)
        {

        }
        public override void Do()
        {
            this.Texto.Negrita();
        }
        public override void Undo()
        {
            this.Texto.SacarNegrita();
        }
    }
}
