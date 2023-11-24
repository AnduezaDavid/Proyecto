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
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public Principal()
        {
            InitializeComponent();
            MostrarInformacionUsuario();
        }
        private void noticias_Click(object sender, RoutedEventArgs e)
        {
            Noticias noticias = new Noticias();
            noticias.Show();
            this.Close();
        }
        private void pilotos_Click(object sender, RoutedEventArgs e)
        {
            Pilotos pilotos = new Pilotos();
            pilotos.Show();
            this.Close();
        }
        private void circuitos_Click(object sender, RoutedEventArgs e)
        {
            Circuitos circuitos = new Circuitos();
            circuitos.Show();
            this.Close();
        }
        private void tienda_Click(object sender, RoutedEventArgs e)
        {
            tienda tienda = new tienda();
            tienda.Show();
            this.Close();
        }
        // MainWindow.xaml.cs
        // MainWindow.xaml.cs
        private void TeamsDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtén el nombre del equipo seleccionado
            string selectedTeam = (TeamsDropDown.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Crea un nuevo Frame
            Frame frame = new Frame();

            // Crea una nueva instancia de la página Equipos y asigna el equipo seleccionado
            Equipos1 equiposPage = new Equipos1(selectedTeam);

            // Asigna la página al Frame
            frame.Navigate(equiposPage);

            // Asigna el nuevo Frame al ContentControl
            MainContent.Content = frame;
        }
        private void MostrarInformacionUsuario()
        {
            // Usar las propiedades para mostrar la información en la ventana principal
            txtNombreUsuario.Text = $"Nombre de Usuario: {NombreUsuario}";
            txtCorreoElectrónico.Text = $"Correo Electrónico: {CorreoElectronico}";
        }

    }
}