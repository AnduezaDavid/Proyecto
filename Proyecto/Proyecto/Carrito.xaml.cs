
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
    /// Lógica de interacción para Carrito.xaml
    /// </summary>
    public partial class Carrito : Window
    {
        private List<Producto> carrito;

        public Carrito(List<Producto> carrito)
        {
            InitializeComponent();

            // Asigna el carrito recibido
            this.carrito = carrito;

            // Llena la lista de productos del carrito
            carritoListBox.ItemsSource = carrito;

            // Calcula y muestra el total del carrito
            CalcularTotalCarrito();
        }

        private void EliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            // Elimina un producto del carrito cuando se hace clic en el botón
            if (sender is Button button && button.Tag is int productId)
            {
                Producto productoAEliminar = carrito.FirstOrDefault(p => p.Id == productId);
                if (productoAEliminar != null)
                {
                    carrito.Remove(productoAEliminar);
                    carritoListBox.Items.Refresh(); // Actualiza la lista de productos en el ListBox
                    CalcularTotalCarrito();
                }
            }
        }
      
        


        private void CalcularTotalCarrito()
        {
            // Calcula el total del carrito sumando los precios de los productos
            double total = carrito.Sum(p => p.Precio);
            totalTextBlock.Text = $"Total: {total:C}";
        }
    }
}