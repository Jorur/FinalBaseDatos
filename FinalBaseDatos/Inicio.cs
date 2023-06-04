using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalBaseDatos
{
    public partial class Inicio : Form
    {

        private PerInf admisiones;
        private Finanzas finanaza;
        private Consumos consumo;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admisiones = new PerInf();
            admisiones.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void ShowInicio()
        {
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            consumo = new Consumos();
            consumo.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            finanaza = new Finanzas();
            finanaza.Show();
            this.Hide();
        }
    }
}
