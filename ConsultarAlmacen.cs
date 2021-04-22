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
    public partial class ConsultarAlmacen : Form
    {
        public ConsultarAlmacen()
        {
            InitializeComponent();
        }

        private void ConsultarAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Inicio = new Inicio();
            this.Hide();
            Inicio.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");

            if (rbCodigo.Checked == true)
            {
                Conn.Open();
                SqlDataAdapter Codigo = new SqlDataAdapter("SELECT id_art, nom_art, cant_art, prec_art, desc_art, prov_art from ARTICULO where id_art = '" + txtBuscar.Text + "'", Conn);
                DataTable dataCodigo = new DataTable();
                Codigo.Fill(dataCodigo);
                dgvAlmacen.DataSource = dataCodigo;
            }

            if (rbCantidad.Checked == true)
            {
                Conn.Open();
                SqlDataAdapter Cantidad = new SqlDataAdapter("SELECT id_art, nom_art, cant_art, prec_art, desc_art, prov_art from ARTICULO where cant_art <= '" + txtBuscar.Text + "'", Conn);
                DataTable dataCantidad = new DataTable();
                Cantidad.Fill(dataCantidad);
                dgvAlmacen.DataSource = dataCantidad;
            }

            if (rbPrecio.Checked == true)
            {
                Conn.Open();
                SqlDataAdapter Precio = new SqlDataAdapter("SELECT id_art, nom_art, cant_art, prec_art, desc_art, prov_art from ARTICULO where prec_art <= '" + txtBuscar.Text + "'", Conn);
                DataTable dataPrecio = new DataTable();
                Precio.Fill(dataPrecio);
                dgvAlmacen.DataSource = dataPrecio;
            }

            if (rbProveedor.Checked == true)
            {
                Conn.Open();
                SqlDataAdapter Proveedor = new SqlDataAdapter("SELECT id_art, nom_art, cant_art, prec_art, desc_art, prov_art from ARTICULO where prov_art = '" + txtBuscar.Text + "'", Conn);
                DataTable dataProveedor = new DataTable();
                Proveedor.Fill(dataProveedor);
                dgvAlmacen.DataSource = dataProveedor;

                txtBuscar.Text = "";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection Conn2 = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");

            Conn2.Open();
            SqlDataAdapter Refrescar = new SqlDataAdapter("SELECT id_art, nom_art, cant_art, prec_art, desc_art, prov_art from ARTICULO", Conn2);
            DataTable dataReferescar = new DataTable();
            Refrescar.Fill(dataReferescar);
            dgvAlmacen.DataSource = dataReferescar;

            txtBuscar.Text = "";
        }
    }
}
