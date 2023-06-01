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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
