﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ManubrioCarrera : Manubrio
    {
        public override string GetTextoManubrio()
        {
            return "Soy un Manubrio de Carrera!";
        }
    }
}
