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

        private void btnsumar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtn1.Text);
                n2= Convert.ToInt32(txtn2.Text);
                if (n1 >=0 &&  n2>=0)
                {
                    MessageBox.Show("La suma de ambos valores fue de: " + (n1 + n2));
                }
                else
                {
                    MessageBox.Show("Tienen que ser valores positivos");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Los valores no son numericos");

            }


        }

        private void btnRestar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtn1.Text);
                n2 = Convert.ToInt32(txtn2.Text);
                if (n1 >= 0 && n2 >=0)
                {
                    MessageBox.Show("La resta de ambos valores fue de: " + (n1 - n2));
                }
                else
                {
                    MessageBox.Show("Tienen que ser valores mayores o iguales  a 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Los valores no son numericos");

            }
        }
    }
}
