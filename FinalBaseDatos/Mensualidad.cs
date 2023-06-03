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
        private static SqlConnection ConexionDb()
        {
            string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
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

        private void menus_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteMenus", conexion);
            try
            {
                //Mostrando la tabla
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Inf", infante.Text);
                comm.Parameters.AddWithValue("@mes", mes.Text);
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
                comm.Parameters.AddWithValue("@mes", mes.Text);
                comm.Parameters.AddWithValue("@insertaño", año.Text);
                comm.ExecuteNonQuery();

                Total.Text = $"Con una mensualidad de {tarifa.Value}, el total es de {cobro.Value}";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            comm.Dispose();
            conexion.Close();
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void servicios_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteCobranzaServAd", conexion);
            try
            {
                //Mostrando la tabla
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@insertarmes", mes.Text);
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
                comm.Parameters.AddWithValue("@insertarmes", mes.Text);
                comm.Parameters.AddWithValue("@insertarmatricula", infante.Text);
                comm.Parameters.AddWithValue("@insertaraño", año.Text);
                comm.ExecuteNonQuery();

                Total.Text = $"El total de los Serivicios Adicionales es de: {resultado.Value}";
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
            comm.Dispose();
        }

        private void Tienda_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteConsumosTiendas", conexion);
            try
            {
                //Mostrando la tabla
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@insertarmes", mes.Text);
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
                comm.Parameters.AddWithValue("@insertarmes", mes.Text);
                comm.Parameters.AddWithValue("@insertarnromatricula", infante.Text);
                comm.Parameters.AddWithValue("@insertaraño", año.Text);
                comm.ExecuteNonQuery();

                Total.Text = $"El total de la compra en tiendas es: {resultado.Value}";

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            conexion.Close();
            comm.Dispose();
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = ConexionDb();
            SqlCommand comm = new SqlCommand("Reporte_cargoMes", conexion);
            try
            {
                //Generando el Cargo Mes
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter resultado = new SqlParameter("@resultado", System.Data.SqlDbType.Money);
                resultado.Direction = System.Data.ParameterDirection.Output;

                comm.Parameters.Add(resultado);
                comm.Parameters.AddWithValue("@inf", infante.Text);
                comm.Parameters.AddWithValue("@año", año.Text);
                comm.Parameters.AddWithValue("@mes", mes.Text);
                comm.ExecuteNonQuery();
                factura = new Factura(resultado);

                comm.Dispose();
                comm.Parameters.Clear();

                //Registrando el pago
                comm.CommandText = "PagoMensualidad";
                comm.Parameters.AddWithValue("@nroMatricula", infante.Text);
                comm.Parameters.AddWithValue("@año", año.Text);
                comm.Parameters.AddWithValue("@mes", mes.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el pago con exito");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            comm.Dispose();
            conexion.Close();
            factura.Show();
        }
    }
}
