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
    public partial class InsertarAlergia : Form
    {
        private Inicio inicio;
        private PerInf volviendo;
       
        public InsertarAlergia()
        {
            InitializeComponent();
            //para la tabla
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("select nromatricula , nombre from Infantes where FechaBaja is null order by Nombre", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataGridInfantes.DataSource = dt;
            adapter.Fill(dt);

            conexion.Close();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("TieneAlergia", conexion);
            if(NroMatricula.Text != "" && cmbingre.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@NroMatricula", NroMatricula.Text);
                    comm.Parameters.AddWithValue("@ingrediente", cmbingre.Text);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha ingresado la alergia con exito...");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos...");
            }

            comm.Dispose();
            conexion.Close();
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void volv_Click(object sender, EventArgs e)
        {
            volviendo = new PerInf();
            volviendo.Show();
            this.Close ();
        }



        private void dataGridInfantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
