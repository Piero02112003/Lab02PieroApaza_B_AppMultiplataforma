using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product;

namespace Lab02PieroApaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto("Producto de prueba", 10.0m, new DateTime(2023, 12, 31), "Descripción de prueba");

            // Información si el producto está vencido
            if (producto.EstaVencido())
            {
                Console.WriteLine("El producto se ha pasado de su fecha, está vencido.");
            }
            else
            {
                Console.WriteLine("El producto sigue vigente, no está vencido.");
            }

            // Precio de venta del producto
            decimal precioVenta = producto.PrecioVenta();
            Console.WriteLine("El precio de venta del producto es: " + precioVenta);
        }
    }
}

   

