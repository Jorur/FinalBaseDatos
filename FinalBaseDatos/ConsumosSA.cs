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
    public partial class ConsumosSA : Form
    {
        private Consumos consumos;
        private Tablainfantes tablainfantes;
       
        public ConsumosSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumos = new Consumos();
            consumos.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmarConsumoSA_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("InsertarConsumoServicio", conexion);
            string codigo;
            if(NroMatricula.Text != "" && cmbSer.Text != "" && Descripcion.Text != "")
            {
                try
                {
                    switch (cmbSer.Text)
                    {
                        case "Pediatría":
                            codigo = "Ser1";
                            break;
                        case "Fonoaudiología":
                            codigo = "Ser2";
                            break;
                        case "Nutrición":
                            codigo = "Ser3";
                            break;
                        case "Apoyo Psicomotriz":
                            codigo = "Ser4";
                            break;
                        case "Lavandería":
                            codigo = "Ser5";
                            break;
                        
                        default:
                            codigo = "";
                            break;
                    }
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@nromatricula", NroMatricula.Text);
                    comm.Parameters.AddWithValue("@codserv", codigo);
                    comm.Parameters.AddWithValue("@descripcion", Descripcion.Text);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha ingresado el consumo con exito...");
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
            consumos = new Consumos();
            consumos.Show();
            this.Close();
        }

        private void ver_Click(object sender, EventArgs e)
        {
            tablainfantes = new Tablainfantes();
            tablainfantes.Show();

        }
    }
}
