using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var ClientesBL = new ClientesBL();
            listadeClientesBindingSource.DataSource = ClientesBL.ListadeClientes;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}

