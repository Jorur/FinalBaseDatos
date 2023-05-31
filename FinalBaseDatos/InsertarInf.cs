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
    public partial class InsertarInf : Form
    {
        private Inicio inicio;
        private InsertarPer persona;
        public static SqlConnection ConexionDB()
        {
            string connString = "Data Source = emiliana ; Initial Catalog = GuarderiaFinal; User ID = emiliana; Password = Password";
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

        public InsertarInf()
        {
            InitializeComponent();
            inicio = new Inicio();

        }

        private void InsertarInf_Load(object sender, EventArgs e)
        {

        }
        private void InsertarInf_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                inicio.ShowInicio();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDB();
            SqlCommand comm = new SqlCommand("InsertarInfante",conexion);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@nombreinf", NombreInf.Text);
            comm.Parameters.AddWithValue("@fachanacimiento",FechaNacimiento.Text);
            comm.Parameters.AddWithValue("@fechaalta", FechaIngreso.Text);
            comm.Parameters.AddWithValue("@tarifames", Tarifa.Text);

            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Se han registrado los datos con exito!!!!");
            }
            
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            //MessageBox.Show(NombreInf.Text + " " + FechaNacimiento.Text);
            persona = new InsertarPer(NombreInf.Text, FechaNacimiento.Text);
            persona.Show();

            conexion.Close();
            comm.Dispose();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaIngreso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
