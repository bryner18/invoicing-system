using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Sistema_Construrama
{
    public partial class ConsultarFactura : Form
    {
        public string Nombre = " ";
        public ConsultarFactura()
        {
            InitializeComponent();
        }

        private void ConsultarFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferreteriaDataSet.DETALLE_FACTURA' table. You can move, or remove it, as needed.
            this.dETALLE_FACTURATableAdapter.Fill(this.ferreteriaDataSet.DETALLE_FACTURA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Inicio = new Inicio();
            this.Hide();
            Inicio.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");

            if (rbCodigo.Checked == true)
            {
                Conn.Open();
                SqlDataAdapter Codigo = new SqlDataAdapter("SELECT id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA where id_fact = '" + txtBuscar.Text + "'", Conn);
                DataTable dataCodigo = new DataTable();
                Codigo.Fill(dataCodigo);
                dataGridView1.DataSource = dataCodigo;
            }

            if (rbCliente.Checked==true)
            {
                Conn.Open();
                SqlDataAdapter Cliente = new SqlDataAdapter("SELECT id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA where id_cliente = '" + txtBuscar.Text + "'", Conn);
                DataTable dataCliente = new DataTable();
                Cliente.Fill(dataCliente);
                dataGridView1.DataSource = dataCliente;
            }

            if (rbFecha.Checked == true)
            {
                Conn.Open();
                SqlDataAdapter Cliente = new SqlDataAdapter("SELECT id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA where fecha <= '" + dateFecha1.Value + "'", Conn);
                DataTable dataCliente = new DataTable();
                Cliente.Fill(dataCliente);
                dataGridView1.DataSource = dataCliente;
            }

            txtBuscar.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conn2 = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");

            Conn2.Open();
            SqlDataAdapter Refrescar = new SqlDataAdapter("SELECT id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA", Conn2);
            DataTable dataReferescar = new DataTable();
            Refrescar.Fill(dataReferescar);
            dataGridView1.DataSource = dataReferescar;

            txtBuscar.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
