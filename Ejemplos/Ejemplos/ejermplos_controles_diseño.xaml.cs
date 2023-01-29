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
                MessageBox.Show("Hola "+Nombre+" tu genero es "+Genero+" es un gusto conocerte, me han hablado que te gusta mucho la "+Comida); //! Mensaje resultante
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
                MessageBox.Show("Su evento sera el "+Fecha+" el nombre del evento se constituye en "+NombreE);
                string msj = "𓆝 𓆟 𓆞 𓆝 𓆟 Sus datos se han insertado con exito 𓆝 𓆟 𓆞 𓆝 𓆟";
                tbMSJ.Text= msj;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Existio un error de caracter " + ex);
            }
            
        }
    }
}
