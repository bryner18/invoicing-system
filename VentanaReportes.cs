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
    public partial class VentanaReportes : Form
    {
        public VentanaReportes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form Inicio = new Inicio();
            this.Hide();
            Inicio.Show();
        }

        private void btnGeneralCliente_Click(object sender, EventArgs e)
        {
            Form ReporteGeneralCliente = new ReporteGeneralCliente();
            this.Hide();
            ReporteGeneralCliente.Show();
        }

        private void btnGeneralAlmacen_Click(object sender, EventArgs e)
        {
            Form ReporteGeneralAlmacen = new ReporteGeneralAlmacen();
            this.Hide();
            ReporteGeneralAlmacen.Show();
        }

        private void btnGenFactura_Click(object sender, EventArgs e)
        {
            Form ReporteGeneralFactura = new ReporteGeneralFactura();
            this.Hide();
            ReporteGeneralFactura.Show();
        }

        private void btnEspFactura_Click(object sender, EventArgs e)
        {
            Form ReporteEspecificoFactura = new ReporteEspecificoFactura();
            this.Hide();
            ReporteEspecificoFactura.Show();
        }

        private void btnEspAlmacen_Click(object sender, EventArgs e)
        {
            Form ReporteEspecificoAlmacen = new ReporteEspecificoAlmacen();
            this.Hide();
            ReporteEspecificoAlmacen.Show();
        }
    }
}
