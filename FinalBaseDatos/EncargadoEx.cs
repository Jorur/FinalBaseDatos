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
    public partial class EncargadoEx : Form
    {
        private Inicio inicio;
        private Infante inf;
        private InsertarPer personanueva;
       

        public EncargadoEx(Infante infante)
        {
            InitializeComponent();
            inf = infante;
            inicio = new Inicio();
        }

        private void EncargadoEx_Load(object sender, EventArgs e)
        {
            
        }

        private void Ci_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("InsertarInfante", conexion);
            if(Ci.Text != "" && Parentesco.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@nombreinf", inf.Nombre);
                    comm.Parameters.AddWithValue("@fachanacimiento", inf.FechaNacimiento);
                    comm.Parameters.AddWithValue("@fechaalta", inf.FechaAlta);
                    comm.Parameters.AddWithValue("@tarifames", inf.TarifaMes);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha registrado con exito!!!");

                }
                catch (Exception error)
                {
                    MessageBox.Show("Hubo un error al ingresar los datos... Por favor verificar");
                    MessageBox.Show(error.Message);
                }

                comm.Dispose();
                comm = new SqlCommand("InsertarParent", conexion);
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@inf", inf.Nombre);
                    comm.Parameters.AddWithValue("@ci", Ci.Text);
                    comm.Parameters.AddWithValue("@Parentesco", Parentesco.Text);
                    comm.Parameters.AddWithValue("@nac", inf.FechaNacimiento);


                    comm.ExecuteNonQuery();
                    MessageBox.Show("Se ha registrado con exito!!!");
                }
                catch (Exception error)
                {
                    //MessageBox.Show("Hubo un error al ingresar los datos... Por favor verificar");
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                MessageBox.Show("Ingrese los datos...");
            }

            comm.Dispose();
            conexion.Close();
            inicio.Show();
            this.Close();

        }

        private void volver_Click(object sender, EventArgs e)
        {
            personanueva = new InsertarPer(inf);
            personanueva.Show();
            this.Close();
        }
    }
}
