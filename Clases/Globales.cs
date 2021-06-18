using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Escolar2021.Clases;

namespace Escolar2021.Clases
{
    class Globales
    {
        public static string AU_usuario;
        public static int AU_nivel;
        public static int AU_actividad;
        public static DateTime AU_fecha;
        string query;
        string servidor = "FALCON-DELL";
        bool band = false;
        SqlConnection con;
        SqlCommand cmd;
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
        public void Auditoria(string AU_actividad, string AU_usuario, DateTime AU_fecha)
        {
            if(Con_Main())
            {
                query = "insert into auditoria values(@au_login,@au_fecha,@au_actividad)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@au_login", AU_usuario);
                cmd.Parameters.AddWithValue("@au_fecha", AU_fecha);
                cmd.Parameters.AddWithValue("@au_actividad", AU_actividad);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
