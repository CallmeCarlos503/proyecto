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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejemplos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ejemplo_ventana ej = new ejemplo_ventana(); //! Programacion orientados a objetos, invocacion del formulario ventana
            ej.Show(); //! invocacion de la ventana
        }

        private void btn__Click(object sender, RoutedEventArgs e)
        {
            ejermplos_controles_diseño disenio = new ejermplos_controles_diseño(); 
            disenio.Show();
        }
    }
}
