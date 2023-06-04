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
    public partial class ConsumosSA : Form
    {
        private Consumos consumos;
        public static SqlConnection ConexionDB()
        {
            //string connString = "Data Source = Fabian\\SQLEXPRESS01 ; Initial Catalog = GuarderiaFinal; User ID = Fabiaan; Password = Password";
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
        public ConsumosSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumos = new Consumos();
            consumos.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmarConsumoSA_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConexionDB();
            SqlCommand comm = new SqlCommand("InsertarConsumoServicio", conn);
            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@nromatricula", NroMatricula.Text);
                comm.Parameters.AddWithValue("@codserv", CodServ.Text);
                comm.Parameters.AddWithValue("@descripcion", Descripcion.Text);
                comm.ExecuteNonQuery();

                MessageBox.Show("Se ha ingresado el consumo con exito...");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            comm.Dispose();
            conn.Close();
            consumos = new Consumos();
            consumos.Show();
            this.Close();
        }
    }
}
