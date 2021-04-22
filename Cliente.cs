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
    public partial class Cliente : Form
    {
        ConexionBD c = new ConexionBD();
        SqlCommand cmd;

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");
        private SqlConnection cn;
        public Cliente()
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
            SqlCommand Comando = conexion.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "insert into CLIENTE values('" + nom_cliTextBox.Text + "','" + ape_cliTextBox.Text + "','" + tel_cliTextBox.Text + "','" + ced_cliTextBox.Text + "','" + dir_cliTextBox.Text + "')";
            Comando.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("El cliente ha sido registrado correctamente");

            this.cLIENTETableAdapter.Fill(this.ferreteriaDataSet.CLIENTE);

            nom_cliTextBox.Text = "";
            ape_cliTextBox.Text = "";
            tel_cliTextBox.Text = "";
            ced_cliTextBox.Text = "";
            dir_cliTextBox.Text = "";

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            this.cLIENTETableAdapter.Fill(this.ferreteriaDataSet.CLIENTE);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox1);
        }

        private void cLIENTEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cLIENTEDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand Modificar = conexion.CreateCommand();
            Modificar.CommandType = CommandType.Text;
            Modificar.CommandText = "update CLIENTE set dir_cli = '" + dir_cliTextBox.Text + "', tel_cli = '" + tel_cliTextBox.Text + "' where ced_cli = '" + ced_cliTextBox.Text + "'";
            Modificar.ExecuteNonQuery();
            conexion.Close();

            this.cLIENTETableAdapter.Fill(this.ferreteriaDataSet.CLIENTE);

            MessageBox.Show("El cliente ha sido actualizado exitosamente");

            dir_cliTextBox.Text = "";
            tel_cliTextBox.Text = "";
            ced_cliTextBox.Text = "";
        }

        private void nom_cliLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
