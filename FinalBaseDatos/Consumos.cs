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
    public partial class Consumos : Form
    {
        private Inicio inicio;
        private ConsumoMenu consumomenu;
        private ConsumoTienda consumotienda;
        private ConsumosSA consumoservad;
        private StockAr stock;
        private ReponerStock rep;
        public Consumos()
        {
            InitializeComponent();
            inicio = new Inicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumomenu = new ConsumoMenu();
            consumomenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consumotienda = new ConsumoTienda();
            consumotienda.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consumoservad = new ConsumosSA();
            consumoservad.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            stock = new StockAr();
            stock.Show();
        }

        private void Reponer_Click(object sender, EventArgs e)
        {
            rep = new ReponerStock();
            rep.Show();
            this.Hide();
        }
    }
}
