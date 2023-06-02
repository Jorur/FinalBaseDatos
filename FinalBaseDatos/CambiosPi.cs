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
    public partial class CambiosPi : Form
    {
        private PerInf volver;
        private DarBaja darbaja;
        private Telefonos Telefono;
        public CambiosPi()
        {
            InitializeComponent();
        }

        private void volver1_Click(object sender, EventArgs e)
        {
            volver = new PerInf();
            volver.Show();
            this.Close();
        }

        private void CamInf_Click(object sender, EventArgs e)
        {
            darbaja = new DarBaja();
            darbaja.Show();
            this.Close();
        }

        private void CamPer_Click(object sender, EventArgs e)
        {
            Telefono = new Telefonos();
            Telefono.Show();
            this.Close();
        }
    }
}
