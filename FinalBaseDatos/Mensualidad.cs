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
    public partial class Mensualidad : Form
    {
        private Factura factura;
        private Finanzas finanzas;
        Tablainfantes tablainfantes;
        private static SqlConnection ConexionDb()
        {
            //string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
            string connString = "Data Source = DESKTOP-7IHEVRL ; Initial Catalog = GuarderiaFinal; User ID = BrendaNury; Password = Password";
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

        public Mensualidad()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            finanzas = new Finanzas();  
            finanzas.Show();
            this.Close();
        }


        private void Total_Click(object sender, EventArgs e) //no borrar
        {

        }

        private void pagar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("Reporte_cargoMes", conexion);
            int numeroMes;
            if(combomes.Text != "" && infante.Text != "" && año.Text != "")
            {
                try
                {
                    switch (combomes.Text.ToLower())
                    {
                        case "enero":
                            numeroMes = 1;
                            break;
                        case "febrero":
                            numeroMes = 2;
                            break;
                        case "marzo":
                            numeroMes = 3;
                            break;
                        case "abril":
                            numeroMes = 4;
                            break;
                        case "mayo":
                            numeroMes = 5;
                            break;
                        case "junio":
                            numeroMes = 6;
                            break;
                        case "julio":
                            numeroMes = 7;
                            break;
                        case "agosto":
                            numeroMes = 8;
                            break;
                        case "septiembre":
                            numeroMes = 9;
                            break;
                        case "octubre":
                            numeroMes = 10;
                            break;
                        case "noviembre":
                            numeroMes = 11;
                            break;
                        case "diciembre":
                            numeroMes = 12;
                            break;
                        default:
                            numeroMes = -1;
                            break;
                    }
                    //Generando el Cargo Mes
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter resultado = new SqlParameter("@resultado", System.Data.SqlDbType.Money);
                    resultado.Direction = System.Data.ParameterDirection.Output;

                    SqlParameter menu = new SqlParameter("@menus", System.Data.SqlDbType.Money);
                    menu.Direction = System.Data.ParameterDirection.Output;

                    SqlParameter servicio = new SqlParameter("@servicios", System.Data.SqlDbType.Money);
                    servicio.Direction = System.Data.ParameterDirection.Output;

                    SqlParameter tienda = new SqlParameter("@tienda", System.Data.SqlDbType.Money);
                    tienda.Direction = System.Data.ParameterDirection.Output;

                    comm.Parameters.Add(resultado);
                    comm.Parameters.Add(menu);
                    comm.Parameters.Add(servicio);
                    comm.Parameters.Add(tienda);
                    comm.Parameters.AddWithValue("@inf", infante.Text);
                    comm.Parameters.AddWithValue("@año", año.Text);
                    comm.Parameters.AddWithValue("@mes", numeroMes);
                    comm.ExecuteNonQuery();
                    factura = new Factura(resultado, menu, servicio, tienda, combomes.Text, año.Text);

                    comm.Dispose();
                    comm.Parameters.Clear();

                    //Registrando el pago
                    comm.CommandText = "PagoMensualidad";
                    comm.Parameters.AddWithValue("@nroMatricula", infante.Text);
                    comm.Parameters.AddWithValue("@año", año.Text);
                    comm.Parameters.AddWithValue("@mes", numeroMes);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Se ha registrado el pago con exito");
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
            factura.Show();
        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioMenu_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteMenus", conexion);
            int numeroMes;
            if (combomes.Text != "" && infante.Text != "" && año.Text != "")
            {
                try
                {
                    switch (combomes.Text.ToLower())
                    {
                        case "enero":
                            numeroMes = 1;
                            break;
                        case "febrero":
                            numeroMes = 2;
                            break;
                        case "marzo":
                            numeroMes = 3;
                            break;
                        case "abril":
                            numeroMes = 4;
                            break;
                        case "mayo":
                            numeroMes = 5;
                            break;
                        case "junio":
                            numeroMes = 6;
                            break;
                        case "julio":
                            numeroMes = 7;
                            break;
                        case "agosto":
                            numeroMes = 8;
                            break;
                        case "septiembre":
                            numeroMes = 9;
                            break;
                        case "octubre":
                            numeroMes = 10;
                            break;
                        case "noviembre":
                            numeroMes = 11;
                            break;
                        case "diciembre":
                            numeroMes = 12;
                            break;
                        default:
                            numeroMes = -1;
                            break;
                    }
                    //Mostrando la tabla
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Inf", infante.Text);
                    comm.Parameters.AddWithValue("@mes", numeroMes);
                    comm.Parameters.AddWithValue("@insertaño", año.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Datos.DataSource = dt;

                    comm.Dispose();
                    comm.Parameters.Clear();
                    // Mostrado el total
                    comm.CommandText = "ConsumoInf";
                    SqlParameter cobro = new SqlParameter("@cobro", System.Data.SqlDbType.Money);
                    cobro.Direction = System.Data.ParameterDirection.Output;
                    SqlParameter tarifa = new SqlParameter("@tarifaM", System.Data.SqlDbType.Money);
                    tarifa.Direction = System.Data.ParameterDirection.Output;

                    comm.Parameters.Add(cobro);
                    comm.Parameters.Add(tarifa);
                    comm.Parameters.AddWithValue("@Inf", infante.Text);
                    comm.Parameters.AddWithValue("@mes", numeroMes);
                    comm.Parameters.AddWithValue("@insertaño", año.Text);
                    comm.ExecuteNonQuery();

                    Total.Text = $"Con una mensualidad de {tarifa.Value}, el total es de {cobro.Value}";

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
        }

        private void radioServicios_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteCobranzaServAd", conexion);
            int numeroMesser;
            if (combomes.Text != "" && infante.Text != "" && año.Text != "")
            {
                try
                {
                    switch (combomes.Text.ToLower())
                    {
                        case "enero":
                            numeroMesser = 1;
                            break;
                        case "febrero":
                            numeroMesser = 2;
                            break;
                        case "marzo":
                            numeroMesser = 3;
                            break;
                        case "abril":
                            numeroMesser = 4;
                            break;
                        case "mayo":
                            numeroMesser = 5;
                            break;
                        case "junio":
                            numeroMesser = 6;
                            break;
                        case "julio":
                            numeroMesser = 7;
                            break;
                        case "agosto":
                            numeroMesser = 8;
                            break;
                        case "septiembre":
                            numeroMesser = 9;
                            break;
                        case "octubre":
                            numeroMesser = 10;
                            break;
                        case "noviembre":
                            numeroMesser = 11;
                            break;
                        case "diciembre":
                            numeroMesser = 12;
                            break;
                        default:
                            numeroMesser = -1;
                            break;
                    }
                    //Mostrando la tabla
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@insertarmes", numeroMesser);
                    comm.Parameters.AddWithValue("@insertarmatricula", infante.Text);
                    comm.Parameters.AddWithValue("@insertaraño", año.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Datos.DataSource = dt;

                    comm.Dispose();
                    comm.Parameters.Clear();

                    //Mostrando el Total
                    comm.CommandText = "SERVADIC";
                    SqlParameter resultado = new SqlParameter("@resultadoServAd", System.Data.SqlDbType.Money);
                    resultado.Direction = System.Data.ParameterDirection.Output;

                    comm.Parameters.Add(resultado);
                    comm.Parameters.AddWithValue("@insertarmes", numeroMesser);
                    comm.Parameters.AddWithValue("@insertarmatricula", infante.Text);
                    comm.Parameters.AddWithValue("@insertaraño", año.Text);
                    comm.ExecuteNonQuery();

                    Total.Text = $"El total de los Serivicios Adicionales es de: {resultado.Value}";
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
            conexion.Close();
            comm.Dispose();
        }

        private void radiotienda_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteConsumosTiendas", conexion);
            int numeroMesti;
            if (combomes.Text != "" && infante.Text != "" && año.Text != "")
            {
                try
                {
                    switch (combomes.Text.ToLower())
                    {
                        case "enero":
                            numeroMesti = 1;
                            break;
                        case "febrero":
                            numeroMesti = 2;
                            break;
                        case "marzo":
                            numeroMesti = 3;
                            break;
                        case "abril":
                            numeroMesti = 4;
                            break;
                        case "mayo":
                            numeroMesti = 5;
                            break;
                        case "junio":
                            numeroMesti = 6;
                            break;
                        case "julio":
                            numeroMesti = 7;
                            break;
                        case "agosto":
                            numeroMesti = 8;
                            break;
                        case "septiembre":
                            numeroMesti = 9;
                            break;
                        case "octubre":
                            numeroMesti = 10;
                            break;
                        case "noviembre":
                            numeroMesti = 11;
                            break;
                        case "diciembre":
                            numeroMesti = 12;
                            break;
                        default:
                            numeroMesti = -1;
                            break;
                    }
                    //Mostrando la tabla
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@insertarmes", numeroMesti);
                    comm.Parameters.AddWithValue("@insertarnromatricula", infante.Text);
                    comm.Parameters.AddWithValue("@insertaraño", año.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Datos.DataSource = dt;

                    comm.Dispose();
                    comm.Parameters.Clear();

                    //Mostrando Total
                    comm.CommandText = "CobranzaArticulos";
                    SqlParameter resultado = new SqlParameter("@pagoarticulos", System.Data.SqlDbType.Money);
                    resultado.Direction = System.Data.ParameterDirection.Output;

                    comm.Parameters.Add(resultado);
                    comm.Parameters.AddWithValue("@insertarmes", numeroMesti);
                    comm.Parameters.AddWithValue("@insertarnromatricula", infante.Text);
                    comm.Parameters.AddWithValue("@insertaraño", año.Text);
                    comm.ExecuteNonQuery();

                    Total.Text = $"El total de la compra en tiendas es: {resultado.Value}";

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
            

            conexion.Close();
            comm.Dispose();
        }

        private void go_Click(object sender, EventArgs e)
        {
            tablainfantes = new Tablainfantes();
            tablainfantes.Show();
        }
    }
}
