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
    public partial class DarBaja : Form
    {
        private CambiosPi cambios;
        private Inicio inicio;

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

        public DarBaja()
        {
            InitializeComponent();
            inicio = new Inicio();
        }

        private void MatriInf_TextChanged(object sender, EventArgs e)
        {

        }

        private void DarBaja_Load(object sender, EventArgs e)
        {

        }

        private void tablaniños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void volver1_Click(object sender, EventArgs e)
        {
            cambios= new CambiosPi();
            cambios.Show();
            this.Close();
        }

        private void conf_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConexionDB();
            SqlCommand comm = new SqlCommand("DardeBaja", conn);
            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@NroMatricula", ingresarnm.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado con exito!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
