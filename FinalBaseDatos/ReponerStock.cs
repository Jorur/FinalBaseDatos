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
    public partial class ReponerStock : Form
    {
        private Consumos cons;
        
        public ReponerStock()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            cons = new Consumos();
            cons.Show();
            this.Close();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("ReponerStock", conexion);
            string articulo;
            if(cmbarticulo.Text != "" && Cantidad.Text != "")
            {
                try
                {
                    switch (cmbarticulo.Text)
                    {
                        case "Pañales":
                            articulo = "Art1";
                            break;
                        case "Mamaderas":
                            articulo = "Art2";
                            break;
                        case "Caja Pañitos":
                            articulo = "Art3";
                            break;
                        case "Talco":
                            articulo = "Art4";
                            break;
                        case "Juguetes":
                            articulo = "Art5";
                            break;

                        case "Dulces":
                            articulo = "Art6";
                            break;

                        case "Chupete":
                            articulo = "Art7";
                            break;
                        case "Hipoglos":
                            articulo = "Art8";
                            break;
                        case "Pichica":
                            articulo = "Art9";
                            break;

                        case "Ropa interior":
                            articulo = "Art10";
                            break;


                        default:
                            articulo = "";
                            break;
                    }
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@codigoArt", articulo);
                    comm.Parameters.AddWithValue("@stock", Cantidad.Text);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha registrado correctamente...");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos por favor...");
            }
            
            comm.Dispose();
            conexion.Close();
            Cantidad.Clear();
        }
    }
}
