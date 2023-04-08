using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechadeVencimiento { get; set; }
        public string Descripcion { get; set; }

        public Producto(string nombre, decimal precio, DateTime fechadeVencimiento, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            FechadeVencimiento = fechadeVencimiento;
            Descripcion = descripcion;
        }

        // El producto está vencido
        public bool EstaVencido()
        {
            return DateTime.Now > FechadeVencimiento;
        }

        // Precio de venta con IGV
        public decimal PrecioVenta()
        {
            decimal igv = Precio * 0.18m; 
            return Precio + igv; 
        }
    }

}
