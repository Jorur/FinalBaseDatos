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
    public partial class TablasAR : Form
    {
        public static SqlConnection ConexionDB()
        {
            string connString = "Data Source = DESKTOP-7IHEVRL ; Initial Catalog = GuarderiaFinal; User ID = BrendaNury; Password = Password";
            //string connString = "Data Source = EMILIANA\\MSSQLSERVER01 ; Initial Catalog = GuarderiaFinal; User ID = emifinal; Password = Passw0rd";
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

        //mostrando
        public TablasAR(string nromatricula, string tipo)
        {
            InitializeComponent();

            if (tipo == "alergia")
            {
                SqlConnection conexion = ConexionDB();
                SqlCommand comm = new SqlCommand("AlergiaReporte", conexion);
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@matricula", nromatricula);;

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    alerRes.DataSource = dt;

                    comm.Dispose();
                    comm.Parameters.Clear();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    comm.Dispose();
                    comm.Parameters.Clear();
                }
            }//

            //ahora para responsables

            if(tipo == "responsable")
            {
                SqlConnection conexion = ConexionDB();
                SqlCommand comm = new SqlCommand("Responsables", conexion);
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@matricula", nromatricula); ;

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    alerRes.DataSource = dt;

                    comm.Dispose();
                    comm.Parameters.Clear();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    comm.Dispose();
                    comm.Parameters.Clear();
                }
            }

        }
    }
}
