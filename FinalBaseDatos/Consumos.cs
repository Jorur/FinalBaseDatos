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
    public partial class Consumos : Form
    {
        private Inicio inicio;
        private ConsumoMenu consumomenu;
        private ConsumoTienda consumotienda;
        private ConsumosSA consumoservad;
        public static SqlConnection ConexionDB()
        {
            string connString = "Data Source = Fabian ; Initial Catalog = GuarderiaFinal; User ID = Fabiaan; Password = Password";
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

        public Consumos()
        {
            InitializeComponent();
            inicio = new Inicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumomenu = new ConsumoMenu();
            consumomenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consumotienda = new ConsumoTienda();
            consumotienda.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consumoservad = new ConsumosSA();
            consumoservad.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}
