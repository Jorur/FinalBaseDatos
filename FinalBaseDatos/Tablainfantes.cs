using FinalBaseDatos.Models;
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
    public partial class Tablainfantes : Form
    {
        
        public Tablainfantes()
        {
            InitializeComponent();

            //mostrando tablas
            string consulta = "select nromatricula , nombre from Infantes where FechaBaja is null order by Nombre";
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            tabla.DataSource = dt;
            conexion.Close();

        }

        //no tocar por si acaso
        private void Tablainfantes_Load(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
