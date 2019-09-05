using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   public  class Subrayado : AbstractCommand
    {
        public Subrayado(EditorRichTextBox texto) : base(texto)
        {

        }
        public override void Do()
        {
            this.Texto.Subrayado();
        }
        public override void Undo()
        {
            this.Texto.SacarSubrayado();
        }
    }
}
