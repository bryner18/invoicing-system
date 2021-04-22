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
    public partial class ReporteGeneralCliente : Form
    {
        public ReporteGeneralCliente()
        {
            InitializeComponent();
        }

        private void ReporteGeneralCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FerreteriaDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.CLIENTETableAdapter.Fill(this.FerreteriaDataSet.CLIENTE);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form VentantaReportes = new VentanaReportes();
            this.Hide();
            VentantaReportes.Show();
        }
    }
}
