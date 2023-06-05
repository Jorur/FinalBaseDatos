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
    public partial class EliminarTel : Form
    {
        private Inicio inicio;
        private Telefonos telefonos;
        
        public EliminarTel()
        {
            InitializeComponent();
            inicio = new Inicio();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("BorrarTel", conexion);
            if(Ci.Text != "" && Telefono.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@CIper", Ci.Text);
                    comm.Parameters.AddWithValue("@telefono", Telefono.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado con exito...");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos por favor");
            }

            comm.Dispose();
            conexion.Close();
            inicio.Show();
            this.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            telefonos = new Telefonos();
            telefonos.Show();
            this.Close();
        }
    }
}
