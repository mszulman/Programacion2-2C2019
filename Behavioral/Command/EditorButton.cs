using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public class EditorButton : Button
    {
        public AbstractCommand Command { get; private set; }

        public void SetCommand(AbstractCommand command)
        {
            this.Command = command;
        }

        public void Ejecutar()
        {
            this.Command.Do();
        }
    }
}
