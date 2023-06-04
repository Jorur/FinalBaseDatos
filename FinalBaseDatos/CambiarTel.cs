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
    public partial class CambiarTel : Form
    {
        private Telefonos nuevo;
        private Inicio inicio;
        private static SqlConnection ConexionDb()
        {
             //string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
            string connString = "Data Source = EMILIANA\\MSSQLSERVER01 ; Initial Catalog = GuarderiaFinal; User ID = emifinal; Password = Passw0rd";
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
        public CambiarTel()
        {
            InitializeComponent();
        }

        private void volver1_Click(object sender, EventArgs e)
        {
            nuevo = new Telefonos();
            nuevo.Show();
            this.Close();
        }

        private void confi_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = ConexionDb();
            SqlCommand comm = new SqlCommand("ModificarTel", conn);
            if(carnet.Text != "" && Telant.Text != "" && telefono.Text != "" )
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Ci", carnet.Text);
                    comm.Parameters.AddWithValue("@viejo", Telant.Text);
                    comm.Parameters.AddWithValue("@nuevo", telefono.Text);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha registrado con exito!!!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                comm.Dispose();
                conn.Close();
                inicio = new Inicio();
                inicio.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese los datos por favor...");
            }

        }
    }
}
