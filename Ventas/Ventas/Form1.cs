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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;


            var categoriasBL = new CategoriasBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void categoriaIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriaIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel1_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
