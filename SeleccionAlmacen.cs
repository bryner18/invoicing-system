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
    public partial class SeleccionAlmacen : Form
    {
        public SeleccionAlmacen()
        {
            InitializeComponent();
        }

        private void SeleccionAlmacen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferreteriaDataSet.ARTICULO' table. You can move, or remove it, as needed.
            this.aRTICULOTableAdapter.Fill(this.ferreteriaDataSet.ARTICULO);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Factura AgreArt = Owner as Factura;
            AgreArt.txtIDArt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            AgreArt.txtNomArt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            AgreArt.txtPrecArt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            this.Close();
        }
    }
}
