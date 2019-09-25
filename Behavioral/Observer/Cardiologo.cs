using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public class Cardiologo : Medico
    {
        public TomadorDePulso TomadorDePulso { get; private set; }

        public Termometro Termometro { get; private set; }

        public ListView Target { get; private set; }

        public void SetTarget(TomadorDePulso tomadorDePulso, Termometro termometro, ListView target)
        {
            TomadorDePulso = tomadorDePulso;
            Termometro = termometro;
            Target = target;
        }

        public override void Update()
        {
            Target.Items.Add("El pulso del paciente es " + TomadorDePulso.Pulso);
            Target.Items.Add("La temperatura del paciente es " + Termometro.Temperatura);
        }
    }
}
