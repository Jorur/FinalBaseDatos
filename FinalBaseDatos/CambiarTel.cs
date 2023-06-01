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
    public partial class CambiarTel : Form
    {
        private CambiosPi nuevo;
        public CambiarTel()
        {
            InitializeComponent();
        }

        private void volver1_Click(object sender, EventArgs e)
        {
            nuevo = new CambiosPi();
            nuevo.Show();
            this.Close();
        }
    }
}
