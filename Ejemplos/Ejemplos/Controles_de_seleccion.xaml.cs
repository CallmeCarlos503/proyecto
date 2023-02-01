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
    /// Lógica de interacción para Controles_de_seleccion.xaml
    /// </summary>
    public partial class Controles_de_seleccion : Window
    {
        public Controles_de_seleccion()
        {
            InitializeComponent();
            var colores = new List<string>()
            {
                "Rojo",
                "Amarillo",
                "Azul",
                "Verde",
                "Negro",
                "Blanco"
            };
            cbo_color.ItemsSource = colores;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string color = Convert.ToString(cbo_color.Text);
            MessageBox.Show("Su color es: "+color); //! Mensaje resultante

        }

        
    }
}
