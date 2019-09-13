using SistemaDeInventario.BL;
using SistemaDeInventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario
{
    public partial class Form4 : Form
    {
        FacturaBL _facturaBL;
        public Form4()
        {
            InitializeComponent();
        }
        public void cargarDatos(FacturaBL facturaBL, ClientesBL clientesBL, ProductosBL productosBL)
        {
            _facturaBL = facturaBL;
            listadeFacturasBindingSource.DataSource = facturaBL.ListadeFacturas;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;   
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            factura.CalcularTotalFactura();

            listadeFacturasBindingSource.ResetBindings(false);
        }
    }
   
}
