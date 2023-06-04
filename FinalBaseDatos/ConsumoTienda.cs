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
    public partial class ConsumoTienda : Form
    {
        private Consumos consumos;
        public static SqlConnection ConexionDB()
        {
            //string connString = "Data Source = Fabian\\SQLEXPRESS01 ; Initial Catalog = GuarderiaFinal; User ID = Fabiaan; Password = Password";
            string connString = "Data Source = ATHENEA; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
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
        public ConsumoTienda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumos = new Consumos();
            consumos.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConexionDB();
            SqlCommand comm = new SqlCommand("InsertarConsumosTienda", conn);
            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter resultado = new SqlParameter("@resultado", System.Data.SqlDbType.VarChar, 50);
                resultado.Direction = System.Data.ParameterDirection.Output;
                comm.Parameters.Add(resultado);
                comm.Parameters.AddWithValue("@NroMatricula", NroMatricula.Text);
                comm.Parameters.AddWithValue("@IdArticulo", IdArticulo.Text);
                comm.Parameters.AddWithValue("@cantidad", Cantidad.Text);
                comm.ExecuteNonQuery(); 
                string alerta = resultado.Value.ToString();
                if (alerta == "true")
                {
                    MessageBox.Show("Alerta de minimo de Stock...");
                }
                else if (alerta == "false")
                {
                    MessageBox.Show("Se ha ingresado el consumo con exito...");
                }
                else if (alerta == "ns")
                {
                    MessageBox.Show("Sin Stock suficiente...");
                }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
