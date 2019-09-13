using SistemaDeInventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario.BL
{
   public class ProductosBL
    {
        public BindingList<Producto> ListadeProductos { get; set; }
        public ProductosBL()
        {
            ListadeProductos = new BindingList<Producto>();
            CrearDatosdePrueba();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;

            foreach (var producto in ListadeProductos)
            {
                if (producto.Id == id)
                {
                    precio = producto.Precio;
                }
            }

            return precio;
        }

        private void CrearDatosdePrueba()
        {

            var categoria1 = new Categoria(1, "Laptops");
            Categoria categoria2 = new Categoria(2, "Accesorios para computadora");
            Categoria categoria3 = new Categoria(3, "Equipo de Oficina");
            Categoria categoria4 = new Categoria(4, "Audio Y Video");
            Categoria categoria5 = new Categoria(5, "Impresoras");

            var producto1 = new Producto(1, "Laptop Lenovo", 9800, "Ceiba", categoria1);
            Producto producto2 = new Producto(2, "Laptop HP", 10200, "SPS", categoria1);
            Producto producto3 = new Producto(3, " Mouse KLip XtreMe", 430, "Tegus", categoria2);
            Producto producto4 = new Producto(4, " Impresora Canon L210", 1800, "Danli", categoria5);
            Producto producto5 = new Producto(5, " Audifono Ultimate Sound", 590, "Tegus", categoria4);
            Producto producto6 = new Producto(6, " Silla Gamer", 1950, "SPS", categoria3);
            Producto producto7 = new Producto(7, "Monitor Dell", 2100,"Ceiba",categoria4);

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
            ListadeProductos.Add(producto4);
            ListadeProductos.Add(producto5);
            ListadeProductos.Add(producto6);
            ListadeProductos.Add(producto7);


        }
    }
}
