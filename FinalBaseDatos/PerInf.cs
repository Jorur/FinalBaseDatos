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
        private CambiosPerInf cambiosPerInf;
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
        //aqui vamos al campo de modificacion : o dar de baja o cambiar un tel
        private void ModificarPerInf_Click(object sender, EventArgs e)
        {
            cambiosPerInf = new CambiosPerInf();
            cambiosPerInf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
