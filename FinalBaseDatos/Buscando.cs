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
    public partial class Buscando : Form
    {
        private Inicio inicio;
        private TablasAR tabla;
        private TodaBaja bajas;
        public Buscando()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void busca_Click(object sender, EventArgs e)
        {
            try
            {
                if(Dato.Text != "")
                {
                    if (radioNiño.Checked)
                    {
                        Conexion db = new Conexion();
                        SqlConnection conexion = db.ConexionDb();
                        SqlCommand comm = new SqlCommand("DatosGenerales", conexion);
                        comm.CommandType = System.Data.CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@nombre", Dato.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        datosGenerales.DataSource = dt;

                        comm.Dispose();
                        comm.Parameters.Clear();
                    }

                    if (radioAdulto.Checked)
                    {
                        Conexion db = new Conexion();
                        SqlConnection conexion = db.ConexionDb();
                        SqlCommand comm = new SqlCommand("DatosGenerales2", conexion);
                        comm.CommandType = System.Data.CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@CI", Dato.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        datosGenerales.DataSource = dt;

                        comm.Dispose();
                        comm.Parameters.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese los datos por favor...");
                }

            }
            catch (Exception error){ 
                MessageBox.Show(error.Message);
            }
            
        }

        private void Alergias_Click(object sender, EventArgs e)
        {
            if(matricula.Text != "")
            {
                tabla = new TablasAR(matricula.Text, "alergia");
                tabla.Show();
            }
            else 
            {
                MessageBox.Show("Ingrese la matricula por favor...");
            }

        }

        private void Responsables_Click(object sender, EventArgs e)
        {
            if (matricula.Text != "")
            {
                tabla = new TablasAR(matricula.Text, "responsable");
                tabla.Show();
            }

            else
            {
                MessageBox.Show("Ingrese la matricula por favor...");
            }

        }

        private void Bajas_Click(object sender, EventArgs e)
        {
            bajas = new TodaBaja();
            bajas.Show();

        }
    }
}
