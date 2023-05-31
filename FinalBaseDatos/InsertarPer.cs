using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBaseDatos
{
    public partial class InsertarPer : Form
    {
        private string nroMatricula;
        private string nacimiento;
        public static SqlConnection ConexionDB()
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
        public InsertarPer(string infante, string fechaNac)
        {
            InitializeComponent();
            nroMatricula = infante;
            nacimiento = fechaNac;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Procedimiento de Insertar Persona
            SqlConnection conexion = ConexionDB();
            SqlCommand comm = new SqlCommand("InsertarPersona", conexion);
            try 
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@cipersona", Ci.Text);
                comm.Parameters.AddWithValue("@nombrepers", NombreEncargado.Text);
                comm.Parameters.AddWithValue("@direccion", Direccion.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado con exito!!!");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            comm.Dispose();

            //Insertar Parentesco
            comm = new SqlCommand("InsertarParent", conexion);
            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@inf", nroMatricula);
                comm.Parameters.AddWithValue("@ci", Ci.Text);
                comm.Parameters.AddWithValue("@Parentesco", Parentesco.Text);
                comm.Parameters.AddWithValue("@nac", nacimiento);   
                comm.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            NombreEncargado.Clear();
            Direccion.Clear();
            Ci.Clear();
            Parentesco.Clear();

            conexion.Close();
            comm.Dispose();
            this.Close();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
