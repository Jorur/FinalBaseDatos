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
    public partial class EliminarTel : Form
    {
        private Inicio inicio;
        private Telefonos telefonos;
        private static SqlConnection ConexionDb()
        {
            //string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
            string connString = "Data Source = DESKTOP-7IHEVRL ; Initial Catalog = GuarderiaFinal; User ID = BrendaNury; Password = Password";
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
        public EliminarTel()
        {
            InitializeComponent();
            inicio = new Inicio();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConexionDb();
            SqlCommand comm = new SqlCommand("BorrarTel", conn);
            if(Ci.Text != "" && Telefono.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@CIper", Ci.Text);
                    comm.Parameters.AddWithValue("@telefono", Telefono.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado con exito...");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos por favor");
            }

            comm.Dispose();
            conn.Close();
            inicio.Show();
            this.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            telefonos = new Telefonos();
            telefonos.Show();
            this.Close();
        }
    }
}
