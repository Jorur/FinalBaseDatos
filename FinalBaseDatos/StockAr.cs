using FinalBaseDatos.Models;
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
        
        public StockAr()
        {
            InitializeComponent();
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
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
