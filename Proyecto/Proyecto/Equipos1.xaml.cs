// Equipos.xaml.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Proyecto
{
    public partial class Equipos1 : Page
    {
        public Equipos1(string selectedTeam)
        {
            InitializeComponent();

            // Asigna la imagen según el equipo seleccionado
            string imagePath = GetImagePath(selectedTeam);
            EquipoImage.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
        }

        private string GetImagePath(string team)
        {
            // Implementa la lógica para obtener la ruta de la imagen según el equipo
            // Puedes usar un switch o un diccionario para mapear equipos a rutas de imágenes
            switch (team)
            {
                case "RedBull":
                    return "Imagenes/RedBull.png";
                case "AstonMartin":
                    return "Imagenes/AstonMartin.png";
                case "Ferrari":
                    return "Imagenes/Ferrari.png";
                default:
                    return "Imagenes/Default.png";
            }
        }
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
        private void noticias_Click(object sender, RoutedEventArgs e)
        {
            Noticias noticias = new Noticias();
            noticias.Show();
            this.Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
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
    }
}
