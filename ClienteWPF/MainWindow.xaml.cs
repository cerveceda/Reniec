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

namespace ClienteWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            //Llamar al servicio
          
            wpfReniec.wsReniecSoapClient servicio = new wpfReniec.wsReniecSoapClient();
            string dni = txtDNI.Text.Trim();

            //dgvDNI.ItemsSource = (System.Collections.IEnumerable)servicio.BuscarDNI(dni);

            dgvDNI.ItemsSource = (System.Collections.IEnumerable)servicio.BuscarDNI(dni).Tables[0].DefaultView;

        }
    }
}
