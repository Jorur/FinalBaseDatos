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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalBaseDatos
{
    public partial class TodaBaja : Form
    {
       
        public TodaBaja()
        {
            InitializeComponent();
            //mostrando tablas
            string consulta = "Select * from Infantes where FechaBaja is not null";
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Baja.DataSource = dt;
            conexion.Close();
        }
    }
}
