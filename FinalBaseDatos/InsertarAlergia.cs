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

            //string connString = "Data Source = Fabian ; Initial Catalog = GuarderiaFinal; User ID = Fabiaan; Password = Password";
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
        public InsertarAlergia()
        {
            InitializeComponent();
            //para la tabla
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("select nromatricula , nombre from Infantes where FechaBaja is null order by Nombre", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataGridInfantes.DataSource = dt;
            adapter.Fill(dt);

            conexion.Close();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConexionDb();
            SqlCommand comm = new SqlCommand("TieneAlergia", conn);
            if(NroMatricula.Text != "" && cmbingre.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@NroMatricula", NroMatricula.Text);
                    comm.Parameters.AddWithValue("@ingrediente", cmbingre.Text);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha ingresado la alergia con exito...");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos...");
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



        private void dataGridInfantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
