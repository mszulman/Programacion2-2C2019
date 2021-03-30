using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class Form1 : Form
    {
        private Stack<AbstractCommand> _historial;
        private List<AbstractCommand> _comandosTitulo;

        public Form1()
        {
            InitializeComponent();

            _historial = new Stack<AbstractCommand>();

            _comandosTitulo = new List<AbstractCommand>();
            _comandosTitulo.Add(new Negrita(this.richTextBox1));
            _comandosTitulo.Add(new Subrayado(this.richTextBox1));
            _comandosTitulo.Add(new AumentarTamanio(this.richTextBox1));
            _comandosTitulo.Add(new AumentarTamanio(this.richTextBox1));
            _comandosTitulo.Add(new AumentarTamanio(this.richTextBox1));
            _comandosTitulo.Add(new AumentarTamanio(this.richTextBox1));
            _comandosTitulo.Add(new AumentarTamanio(this.richTextBox1));
            _comandosTitulo.Add(new AumentarTamanio(this.richTextBox1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btNegrita.SetCommand(new Negrita(this.richTextBox1));
            this.btItalica.SetCommand(new Italica(this.richTextBox1));
            this.btSubrayado.SetCommand(new Subrayado(this.richTextBox1));
            this.btAumentarTamanio.SetCommand(new AumentarTamanio(this.richTextBox1));
            this.btReducirTamanio.SetCommand(new ReducirTamanio(this.richTextBox1));
        }

        private void btNegrita_Click(object sender, EventArgs e)
        {
            var boton = ((EditorButton)sender);
            boton.Ejecutar();

            _historial.Push(boton.Command);
        }

        private void btItalica_Click(object sender, EventArgs e)
        {
            var boton = ((EditorButton)sender);
            boton.Ejecutar();

            _historial.Push(boton.Command);
        }

        private void btSubrayado_Click(object sender, EventArgs e)
        {
            var boton = ((EditorButton)sender);
            boton.Ejecutar();

            _historial.Push(boton.Command);
        }

        private void btAumentarTamanio_Click(object sender, EventArgs e)
        {
            var boton = ((EditorButton)sender);
            boton.Ejecutar();

            _historial.Push(boton.Command);
        }

        private void btReducirTamanio_Click(object sender, EventArgs e)
        {
            var boton = ((EditorButton)sender);
            boton.Ejecutar();

            _historial.Push(boton.Command);
        }

        private void btDeshacer_Click(object sender, EventArgs e)
        {
            if (_historial.Count() > 0)
            {
                var command = _historial.Pop();
                command.Undo();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _comandosTitulo.ForEach(x => x.Do());
        }
    }
}
