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
    public partial class SeleccionCliente : Form
    {
        public SeleccionCliente()
        {
            InitializeComponent();
        }

        private void SeleccionCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferreteriaDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.ferreteriaDataSet.CLIENTE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Factura IdClie = Owner as Factura;
            IdClie.txtCliente.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
