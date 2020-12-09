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

namespace Comida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> platos;
        public MainWindow()
        {
            InitializeComponent();
            string ruta = @"C:\Users\ghost\Google Drive\2DAM\DINT\UT5\Proyectos\Comida\Comida";
            platos = Plato.GetSamples(ruta);
            contenedorPrincipal.DataContext = platos;
        }
    }
}
