using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ventas.Modelos;

namespace Ventas.BL
{
   public class ClientesBL
    {
        public List <Cliente> ListadeClientes { get; set; }
        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

          private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "nacionales");
            var categoria2 = new Categoria(2, "extranjeros");

            var cliente1 = new Cliente(1, " Edwin Hernandez ",categoria1, "85931475", "San Pedro Sula");
            var cliente2 = new Cliente(2, " Carlos Turcios",  categoria1, "98671879", "Tegucigalpa");
            var cliente3 = new Cliente(3, " Stephanie Brown", categoria2, "87691456", "Washington Dc");


            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);

          
        }
    }
}
