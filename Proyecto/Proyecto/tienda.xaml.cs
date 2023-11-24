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
    /// Lógica de interacción para tienda.xaml
    /// </summary>
    public partial class tienda : Window
    {
        public tienda()
        {
            InitializeComponent();

            // Llena la lista de productos con datos de ejemplo
            List<Producto> productos = ObtenerProductosDeEjemplo();
            productosListBox.ItemsSource = productos;
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
        private void carrito_Click(object sender, RoutedEventArgs e)
        {
            Carrito carrito = new Carrito(productosListBox.ItemsSource as List<Producto>);
            carrito.Show();
        }

        private List<Producto> ObtenerProductosDeEjemplo()
        {
            return new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Camiseta", Precio = 40.99, Imagen = "Imagenes/camiseta.png", Descripcion = "Camiseta equipo Mclaren" },
            new Producto { Id = 2, Nombre = "Sudadera", Precio = 80.99, Imagen = "Imagenes/sudadera.png", Descripcion = "Sudadera equipo Mclaren" },
            // Agrega más productos según sea necesario
        };
        }

        private void MostrarDetalles_Click(object sender, RoutedEventArgs e)
        {
            // Muestra los detalles del producto cuando se hace clic en el botón
            if (sender is Button button && button.Tag is int productId)
            {
                Producto productoSeleccionado = ObtenerProductoPorId(productId);
                if (productoSeleccionado != null)
                {
                    detalleImagen.Source = new BitmapImage(new Uri(productoSeleccionado.Imagen, UriKind.Relative));
                    detalleNombre.Text = productoSeleccionado.Nombre;
                    detalleDescripcion.Text = productoSeleccionado.Descripcion;
                    detallePrecio.Text = $"Precio: {productoSeleccionado.Precio:C}";

                    detallesPanel.Visibility = Visibility.Visible;
                }
            }
        }

        private Producto ObtenerProductoPorId(int productId)
        {
            // Implementa la lógica para obtener un producto por su ID
            // Puedes obtener datos de una base de datos, servicio web, etc.
            return null; // En este ejemplo, devolvemos null
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
    }
}