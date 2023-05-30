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
        public static SqlConnection ConexionDB()
        {
            string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Conexion con la base de datos exitosa");
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
            comm.Parameters.AddWithValue("@nombreinf", textBox1.Text);
            comm.Parameters.AddWithValue("@fachanacimiento",textBox2.Text);
            comm.Parameters.AddWithValue("@fechaalta", textBox3.Text);
            comm.Parameters.AddWithValue("@tarifames", textBox4.Text);

            comm.ExecuteNonQuery();

            MessageBox.Show("Se han registrado los datos con exito!!!!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            comm.Dispose();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
