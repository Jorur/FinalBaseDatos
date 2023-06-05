using FinalBaseDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBaseDatos
{
    public partial class InsertarPer : Form
    {
        private Inicio inicio;
        private Infante inf;
        private EncargadoEx encargado;
       
        public InsertarPer(Infante infante)
        {
            InitializeComponent();
            inf = infante;
            inicio = new Inicio();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Procedimiento de Insertar Persona
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("RegInf", conexion);
            if(Ci.Text != "" && NombreEncargado.Text != "" && Direccion.Text != "" && Parentesco.Text != "" && Celular.Text != "" && CuentaBco.Text != "" && Banco.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@infnt", inf.Nombre);
                    comm.Parameters.AddWithValue("@nacimiento", inf.FechaNacimiento);
                    comm.Parameters.AddWithValue("@alta", inf.FechaAlta);
                    comm.Parameters.AddWithValue("@tarifa", inf.TarifaMes);
                    comm.Parameters.AddWithValue("@ciP", Ci.Text);
                    comm.Parameters.AddWithValue("@persona", NombreEncargado.Text);
                    comm.Parameters.AddWithValue("@dir", Direccion.Text);
                    comm.Parameters.AddWithValue("@parent", Parentesco.Text);
                    comm.Parameters.AddWithValue("@tel", Celular.Text);
                    comm.Parameters.AddWithValue("@nroCuent", CuentaBco.Text);
                    comm.Parameters.AddWithValue("@banc", Banco.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Se ha registrado con exito!!!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Hubo un error al ingresar los datos... Por favor verificar");
                    //MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos...");
            }

            inicio.Show();
            comm.Dispose();
            conexion.Close();
            this.Close();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void InsertarPer_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.ShowInicio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            encargado = new EncargadoEx(inf);
            encargado.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
