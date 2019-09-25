using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    class Traumatologo : Medico
    {
        public Termometro Termometro { get; private set; }

        public ListView Target { get; private set; }

        public void SetTarget(Termometro termometro, ListView target)
        {
            Termometro = termometro;
            Target = target;
        }

        public override void Update()
        {
            Target.Items.Add("La temperatura del paciente es " + Termometro.Temperatura);
        }
    }
}
