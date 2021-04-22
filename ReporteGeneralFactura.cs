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
    public partial class ReporteGeneralFactura : Form
    {
        public ReporteGeneralFactura()
        {
            InitializeComponent();
        }

        private void ReporteGeneralFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FerreteriaDataSet2.DETALLE_FACTURA' table. You can move, or remove it, as needed.
            this.DETALLE_FACTURATableAdapter.Fill(this.FerreteriaDataSet2.DETALLE_FACTURA);
            // TODO: This line of code loads data into the 'FerreteriaDataSet1.FACTURA' table. You can move, or remove it, as needed.
            this.FACTURATableAdapter.Fill(this.FerreteriaDataSet1.FACTURA);
            // TODO: This line of code loads data into the 'FerreteriaDataSet.FACTURA1' table. You can move, or remove it, as needed.
            this.FACTURA1TableAdapter.Fill(this.FerreteriaDataSet.FACTURA1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form VentanaReportes = new VentanaReportes();
            this.Hide();
            VentanaReportes.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
