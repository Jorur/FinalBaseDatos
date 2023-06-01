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
        private PerInf perinf;
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
            Infante inf;
            inf = new Infante(NombreInf.Text, FechaNacimiento.Text, FechaIngreso.Text, float.Parse(Tarifa.Text));
            persona = new InsertarPer(inf);
            persona.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            perinf = new PerInf();
            perinf.Show();
            this.Close();
        }
    }
}
