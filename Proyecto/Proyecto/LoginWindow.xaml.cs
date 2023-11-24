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

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void login_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si los campos están llenos
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de iniciar sesión.", "Campos incompletos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Asignar valores a las propiedades de la ventana principal
            Principal principal = new Principal();
            principal.NombreUsuario = txtEmail.Text;  // Puedes ajustar esto según tus necesidades
            principal.CorreoElectronico = txtEmail.Text;  // Puedes ajustar esto según tus necesidades

            // Mostrar la ventana principal
            principal.Show();
            this.Close();
        }
    }
}
