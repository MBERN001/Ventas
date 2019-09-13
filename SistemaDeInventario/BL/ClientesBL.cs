using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeInventario.Modelos;
using System.ComponentModel;

namespace SistemaDeInventario.BL
{
   public class ClientesBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }
        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var cliente1 = new Cliente(01, "Juan Martinez","Danli","90587912");
            var cliente2 = new Cliente(02, "Rosa Bardales", "SPS", "89573298");
            var cliente3 = new Cliente(03, "Carlos Ordonez", "SPS", "91206833");
            var cliente4 = new Cliente(04, "Fernando Carbajal", "Tegus", "96784312");
            var cliente5 = new Cliente(05, "Maria Lombardi", "Ceiba", "88340917");

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
            ListadeClientes.Add(cliente4);
            ListadeClientes.Add(cliente5);

        }
    }
}
