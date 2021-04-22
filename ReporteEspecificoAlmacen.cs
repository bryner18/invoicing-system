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
    public partial class ReporteEspecificoAlmacen : Form
    {
        public ReporteEspecificoAlmacen()
        {
            InitializeComponent();
        }
        public Decimal Minimo { get; set; }
        public Decimal Maximo { get; set; }
        public int Cantidad { get; set; }
        public int  Proveedor { get; set; }

        public int Cant1 { get; set; }
        public int Cant2 { get; set; }


        private void ReporteEspecificoAlmacen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FerreteriaDataSet2.ReporteEspecificoAlmacenCantidad' table. You can move, or remove it, as needed.
            //this.ReporteEspecificoAlmacenCantidadTableAdapter.Fill(this.FerreteriaDataSet2.ReporteEspecificoAlmacenCantidad,Cant1,Cant2);

            //this.reportViewer1.RefreshReport();
            this.ReporteEspecificoAlmacenCantidadTableAdapter.FillByGeneral(this.FerreteriaDataSet2.ReporteEspecificoAlmacenCantidad);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form VentanaReportes = new VentanaReportes();
            this.Hide();
            VentanaReportes.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCant_Click(object sender, EventArgs e)
        {
            Cant1 = Convert.ToInt32(txtCantMin.Text);
            Cant2 = Convert.ToInt32(txtCantMax.Text);

            this.ReporteEspecificoAlmacenCantidadTableAdapter.Fill(this.FerreteriaDataSet2.ReporteEspecificoAlmacenCantidad, Cant1, Cant2);
            this.reportViewer1.RefreshReport();

            txtCantMin.Text = "";
            txtCantMax.Text = "";
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            Proveedor = Convert.ToInt32(txtCodigoCliente.Text);

            this.ReporteEspecificoAlmacenCantidadTableAdapter.FillByProv(this.FerreteriaDataSet2.ReporteEspecificoAlmacenCantidad, Proveedor);
            this.reportViewer1.RefreshReport();

            txtCodigoCliente.Text = "";
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            Minimo = Convert.ToDecimal(txtPrecioMin.Text);
            Maximo = Convert.ToDecimal(txtPrecioMax.Text);

            this.ReporteEspecificoAlmacenCantidadTableAdapter.FillByPrecio(this.FerreteriaDataSet2.ReporteEspecificoAlmacenCantidad, Minimo, Maximo);
            this.reportViewer1.RefreshReport();

            txtPrecioMax.Text = "";
            txtPrecioMin.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ReporteEspecificoAlmacenCantidadTableAdapter.FillByGeneral(this.FerreteriaDataSet2.ReporteEspecificoAlmacenCantidad);
            this.reportViewer1.RefreshReport();
        }
    }
}
