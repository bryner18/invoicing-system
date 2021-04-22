using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Construrama
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cliente = new Cliente();
            this.Hide();
            Cliente.Show();
        }

        private void aLMACÉNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Almacen = new Almacen();
            this.Hide();
            Almacen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            this.Hide();
            Login.Show();
        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Factura = new Factura();
            this.Hide();
            Factura.Show();
        }

        private void rEPORTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Reportes = new VentanaReportes();
            this.Hide();
            Reportes.Show();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ConsultarFactura = new ConsultarFactura();
            this.Hide();
            ConsultarFactura.Show();
        }

        private void aLMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ConsultarAlmacen = new ConsultarAlmacen();
            this.Hide();
            ConsultarAlmacen.Show();
        }
    }
}
