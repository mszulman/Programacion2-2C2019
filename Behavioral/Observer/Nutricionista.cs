using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public class Nutricionista : Medico
    {
        public Balanza Balanza { get; private set; }

        public ListView Target { get; private set; }

        public void SetTarget(Balanza balanza, ListView target)
        {
            Balanza = balanza;
            Target = target;
        }

        public override void Update()
        {
            Target.Items.Add("El peso del paciente es " + Balanza.Peso);
        }
    }
}