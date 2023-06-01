using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBaseDatos
{
    public partial class PerInf : Form
    {
        private InsertarInf insInf;
        private Inicio inicio;
        private PersonaNueva personaNueva;
        private CambiosPi cambios;
       
        public PerInf()
        {
            InitializeComponent();
        }

        private void RegInf_Click(object sender, EventArgs e)
        {
            insInf = new InsertarInf();
            insInf.Show();
            this.Hide();
        }


        private void PerInf_Load(object sender, EventArgs e)
        {

        }

        private void ModificarPerInf_Click(object sender, EventArgs e)
        {
            cambios= new CambiosPi();
            cambios.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void NewPer_Click(object sender, EventArgs e)
        {
            
            personaNueva = new PersonaNueva();
            personaNueva.Show();
            this.Close();
        }
    }
}
