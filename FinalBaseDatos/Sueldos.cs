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
    public partial class Sueldos : Form
    {
        private Finanzas fin;
        public Sueldos()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            fin = new Finanzas();
            fin.Show();
            this.Close();
        }
    }
}
