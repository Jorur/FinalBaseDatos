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
    public partial class InsertarAlergia : Form
    {
        private Inicio inicio;
        private PerInf volviendo;
        private static SqlConnection ConexionDb()
        {
            string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
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
        public InsertarAlergia()
        {
            InitializeComponent();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConexionDb();
            SqlCommand comm = new SqlCommand("TieneAlergia", conn);
            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@NroMatricula", NroMatricula.Text);
                comm.Parameters.AddWithValue("@ingrediente", Ingrediente.Text);
                comm.ExecuteNonQuery();

                MessageBox.Show("Se ha ingresado la alergia con exito...");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            comm.Dispose();
            conn.Close();
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void volv_Click(object sender, EventArgs e)
        {
            volviendo = new PerInf();
            volviendo.Show();
            this.Close ();
        }
    }
}
