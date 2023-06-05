using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBaseDatos.Models
{
    public class Conexion
    {
        public Conexion()
        {

        }
        public SqlConnection ConexionDb()
        {
            string connString = "Data Source = ATHENEA ; Initial Catalog = GuarderiaFinal; User ID = jorge; Password = Password";
            //string connString = "Data Source = EMILIANA\\MSSQLSERVER01 ; Initial Catalog = GuarderiaFinal; User ID = emifinal; Password = Passw0rd";
            //string connString = "Data Source = Fabian\\SQLEXPRESS01 ; Initial Catalog = GuarderiaFinal; User ID = Fabiaan; Password = Password";
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
    }
}
