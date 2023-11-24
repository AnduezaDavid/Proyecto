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
    /// Lógica de interacción para Noticias.xaml
    /// </summary>
    public partial class Noticias : Window
    {
        public Noticias()
        {
            InitializeComponent();
            // Especifica la URL de la página web que deseas cargar
            string url = "https://www.formula1.com/en/latest.html";

            // Carga la página web en el WebBrowser
            webBrowser.Navigate(new Uri(url));
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
    }
}
