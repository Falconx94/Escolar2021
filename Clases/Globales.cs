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
        public static string usuario;
        public static int nivel;
        public static string actividad;
        public static DateTime fecha;
        string query,error;
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
                error = "Error en la conexión a la base de datos error: " + ex.ToString();
                band = false;
            }
            return band;
        }
        public void Auditoria(string AU_actividad, string AU_usuario, DateTime AU_fecha)
        {
            if (Con_Main())
            {
                usuario = AU_usuario;
                fecha = AU_fecha;
                actividad = AU_actividad;
                Inserta_Auditoria();
                Actualiza_Usuario();
                con.Close();
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        public void Inserta_Auditoria()
        {
            query = "insert into auditoria values(@au_login,@au_fecha,@au_actividad)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@au_login", usuario);
            cmd.Parameters.AddWithValue("@au_fecha", fecha);
            cmd.Parameters.AddWithValue("@au_actividad", actividad);
            cmd.ExecuteNonQuery();
        }
        public void Actualiza_Usuario()
        {
            query = "update usuarios set us_ultimoacceso = @au_fecha where us_login = @au_login";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@au_login", usuario);
            cmd.Parameters.AddWithValue("@au_fecha", fecha);
            cmd.ExecuteNonQuery();
        }
    }
}
