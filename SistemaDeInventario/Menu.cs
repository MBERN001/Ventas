using SistemaDeInventario.BL;
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
    public partial class Menu : Form
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        ClientesBL _clientesBL;
        ProveedoresBL _proveedoresBL;
        FacturaBL _facturaBL;
        UsuariosBL _usuariosBL;
        
        public Menu()
        {
            InitializeComponent();

            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
            _clientesBL = new ClientesBL();
            _proveedoresBL = new ProveedoresBL();
            _facturaBL = new FacturaBL();
            _usuariosBL = new BL.UsuariosBL();
                
         }


        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form1();
            formProductos.MdiParent = this;

            formProductos.cargarDatos(_productosBL, _categoriasBL);
            
            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;
            formClientes.cargarDatos(_clientesBL);
            formClientes.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var formProveedores = new Form3();
            formProveedores.MdiParent = this;
            formProveedores.cargarDatos(_proveedoresBL, _productosBL);
            formProveedores.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var formFactura = new Form4();
           formFactura.MdiParent = this;
           formFactura.cargarDatos(_facturaBL, _clientesBL, _productosBL);
           formFactura.Show();              
        }

    } 
}
