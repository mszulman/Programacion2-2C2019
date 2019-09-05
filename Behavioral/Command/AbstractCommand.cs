using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class AbstractCommand
    {
        public EditorRichTextBox Texto { get; private set; }

        public AbstractCommand(EditorRichTextBox texto)
        {
            this.Texto = texto;
        }

        public abstract void Do();

        public abstract void Undo();
    }
}
