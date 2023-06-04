using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBaseDatos
{
    public partial class Factura : Form
    {
        public Factura(SqlParameter valor, SqlParameter menu, SqlParameter servicio, SqlParameter tienda, string month, string year)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            InitializeComponent();
            fech.Text = date;
            año.Text = year;
            Mes.Text = month;
            men.Text = $"{menu.Value}";
            Servicio.Text = $"{servicio.Value}";
            Articulo.Text = $"{tienda.Value}";
            Total.Text = $"{valor.Value}";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }
    }
}
