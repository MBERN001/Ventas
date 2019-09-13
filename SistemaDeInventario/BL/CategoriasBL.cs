using SistemaDeInventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario.BL
{
   public class CategoriasBL
    {
       public BindingList<Categoria> ListadeCategorias { get; set; }
       public CategoriasBL()
        {
            ListadeCategorias = new BindingList<Categoria>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios para computadora");
            var categoria3 = new Categoria(3, "Equipo de Oficina");
            var categoria4 = new Categoria(4, "Audio Y Video");
            var categoria5 = new Categoria(5, "Impresoras");


            ListadeCategorias.Add(categoria1);
            ListadeCategorias.Add(categoria2);
            ListadeCategorias.Add(categoria3);
            ListadeCategorias.Add(categoria4);
            ListadeCategorias.Add(categoria5);
        }
    }
}
