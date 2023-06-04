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
    public partial class PersonaNueva : Form
    {
        private Inicio inicio;
        private Tablainfantes tablainfantes;
        public static SqlConnection ConexionDB()
        {
            //string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
            string connString = "Data Source = EMILIANA\\MSSQLSERVER01 ; Initial Catalog = GuarderiaFinal; User ID = emifinal; Password = Passw0rd";
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

        private PerInf start = new PerInf();   
        public PersonaNueva()
        {
            InitializeComponent();
            inicio = new Inicio();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            start = new PerInf();
            start.Show();
            this.Close();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDB();
            SqlCommand comm = new SqlCommand("InsertarPersona",conexion);
            if(Ci.Text != "" && Nombre.Text != "" && Dir.Text != "" && nroMatricula.Text != "" && Parent.Text != "" && Telf.Text != "")
            {
                try
                {
                    //Insertando la Persona
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@cipersona", Ci.Text);
                    comm.Parameters.AddWithValue("@nombrepers", Nombre.Text);
                    comm.Parameters.AddWithValue("@direccion", Dir.Text);
                    comm.ExecuteNonQuery();

                    comm.Parameters.Clear();
                    comm.Dispose();

                    //Insertando el parentesco
                    comm.CommandText = "InsertarParentMat";
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@matricula", nroMatricula.Text);
                    comm.Parameters.AddWithValue("@ci", Ci.Text);
                    comm.Parameters.AddWithValue("@Parentesco", Parent.Text);
                    comm.ExecuteNonQuery();

                    comm.Parameters.Clear();
                    comm.Dispose();

                    //Insertando el numero de telefono
                    comm.CommandText = "InsertarTel";
                    comm.Parameters.AddWithValue("@CIper", Ci.Text);
                    comm.Parameters.AddWithValue("@telefono", Telf.Text);
                    comm.ExecuteNonQuery();

                    comm.Parameters.Clear();
                    comm.Dispose();

                    MessageBox.Show("Se ha registrado los datos con exito!!!");

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
            conexion.Close();
            inicio.Show();
            this.Close();
        }

        private void Vertabla_Click(object sender, EventArgs e)
        {
            tablainfantes = new Tablainfantes();
            tablainfantes.Show();
        }
    }
}
