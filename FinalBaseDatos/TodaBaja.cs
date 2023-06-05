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
        private static SqlConnection ConexionDb()
        {
            string connString = "Data Source = DESKTOP-7IHEVRL ; Initial Catalog = GuarderiaFinal; User ID = BrendaNury; Password = Password";
            //string connString = "Data Source = EMILIANA\\MSSQLSERVER01 ; Initial Catalog = GuarderiaFinal; User ID = emifinal; Password = Passw0rd";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                //MessageBox.Show("Conexion con la base de datos exitosa");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return conn;
        }
        public TodaBaja()
        {
            InitializeComponent();
            //mostrando tablas
            string consulta = "Select * from Infantes where FechaBaja is not null";
            SqlConnection conexion = ConexionDb();
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Baja.DataSource = dt;
            conexion.Close();
        }
    }
}
