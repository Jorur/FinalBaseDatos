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
    public partial class Buscando : Form
    {
        private Inicio inicio;
        private TablasAR tabla;
        private TodaBaja bajas;
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
        public Buscando()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void busca_Click(object sender, EventArgs e)
        {
            try
            {
                if(Dato.Text != "")
                {
                    if (radioNiño.Checked)
                    {
                        SqlConnection conexion = ConexionDb();
                        SqlCommand comm = new SqlCommand("DatosGenerales", conexion);
                        comm.CommandType = System.Data.CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@nombre", Dato.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        datosGenerales.DataSource = dt;

                        comm.Dispose();
                        comm.Parameters.Clear();
                    }

                    if (radioAdulto.Checked)
                    {
                        SqlConnection conexion = ConexionDb();
                        SqlCommand comm = new SqlCommand("DatosGenerales2", conexion);
                        comm.CommandType = System.Data.CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@CI", Dato.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        datosGenerales.DataSource = dt;

                        comm.Dispose();
                        comm.Parameters.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese los datos por favor...");
                }

            }
            catch (Exception error){ 
                MessageBox.Show(error.Message);
            }
            
        }

        private void Alergias_Click(object sender, EventArgs e)
        {
            if(matricula.Text != "")
            {
                tabla = new TablasAR(matricula.Text, "alergia");
                tabla.Show();
            }
            else 
            {
                MessageBox.Show("Ingrese la matricula por favor...");
            }

        }

        private void Responsables_Click(object sender, EventArgs e)
        {
            if (matricula.Text != "")
            {
                tabla = new TablasAR(matricula.Text, "responsable");
                tabla.Show();
            }

            else
            {
                MessageBox.Show("Ingrese la matricula por favor...");
            }

        }

        private void Bajas_Click(object sender, EventArgs e)
        {
            bajas = new TodaBaja();
            bajas.Show();

        }
    }
}
