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
    public partial class Finanzas : Form
    {
        private Inicio inicio;
        private Mensualidad men;
        private Sueldos su;
        public Finanzas()
        {
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            su = new Sueldos();
            su.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            men = new Mensualidad();
            men.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
