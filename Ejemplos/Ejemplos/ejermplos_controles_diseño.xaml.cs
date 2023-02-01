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
    /// Lógica de interacción para ejermplos_controles_diseño.xaml
    /// </summary>
    public partial class ejermplos_controles_diseño : Window
    {
       
        public ejermplos_controles_diseño()
        {
            InitializeComponent();
            canva.Visibility = Visibility.Hidden;
            tbMSJ.Text = ""; //! Reiniciador de mensajes
            //! Agregar valores a la lista del cbo_Genero
            var genero = new List<string>() {
             "Hombre",
             "Mujer",
             "No binario"
            };
            cbo_Genero.ItemsSource = genero; //! Agregado de la lista por genero por medio de una variable
            //! Agregar los valores de comida
            var comida = new List<string>()
            {
                "Hamburguesa",
                "Ensalada",
                "Pizza",
                "Pasteles"
            };

            cbo_comida.ItemsSource = comida; //todo: Agregar el valor de la variable al combo box
        }

        private void cbo_Genero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btn_Generar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String Nombre, Genero,Comida; //! Copiar los datos
                Nombre = Convert.ToString(txtNombre.Text); //! copiar los datos de la caja de texto
                Genero = Convert.ToString(cbo_Genero.Text); //! copiar los datos de la combo box de genero
                Comida = Convert.ToString(cbo_comida.Text); //!Copiar los datos de la combo box de comida
                if(Nombre=="" || Genero==""|| Comida == "")
                {
                    MessageBox.Show("Por favor, llenar por completo el formulario");
                }
                else
                {
                    txtb_msj.Text = "BIENVENIDO \n tu nombre es: " + Nombre + " \n  tu genero es:  " + Genero + "\n Tu comida Favorita es:  " + Comida; //! Mensaje resultante
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Existio un error de caracter "+ex);
            }
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string NombreE; //! Asignador de Nombre del evento
                String Fecha; //! Asignador de fechas
                NombreE = Convert.ToString(txt_evento.Text);
                Fecha = Convert.ToString(txtFecha.Text);
                if(NombreE=="" || Fecha == "")
                {
                    MessageBox.Show("Por favor, llenar por completo el formulario");
                }
                else
                {
                    string msj = "Fecha: " + Fecha + "\n Nombre del evento: " + NombreE;
                    tbMSJ.Text = msj;
                    canva.Visibility = Visibility.Visible;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Existio un error de caracter " + ex);
            }
            
        }
    }
}
