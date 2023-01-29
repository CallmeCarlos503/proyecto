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
    /// Lógica de interacción para presentacion_de_Datos.xaml
    /// </summary>
    public partial class presentacion_de_Datos : Window
    {
        public presentacion_de_Datos()
        {
            InitializeComponent();
            try
            {
                


            }catch(Exception ex)
            {

            }
        }
        public class empleados
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
        }

        public class empleados_lista
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                empleados em = new empleados();
                em.Nombre = txtNombre.Text;
                em.Apellido = txtApellido.Text;
                em.Correo = txtCorreo.Text;
                em.Telefono = txtTelefono.Text;
                if(txtNombre.Text=="" || txtApellido.Text=="" || txtCorreo.Text=="" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Rellena los datos solicitados");
                }
                else
                {
                    dataGrid.Items.Add(em);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Existio un error de caracter " + ex);

            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                empleados_lista lista = new empleados_lista();
                lista.Nombre = txtNombre1.Text;
                lista.Apellido = txtApellido1.Text;
                lista.Correo = txtCorreo1.Text;
                lista.Telefono = txtTelefono1.Text;
                if (txtNombre1.Text == "" || txtApellido1.Text == "" || txtCorreo1.Text == "" || txtTelefono1.Text == "")
                {
                    MessageBox.Show("Rellena los datos solicitados");
                }
                else
                {
                    ls.Items.Add(lista);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Existio un error de caracter " + ex);

            }
        }
    }
}
