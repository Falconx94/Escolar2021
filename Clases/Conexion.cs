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
        string servidor = "FALCON-DELL";
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
                cmd = new SqlCommand("Select * from usuarios" +
                    " where nombre = '"+usuario+"' ", con);
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
