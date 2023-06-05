﻿using System;
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
    public partial class Tablainfantes : Form
    {
        public static SqlConnection ConexionDB()
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
        public Tablainfantes()
        {
            InitializeComponent();

            //mostrando tablas
            string consulta = "select nromatricula , nombre from Infantes where FechaBaja is null order by Nombre";
            SqlConnection conexion = ConexionDB();
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            tabla.DataSource = dt;
            conexion.Close();

        }

        //no tocar por si acaso
        private void Tablainfantes_Load(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
