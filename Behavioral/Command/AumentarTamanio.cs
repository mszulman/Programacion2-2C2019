using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AumentarTamanio : AbstractCommand
    {
        public AumentarTamanio(EditorRichTextBox texto) : base(texto)
        {

        }
        public override void Do()
        {
            this.Texto.AumentarTamanio();
        }
        public override void Undo()
        {
            this.Texto.ReducirTamanio();
        }
    }
}
