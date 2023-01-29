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
    /// Lógica de interacción para ejemplo_ventana.xaml
    /// </summary>
    public partial class ejemplo_ventana : Window
    {
        public ejemplo_ventana()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }
    }
}
