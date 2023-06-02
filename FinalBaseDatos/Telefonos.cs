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
    public partial class Telefonos : Form
    {
        private CambiarTel cambiarTel;
        private EliminarTel eliminarTel;
        public Telefonos()
        {
            InitializeComponent();
            cambiarTel = new CambiarTel();
            eliminarTel = new EliminarTel(); 
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            cambiarTel.Show();
            this.Hide();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            eliminarTel.Show();
            this.Hide();
        }
    }
}
