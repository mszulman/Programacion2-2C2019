namespace Command
{
    public class SacarSubrayado : AbstractCommand
    {
        public SacarSubrayado(EditorRichTextBox texto) : base(texto)
        {

        }
        public override void Do()
        {
            this.Texto.SacarSubrayado();
        }
        public override void Undo()
        {
            this.Texto.Subrayado();
        }
    }
}
