using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
