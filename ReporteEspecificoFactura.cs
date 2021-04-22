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
    public partial class ReporteEspecificoFactura : Form
    {
        public ReporteEspecificoFactura()
        {
            InitializeComponent();
        }

        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }

        private void ReporteEspecificoFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FerreteriaDataSet2.ReporteEspecificoFacturaFecha' table. You can move, or remove it, as needed.
            //this.ReporteEspecificoFacturaFechaTableAdapter.Fill(this.FerreteriaDataSet2.ReporteEspecificoFacturaFecha,fecha1,fecha2);
            // TODO: This line of code loads data into the 'FerreteriaDataSet.ARTICULO' table. You can move, or remove it, as needed.


            //this.reportViewer1.RefreshReport();
            this.ReporteEspecificoFacturaFechaTableAdapter.FillByGeneral(this.FerreteriaDataSet2.ReporteEspecificoFacturaFecha);
            this.reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form VentanaReportes = new VentanaReportes();
            this.Hide();
            VentanaReportes.Show();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            fecha1 = dtFecha1.Value;
            fecha2 = dtFecha2.Value;

            this.ReporteEspecificoFacturaFechaTableAdapter.Fill(this.FerreteriaDataSet2.ReporteEspecificoFacturaFecha, fecha1, fecha2);
            this.reportViewer1.RefreshReport();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            this.ReporteEspecificoFacturaFechaTableAdapter.FillByID(this.FerreteriaDataSet2.ReporteEspecificoFacturaFecha, Convert.ToInt32(txtCodigo.Text));
            this.reportViewer1.RefreshReport();

            txtCodigo.Text = "";
        }

        private void btnCodigoCliente_Click(object sender, EventArgs e)
        {
            this.ReporteEspecificoFacturaFechaTableAdapter.FillByCliente(this.FerreteriaDataSet2.ReporteEspecificoFacturaFecha, Convert.ToInt32(txtCodigoCliente.Text));
            this.reportViewer1.RefreshReport();

            txtCodigoCliente.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReporteEspecificoFacturaFechaTableAdapter.FillByGeneral(this.FerreteriaDataSet2.ReporteEspecificoFacturaFecha);
            this.reportViewer1.RefreshReport();
        }
    }
}
