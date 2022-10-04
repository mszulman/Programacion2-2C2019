﻿using System;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        private TomadorDePulso _tomadorDePulso;
        private Termometro _termometro;
        private Balanza _balanza;

        private Cardiologo _cardiologo;
        private Nutricionista _nutricionista;
        private Traumatologo _traumatologo;

        public Form1()
        {
            InitializeComponent();

            Setup();
        }

        private void Setup()
        {
            _tomadorDePulso = new TomadorDePulso();
            _termometro = new Termometro();
            _balanza = new Balanza();

            _cardiologo = new Cardiologo();
            _nutricionista = new Nutricionista();
            _traumatologo = new Traumatologo();

            _tomadorDePulso.Suscribir(_cardiologo);
            _termometro.Suscribir(_cardiologo);
            _termometro.Suscribir(_traumatologo);
            _balanza.Suscribir(_nutricionista);

            _cardiologo.SetTarget(_tomadorDePulso, _termometro, lvCardiologo);
            _nutricionista.SetTarget(_balanza, lvNutricionista);
            _traumatologo.SetTarget(_termometro, lvTraumatologo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtTomadorDePulso_Click(object sender, EventArgs e)
        {
            _tomadorDePulso.Cambiar();
        }
        private void BtTemperatura_Click(object sender, EventArgs e)
        {
            _termometro.Cambiar();
        }

        private void BtPeso_Click(object sender, EventArgs e)
        {
            _balanza.Cambiar();
        }
    }
}
