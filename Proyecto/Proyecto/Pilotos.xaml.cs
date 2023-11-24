using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Pilotos.xaml
    /// </summary>
    // Piloto.cs
    public class Piloto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isFavorite;
        public bool IsFavorite
        {
            get { return isFavorite; }
            set
            {
                isFavorite = value;
                OnPropertyChanged(nameof(IsFavorite));
            }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                OnPropertyChanged(nameof(Imagen));
            }
        }

        private bool isLiked;
        public bool IsLiked
        {
            get { return isLiked; }
            set
            {
                isLiked = value;
                OnPropertyChanged(nameof(IsLiked));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public partial class Pilotos : Window
    {
        private ObservableCollection<Piloto> pilotos;

        public Pilotos()
        {
            InitializeComponent();

            // Inicializa la lista de pilotos con algunos datos de ejemplo
            pilotos = new ObservableCollection<Piloto>
        {
            new Piloto { Id = 1, Nombre = "Lewis Hamilton", Imagen = "Imagenes/Lewis.png", IsLiked = false },
            new Piloto { Id = 2, Nombre = "Max Verstappen", Imagen = "Imagenes/Max.png", IsLiked = false },
            new Piloto { Id = 2, Nombre = "Fernando Alonso", Imagen = "Imagenes/Alonso.png", IsLiked = false },
            // Agrega más pilotos según sea necesario
        };

            // Asigna la lista de pilotos al ListBox
            PilotosListBox.ItemsSource = pilotos;
        }

        private void LikeButton_Click(object sender, RoutedEventArgs e)
        {
            // Maneja el evento de clic en el botón de "like"
            if (sender is ToggleButton toggleButton && toggleButton.DataContext is Piloto piloto)
            {
                piloto.IsLiked = toggleButton.IsChecked ?? false;
            }
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