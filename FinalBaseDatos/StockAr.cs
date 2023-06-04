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
    public partial class StockAr : Form
    {
        public static SqlConnection ConexionDB()
        {
            //string connString = "Data Source = Fabian\\SQLEXPRESS01 ; Initial Catalog = GuarderiaFinal; User ID = Fabiaan; Password = Password";
            string connString = "Data Source = ATHENEA; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
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
        public StockAr()
        {
            InitializeComponent();
            SqlConnection conexion = ConexionDB();
            SqlCommand comm = new SqlCommand("VerStock", conexion);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                Datos.DataSource = dt;
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
