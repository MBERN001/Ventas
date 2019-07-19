using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = 1;
            cliente.Descripcion = "Cable UTP";
            cliente.Telefono = "98743687";
            cliente.Nombre = "Martha";
            cliente.ciudad = "San Pedro Sula";
            cliente.Direccion = "San Pedro Sula-Cortes";

            Cliente cliente1 = new Cliente();
            cliente1.Id = 2;
            cliente1.Descripcion = "Equipo de sonido";
            cliente1.Telefono = "32389741";
            cliente1.Nombre = "Santos";
            cliente1.ciudad = "Ceiba";
            cliente1.Direccion = "Ceiba-Atlantida";

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Descripcion = "Laptop Dell";
            cliente2.Telefono = "97581473";
            cliente2.Nombre = "Marcos";
            cliente2.ciudad = "Tegucigalpa";
            cliente2.Direccion = "Tegucigalpa-Francisco Morazan";


            var listadeClientes = new List<Cliente>();
            listadeClientes.Add(cliente);
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);

            foreach (var obj in listadeClientes)
            {
                MessageBox.Show(obj.Nombre + " - " + obj.ciudad);
                
            }
            
            

        }
    }
}
