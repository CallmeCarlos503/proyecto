using System;
using System.Collections.Generic;
using System.Drawing;
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
            var Estados = new List<string>()
            {
                "Soltero/a",
                "Casado/a",
                "Viudo/a",
            };
            cbo_estado.ItemsSource = Estados;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string color = Convert.ToString(cbo_color.Text);
            MessageBox.Show("Su color es: "+color); //! Mensaje resultante

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                String region = "";
                if (rd_region.IsChecked == true)
                {
                    region = "El Salvador";
                }
                else if (rd_region1.IsChecked == true)
                {
                    region = "Guatemala";
                }
                else if (rd_region2.IsChecked == true)
                {
                    region = "Honduras";
                }
                else if (rd_region3.IsChecked == true)
                {
                    region = "Nicaragua";
                }
                MessageBox.Show("Su estado civil es " + cbo_estado.Text+" y tu region es de: "+region); //! Mensaje resultante
            }
            catch (Exception ex)
            {
                MessageBox.Show("Causa del error: "+ex); //! Mensaje resultante

            }

        }
    }
}
