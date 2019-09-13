using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario.Modelos
{
   public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
            

        }
        public Cliente(int id, string nombre, string ciudad, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Ciudad = ciudad;
            Telefono = telefono;
        }
    }
}
