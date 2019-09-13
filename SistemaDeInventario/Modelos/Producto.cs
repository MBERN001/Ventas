using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario.Modelos
{
   public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Ubicacion { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public Producto()
        {
            Categoria = new Categoria(1, "Laptops");
            CategoriaId = Categoria.Id;
        }

        public Producto(int id, string descripcion, double precio, string ubicacion,Categoria categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Ubicacion = ubicacion;
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }
    }
}
