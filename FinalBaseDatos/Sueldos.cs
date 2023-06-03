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
    public partial class Sueldos : Form
    {
        private Finanzas fin;
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

        public Sueldos()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            fin = new Finanzas();
            fin.Show();
            this.Close();
        }

        private void busca_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteSueldos", conexion);
            try
            {
                //Mostrando la tabla
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@insertarmes", mes.Text);
                comm.Parameters.AddWithValue("@insertarencargado", encargado.Text);
                comm.Parameters.AddWithValue("@insertaraño", año.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Datos.DataSource = dt;

                comm.Dispose();
                comm.Parameters.Clear();

                //Mostrando el Total
                comm.CommandText = "SUELDOMES";
                SqlParameter resultado = new SqlParameter("@resultadoSueldo", System.Data.SqlDbType.Money);
                resultado.Direction = System.Data.ParameterDirection.Output;

                comm.Parameters.Add(resultado);
                comm.Parameters.AddWithValue("@insertarmes", mes.Text);
                comm.Parameters.AddWithValue("@insertarencargado", encargado.Text);
                comm.Parameters.AddWithValue("@insertaraño", año.Text);
                comm.ExecuteNonQuery();

                Total.Text = $"El total a pagar al encargado {encargado.Text} es: {resultado.Value}";
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
            comm.Dispose();
        }
    }
}
 