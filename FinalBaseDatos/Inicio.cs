using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalBaseDatos
{
    public partial class Inicio : Form
    {
        
        public static SqlConnection ConexionDB()
        {
            string connString = "Data Source = emiliana; Initial Catalog = GuarderiaFinal; User ID = emiliana; Password = Password";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Conexion con la base de datos exitosa");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return conn;
        }
        public Inicio()
        {
            InitializeComponent();
            ConexionDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
