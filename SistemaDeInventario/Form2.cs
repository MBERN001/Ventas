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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void cargarDatos(ClientesBL clientesBL)
        {
          listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
        }

    private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
