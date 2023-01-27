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
            // todo: try es un sistema de intentos del programa, evita los ererores de cualquier proceso o medida y lo manda a un catch
            try
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtn1.Text); // ? Variable que toma  txtn1 del formulario
                n2 = Convert.ToInt32(txtn2.Text); //?  Variable que toma el valor de txtn2 del formulario
                //! Base logica
                if (n1 >=0 &&  n2>=0)
                {
                    //! Respuesta logica 1
                    MessageBox.Show("La suma de ambos valores fue de: " + (n1 + n2));
                }
                else
                {
                    //! Caso si no existe respuesta logica 1
                    MessageBox.Show("Tienen que ser valores positivos");
                }
                
            }

            catch (Exception ex) //todo: Base de excepcion, si existe un error se activa e evita el proceso de cerrado forzado
            {
                MessageBox.Show("Error: Los valores no son numericos"); //! Msj de error si existe una falla en la aplicacion

            }


        }

        private void btnRestar_Click(object sender, RoutedEventArgs e)
        {
            // todo: try es un sistema de intentos del programa, evita los ererores de cualquier proceso o medida y lo manda a un catch
            try
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtn1.Text); // ? Variable que toma  txtn1 del formulario
                n2 = Convert.ToInt32(txtn2.Text); //?  Variable que toma el valor de txtn2 del formulario

                // ! Base logica
                if (n1 >= 0 && n2 >=0)
                {
                    //! respuesta logica 1
                    MessageBox.Show("La resta de ambos valores fue de: " + (n1 - n2)); 
                }
                else
                {
                    //! sino se cumple la respuesta logica 1
                    MessageBox.Show("Tienen que ser valores mayores o iguales  a 0"); //! repuesta logica sino
                }
            }
            catch (Exception ex) //todo: Base de excepcion, si existe un error se activa e evita el proceso de cerrado forzado

            {
                MessageBox.Show("Error: Los valores no son numericos"); //! Mensaje de error si existe una falla en la aplicacion

            }
        }
    }
}
