namespace Command
{
    public abstract class AbstractCommand
    {
        protected EditorRichTextBox Texto { get; private set; }

        public AbstractCommand(EditorRichTextBox texto)
        {
            this.Texto = texto;
        }

        public abstract void Do();

        public abstract void Undo();
    }
}
