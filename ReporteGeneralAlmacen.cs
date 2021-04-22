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
    public partial class ReporteGeneralAlmacen : Form
    {
        public ReporteGeneralAlmacen()
        {
            InitializeComponent();
        }

        private void ReporteGeneralAlmacen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FerreteriaDataSet.ARTICULO' table. You can move, or remove it, as needed.
            this.ARTICULOTableAdapter.Fill(this.FerreteriaDataSet.ARTICULO);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form VentanaReportes = new VentanaReportes();
            this.Hide();
            VentanaReportes.Show();
        }
    }
}
