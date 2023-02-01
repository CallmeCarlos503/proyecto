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
using System.Windows.Shapes;

namespace Ejemplos
{
    /// <summary>
    /// Lógica de interacción para Control_de_Accion.xaml
    /// </summary>
    public partial class Control_de_Accion : Window
    {
        public Control_de_Accion()
        {
            InitializeComponent();
            img_guapo.Visibility = Visibility.Hidden;
            txtB_HolaMundo.Visibility = Visibility.Hidden; 
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            img_guapo.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtB_HolaMundo.Visibility=Visibility.Visible;
        }
    }
}
