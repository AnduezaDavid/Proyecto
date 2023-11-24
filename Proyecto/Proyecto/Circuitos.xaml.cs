using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Circuitos.xaml
    /// </summary>
    public class Circuito
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
    public partial class Circuitos : Window
    {
        private ObservableCollection<Circuito> circuitos;

        public Circuitos()
        {
            InitializeComponent();

            // Inicializa la lista de circuitos con algunos datos de ejemplo
            circuitos = new ObservableCollection<Circuito>
        {
            new Circuito
            {
                Nombre = "Circuito de Mónaco",
                Descripcion = "El Circuito de Mónaco es un circuito urbano situado en las calles de Montecarlo y La Condamine, en el Principado de Mónaco.",
                Imagen = "Imagenes/Monaco.png"
            },
            new Circuito
            {
                Nombre = "Circuito de Silverstone",
                Descripcion = "Silverstone es un circuito de carreras ubicado cerca de la aldea de Silverstone, en Northamptonshire, Inglaterra.",
                Imagen = "Imagenes/Silverstone.png"
            },
            // Agrega más circuitos según sea necesario
        };

            // Asigna la lista de circuitos al ListBox
            CircuitosListBox.ItemsSource = circuitos;
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
