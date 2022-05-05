using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
