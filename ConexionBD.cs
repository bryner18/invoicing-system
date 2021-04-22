using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Construrama
{
    class ConexionBD
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public ConexionBD()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        //GUARDAR CLIENTE
        public string Guardar(int id_cli, string nom_cli, string ape_cli, string tel_cli, string ced_cli, string dir_cli)
        {
            string salida = "Se ha Guardado Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into CLIENTE(id_cli,nom_cli,ape_cli,tel_cli,ced_cli,dir_cli) values(" + id_cli + ",'" + nom_cli + "','" + ape_cli + "','" + tel_cli + "','" + ced_cli + "','" + dir_cli + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Guardo:  " + ex.ToString();
            }
            return salida;
        }

        //CLIENTE REGISTRO
        public int ClienteRegistro(int id_cli)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from CLIENTE where id_cli=" + id_cli + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se consulto correctamente: " + ex.ToString());
            }
            return contador;
        }

        //GUARDAR ARTICULO
        public string GuardarArt(int id_art, string nom_art, string cant_art, string prec_art, string desc_art)
        {
            string salidaArt = "Se ha Guardado Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into ARTICULO(id_art,nom_art,cant_art,prec_art,desc_art) values(" + id_art + ",'" + nom_art + "','" + cant_art + "','" + prec_art + "','" + desc_art + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salidaArt = "No se Guardo:  " + ex.ToString();
            }
            return salidaArt;
        }

        //ARTICULO REGISTRO
        public int ArticuloRegitro(int id_art)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from ARTICULO where id_art=" + id_art + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se consulto correctamente: " + ex.ToString());
            }
            return contador;
        }

        //ELIMINAR ARTICULO
        public int ArticuloEliminado(int id_art)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("delete from ARTICULO where id_art=" + id_art + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Conecto: " + ex.ToString());
            }
            return contador;
        }
    }
}
