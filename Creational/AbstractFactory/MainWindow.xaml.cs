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

namespace AbstractFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Fabrica _fabrica;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            _fabrica = new FabricaCiudad();
        }

        private void RbCiudad_Checked(object sender, RoutedEventArgs e)
        {
            _fabrica = new FabricaCiudad();
        }

        private void RbCarrera_Checked(object sender, RoutedEventArgs e)
        {
            _fabrica = new FabricaCarrera();
        }

        private void RbMontana_Checked(object sender, RoutedEventArgs e)
        {
            _fabrica = new FabricaMontana();
        }

        private void BtRueda_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Add(_fabrica.GetRueda().GetTextoRueda());
        }

        private void BtCuadro_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Add(_fabrica.GetCuadro().GetTextoCuadro());
        }

        private void BtManubrio_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Add(_fabrica.GetManubrio().GetTextoManubrio());
        }
    }
}
