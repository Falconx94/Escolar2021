using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolar2021.Clases
{
    class Conexion
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string servidor = "FALCON-DELL",query;
        bool band = false;

        public bool Con_Main()
        {
            try
            {
                con = new SqlConnection("Data Source=" + servidor + ";Initial Catalog=Escolar2021;Integrated Security=True");
                con.Open();
                band = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión a la base de datos error: " + ex.ToString());
                band = false;
            }
            return band;
        }
        public bool Buscar(string usuario)
        {
            try
            {
                Con_Main();
                query = "Select * from usuarios where us_login = '" + usuario + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    band = true;
                }
                else
                {
                    band = false;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo la consulta " + ex.ToString());
            }
            return band;
        }
        public bool Confirma_Pass(string usuario, string password)
        {
            try
            {
                Con_Main();
                query = "Select * from usuarios where us_login = '" + usuario + "' and us_password = '" + password + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    band = true;
                }
                else
                {
                    band = false;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo la consulta " + ex.ToString());
            }
            return band;
        }
    }
}
