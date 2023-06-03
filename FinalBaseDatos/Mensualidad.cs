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
    public partial class Mensualidad : Form
    {
        private Finanzas finanzas;
        public Mensualidad()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            finanzas = new Finanzas();  
            finanzas.Show();
            this.Close();
        }
    }
}
