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
    public partial class DarBaja : Form
    {
        private CambiosPi cambios;
        private Inicio inicio;


        public DarBaja()
        {
            InitializeComponent();
            inicio = new Inicio();

            string consulta = "select nromatricula , nombre from Infantes where FechaBaja is null order by Nombre";
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            tablaInf.DataSource = dt;
            conexion.Close();
        }

        private void MatriInf_TextChanged(object sender, EventArgs e)
        {

        }

        private void DarBaja_Load(object sender, EventArgs e)
        {

        }

        private void tablaniños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Conexion db = new Conexion();
              SqlConnection conexion = db.ConexionDb();
             SqlCommand comm = new SqlCommand("select nromatricula , nombre from Infantes order by Nombre", conexion);
             SqlDataAdapter adapter = new SqlDataAdapter(comm);
             DataTable dt = new DataTable();
             adapter.Fill(dt);
             */

        }

        private void volver1_Click(object sender, EventArgs e)
        {
            cambios= new CambiosPi();
            cambios.Show();
            this.Close();
        }

        private void conf_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("DardeBaja", conexion);
            if(ingresarnm.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@NroMatricula", ingresarnm.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Se ha registrado con exito!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos por favor...");
            }
            comm.Dispose();
            conexion.Close();
        }
    }
}
