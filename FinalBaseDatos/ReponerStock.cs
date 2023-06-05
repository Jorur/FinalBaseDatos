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
    public partial class ReponerStock : Form
    {
        private Consumos cons;
        public static SqlConnection ConexionDB()
        {
            //string connString = "Data Source = Fabian ; Initial Catalog = GuarderiaFinal; User ID = Fabiaan; Password = Password";
            string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
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
        public ReponerStock()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            cons = new Consumos();
            cons.Show();
            this.Close();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDB();
            SqlCommand comm = new SqlCommand("ReponerStock", conexion);
            if(CodArt.Text != "" && Cantidad.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@codigoArt", CodArt.Text);
                    comm.Parameters.AddWithValue("@stock", Cantidad.Text);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha registrado correctamente...");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos por favor...");
            }
            
            comm.Dispose();
            conexion.Close();
            CodArt.Clear();
            Cantidad.Clear();
        }
    }
}
