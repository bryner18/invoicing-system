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

namespace Sistema_Construrama
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");
        SqlConnection ConexionDetalle = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Form Inicio = new Inicio();
            this.Hide();
            Inicio.Show();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDArt.Text != "" && txtNomArt.Text != "" && txtPrecArt.Text != "" && txtCantArt.Text != "")
                {
                    ListaVenta[Fila, 0] = txtIDArt.Text;
                    ListaVenta[Fila, 1] = txtNomArt.Text;
                    ListaVenta[Fila, 2] = txtPrecArt.Text;
                    ListaVenta[Fila, 3] = txtCantArt.Text;
                    ListaVenta[Fila, 4] = (float.Parse(txtPrecArt.Text) * float.Parse(txtCantArt.Text)).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);

                    Fila++;
                    txtIDArt.Text = txtNomArt.Text = txtPrecArt.Text = txtCantArt.Text = "";
                }
            }
            catch
            {

            }
            CostoAPagar();
        }

        public void CostoAPagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvLista.RowCount;

            for (int i = 0; i < Conteo; i++)
            {
                CostoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }
            lblCostoAPagar.Text = CostoTotal.ToString();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblCostoAPagar.Text)).ToString();
            }
            catch
            {

                lblDevolucion.Text = "0.00";
            }
        }

        private void btnQuitarArt_Click(object sender, EventArgs e)
        {          
            dgvLista.Rows.Remove(dgvLista.CurrentRow); 
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("Insert into FACTURA values(@id_cliente, @monto_total, @fecha)", conexion);
            conexion.Open();

            try
            {
                agregar.Parameters.AddWithValue("@id_cliente", Convert.ToString(txtCliente.Text));
                agregar.Parameters.AddWithValue("@monto_total", Convert.ToString(lblCostoAPagar.Text));
                agregar.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtFecha.Value));

                agregar.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura" + ex);
            }
            finally
            {
                conexion.Close();
            }

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");
            SqlCommand Comm1 = new SqlCommand("SELECT id_factura FROM FACTURA WHERE id_factura = (SELECT MAX(id_factura) from FACTURA)", Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                txtIDFact.Text = DR1.GetValue(0).ToString();
            }
            Conn.Close();

            SqlCommand AgregarDetalle = new SqlCommand("insert into DETALLE_FACTURA values(@id_fact, @id_art, @prec_art, @cant_art, @id_cliente, @fecha)", ConexionDetalle);
            ConexionDetalle.Open();

            try
            {
                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    AgregarDetalle.Parameters.Clear();
                    AgregarDetalle.Parameters.AddWithValue("@id_fact", Convert.ToString(txtIDFact.Text));
                    AgregarDetalle.Parameters.AddWithValue("@id_art", Convert.ToString(row.Cells["column1"].Value));
                    AgregarDetalle.Parameters.AddWithValue("@prec_art", Convert.ToString(row.Cells["column4"].Value));
                    AgregarDetalle.Parameters.AddWithValue("@cant_art", Convert.ToString(row.Cells["column3"].Value));
                    AgregarDetalle.Parameters.AddWithValue("@id_cliente", Convert.ToString(txtCliente.Text));
                    AgregarDetalle.Parameters.AddWithValue("@fecha", Convert.ToString(dtFecha.Text));

                    AgregarDetalle.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                ConexionDetalle.Close();
            }

            //Desde aqui copiamos
            clsFuncion.CreaTicket Ticket1 = new clsFuncion.CreaTicket();

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("Ferretería Construrama"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc: Almirante Calle L #10");
            Ticket1.TextoIzquierda("Tel: (809) 699 - 4607");
            Ticket1.TextoIzquierda("Rnc: 130668485");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: " + txtIDFact.Text);
            Ticket1.TextoIzquierda("Fecha: " + DateTime.Now.ToShortDateString() + " Hora: " + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: Bryner ");///////////////////////////////////
            Ticket1.TextoIzquierda("Cliente: " + txtCliente.Text);///////////////////////////////////
            Ticket1.TextoIzquierda("");
            clsFuncion.CreaTicket.LineasGuion();

            clsFuncion.CreaTicket.EncabezadoVenta();
            clsFuncion.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFuncion.CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Sub-Total", double.Parse(lblCostoAPagar.Text)); // imprime linea con total
            Ticket1.AgregaTotales("Menos Descuento", double.Parse("0")); // imprime linea con total
            Ticket1.AgregaTotales("Mas ITBIS", double.Parse("0")); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblCostoAPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer"; //mpueden usar variable
            Ticket1.ImprimirTiket(impresora);
            //hasta aqui el codigo de imprimir


            Fila = 0;
            while (dgvLista.RowCount > 0)//limpia el dgv
            { dgvLista.Rows.Remove(dgvLista.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
            txtIDArt.Text = txtNomArt.Text = txtCliente.Text = txtPrecArt.Text = txtCantArt.Text = txtEfectivo.Text = "";
            lblCostoAPagar.Text = lblDevolucion.Text = "0.00";

        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {

            ////Desde aqui copiamos
            //clsFuncion.CreaTicket Ticket1 = new clsFuncion.CreaTicket();

            //Ticket1.TextoCentro("**********************************");
            //Ticket1.TextoCentro("Ferretería Construrama"); //imprime una linea de descripcion
            //Ticket1.TextoCentro("**********************************");

            //Ticket1.TextoIzquierda("Dirc: Almirante Calle L #10");
            //Ticket1.TextoIzquierda("Tel: (809) 699 - 4607");
            //Ticket1.TextoIzquierda("Rnc: 130668485");
            //Ticket1.TextoIzquierda("");
            //Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            //Ticket1.TextoIzquierda("No Fac: " + txtIDFact.Text);
            //Ticket1.TextoIzquierda("Fecha: " + DateTime.Now.ToShortDateString() + " Hora: " + DateTime.Now.ToShortTimeString());
            //Ticket1.TextoIzquierda("Le Atendio: Bryner ");///////////////////////////////////
            //Ticket1.TextoIzquierda("Cliente: " + txtCliente.Text);///////////////////////////////////
            //Ticket1.TextoIzquierda("");
            //clsFuncion.CreaTicket.LineasGuion();

            //clsFuncion.CreaTicket.EncabezadoVenta();
            //clsFuncion.CreaTicket.LineasGuion();
            //foreach (DataGridViewRow r in dgvLista.Rows)
            //{ //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 
            //    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            //}


            //clsFuncion.CreaTicket.LineasGuion();
            //Ticket1.AgregaTotales("Sub-Total", double.Parse(lblCostoAPagar.Text)); // imprime linea con total
            //Ticket1.AgregaTotales("Menos Descuento", double.Parse("0")); // imprime linea con total
            //Ticket1.AgregaTotales("Mas ITBIS", double.Parse("0")); // imprime linea con total
            //Ticket1.TextoIzquierda(" ");
            //Ticket1.AgregaTotales("Total", double.Parse(lblCostoAPagar.Text)); // imprime linea con total
            //Ticket1.TextoIzquierda(" ");
            //Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            //Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            //// Ticket1.LineasTotales(); // imprime linea 

            //Ticket1.TextoIzquierda(" ");
            //Ticket1.TextoCentro("**********************************");
            //Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            //Ticket1.TextoCentro("**********************************");
            //Ticket1.TextoIzquierda(" ");
            //string impresora = "Microsoft XPS Document Writer"; //mpueden usar variable
            //Ticket1.ImprimirTiket(impresora);
            ////hasta aqui el codigo de imprimir


            //Fila = 0;
            //while (dgvLista.RowCount > 0)//limpia el dgv
            //{ dgvLista.Rows.Remove(dgvLista.CurrentRow); }
            ////LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
            //txtIDArt.Text = txtNomArt.Text = txtCliente.Text = txtPrecArt.Text = txtCantArt.Text = txtEfectivo.Text = "";
            //lblCostoAPagar.Text = lblDevolucion.Text = "0.00";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form Seleccionar = new SeleccionCliente();

            AddOwnedForm(Seleccionar);
            Seleccionar.FormBorderStyle = FormBorderStyle.None;
            Seleccionar.TopLevel = false;
            Seleccionar.Dock = DockStyle.Fill;
            this.Controls.Add(Seleccionar);
            this.Tag = Seleccionar;
            Seleccionar.BringToFront();
            Seleccionar.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form AgreArt = new SeleccionAlmacen();
            AddOwnedForm(AgreArt);
            AgreArt.FormBorderStyle = FormBorderStyle.None;
            AgreArt.TopLevel = false;
            AgreArt.Dock = DockStyle.Fill;
            this.Controls.Add(AgreArt);
            this.Tag = AgreArt;
            AgreArt.BringToFront();
            AgreArt.Show();
        }

        public void txtIDFact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
