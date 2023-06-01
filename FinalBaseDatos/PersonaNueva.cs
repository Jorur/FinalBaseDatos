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
    public partial class PersonaNueva : Form
    {
        private PerInf start = new PerInf();   
        public PersonaNueva()
        {
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            start = new PerInf();
            start.Show();
            this.Close();
        }
    }
}
