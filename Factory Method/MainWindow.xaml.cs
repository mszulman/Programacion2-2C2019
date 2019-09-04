using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Factory_Method
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Maquina _maquina;


        public MainWindow()
        {
            InitializeComponent();

            _maquina = new Maquina(new MoldeAutito());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var juguete = _maquina.Crear();

            listView.Items.Add(juguete.Jugar());
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (_maquina != null)
                _maquina.SetMolde(new MoldeAutito());
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (_maquina != null)
                _maquina.SetMolde(new MoldeAvioncito());
        }
    }
}
