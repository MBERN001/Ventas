using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Heroes_Y_Villanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadeHeroes = new List<Heroe>();
            var heroe1 = new Heroe();
            heroe1.Id = 01;
            heroe1.Nombre_de_Heroe = " StarHawk ";
            heroe1.Nombre_Civil = "Juan Avila";
            heroe1.Poder = "Super Vuelo y vista de Aguila";

            var heroe2 = new Heroe();
            heroe2.Id = 02;
            heroe2.Nombre_de_Heroe = " SuperTank ";
            heroe2.Nombre_Civil = "Charlie Black";
            heroe2.Poder = "Super Fuerza y Super Resistencia";

            var heroe3 = new Heroe();
            heroe3.Id = 03;
            heroe3.Nombre_de_Heroe = " FireBlast ";
            heroe3.Nombre_Civil = "Flint Alvarez";
            heroe3.Poder = "Llamas incandecentes y vuelo";

            ListadeHeroes.Add(heroe1);
            ListadeHeroes.Add(heroe2);
            ListadeHeroes.Add(heroe3);

            dataGridView1.DataSource = ListadeHeroes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadeVillanos = new List<Villano>();
            var villano1 = new Villano();
            villano1.Id = 1;
            villano1.Nombre_de_Villano = " Doctor Brain ";
            villano1.Nombre_Civil = "Marcos Chavez";
            villano1.Poder = "Control Mental";

            var villano2 = new Villano();
            villano2.Id = 2;
            villano2.Nombre_de_Villano = " Grantbeast ";
            villano2.Nombre_Civil = "Donnie Martinez";
            villano2.Poder = "Control de los animales y asimalar sus habilidades";

            var villano3 = new Villano();
            villano3.Id = 3;
            villano3.Nombre_de_Villano = " Astroman ";
            villano3.Nombre_Civil = "Mario Villanueva ";
            villano3.Poder = "Poderes psiquicos";

            ListadeVillanos.Add(villano1);
            ListadeVillanos.Add(villano2);
            ListadeVillanos.Add(villano3);

            dataGridView1.DataSource = ListadeVillanos;

        }

        public List<Heroe> ListadeHeroes { get; set; }

        public List<Villano> ListadeVillanos { get; set; }
    }
}
