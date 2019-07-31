using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas.Modelos
{
   public class Cliente
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion  { get; set; }

        public Cliente(int id, string nombre, Categoria categoria, string telefono, string ciudad)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ciudad = ciudad;
       
          
        }
    }
}
