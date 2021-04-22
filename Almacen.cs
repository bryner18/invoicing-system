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
    public partial class Almacen : Form
    {
        ConexionBD c = new ConexionBD();
        SqlCommand cmd;

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");
        private SqlConnection cn;
        public Almacen()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form a = new Inicio();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand Agregar = conexion.CreateCommand();
            Agregar.CommandType = CommandType.Text;
            Agregar.CommandText = "insert into ARTICULO values('" + txtNomArt.Text + "'," + txtCantArt.Text + "," + txtPrecArt.Text + ",'" + txtDescArt.Text + "', '')";
            Agregar.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("El articulo ha sido almacenado exitosamente");

            this.aRTICULOTableAdapter.Fill(this.ferreteriaDataSet.ARTICULO);

            txtNomArt.Text = "";
            txtCantArt.Text = "";
            txtPrecArt.Text = "";
            txtDescArt.Text = "";

        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferreteriaDataSet.ARTICULO' table. You can move, or remove it, as needed.
            this.aRTICULOTableAdapter.Fill(this.ferreteriaDataSet.ARTICULO);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c.ArticuloEliminado(Convert.ToInt32(txtProvArt.Text)) == 0)
            {
                c.ArticuloEliminado(Convert.ToInt32(txtProvArt.Text));
                MessageBox.Show("El articulo ha sido deshabilitado");

                txtProvArt.Text = "";
                txtNomArt.Text = "";
                txtCantArt.Text = "";
                txtPrecArt.Text = "";
                txtDescArt.Text = "";
            }

            this.aRTICULOTableAdapter.Fill(this.ferreteriaDataSet.ARTICULO);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand Modificar = conexion.CreateCommand();
            Modificar.CommandType = CommandType.Text;
            Modificar.CommandText = "update ARTICULO set cant_art = " + txtCantArt.Text + ", prec_art = " + txtPrecArt.Text + " where id_art = " + txtProvArt.Text;
            Modificar.ExecuteNonQuery();
            conexion.Close();

            this.aRTICULOTableAdapter.Fill(this.ferreteriaDataSet.ARTICULO);

            MessageBox.Show("El articulo ha sido actualizado exitosamente");

            txtCantArt.Text = "";
            txtPrecArt.Text = "";
            txtProvArt.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox1);
        }
    }
}
