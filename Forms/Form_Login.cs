using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escolar2021.Clases;
using Escolar2021.Forms;

namespace Escolar2021.Forms
{
    public partial class Form_Login : Form
    {
        string query, usuario, lvl, nivel, password, Ult_acceso, error, AU_actividad, AU_usuario;
        DateTime AU_fecha;
        string servidor = "FALCON-DELL", ruta_foto="A:\\Repositorios\\Escolar2021\\Fotos\\",foto;
        bool band = false;
        OpenFileDialog Img = new OpenFileDialog();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion conex = new Conexion();
        Globales glb = new Globales();
        Form_Menu mn = new Form_Menu();

        #region Metodos
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
                error = ex.ToString();
                band = false;
            }
            return band;
        }
        public void Desarmar()
        {
            TxBx_Pass.Enabled = false;
            TxBx_Lvl.Enabled = false;
            TxBx_Acces.Enabled = false;
        }
        
        public void Nivel_user()
        {
            Con_Main();
            query = "Select us_nivel from usuarios " +
                "where us_login = '"+usuario+"'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lvl = dr["us_nivel"].ToString();
                switch (lvl)
                {
                    case "1":
                        nivel = "Administrador";
                        break;
                    case "2":
                        nivel = "Operador";
                        break;
                    case "3":
                        nivel = "Invitado";
                        break;
                }
            }
            else
            {
                band = false;
            }
            dr.Close();
            TxBx_Lvl.Text = nivel;
        }
        public void Fotos()
        {
            switch (usuario)
            {
                case "Ricardo":
                    foto = ruta_foto + usuario + ".jpg";
                    FT_User.Image = Image.FromFile(foto);
                    break;
                case "Maria":
                    foto = ruta_foto + usuario + ".jpg";
                    FT_User.Image = Image.FromFile(foto);
                    break;
                case "Juan":
                    foto = ruta_foto + usuario + ".jpg";
                    FT_User.Image = Image.FromFile(foto);
                    break;
                case "Pedro":
                    foto = ruta_foto + usuario + ".jpg";
                    FT_User.Image = Image.FromFile(foto);
                    break;
            }
        }
        #endregion

        public Form_Login()
        {
            if (Con_Main())
            {
                InitializeComponent();
                Desarmar();
            }
            else
            {
                MessageBox.Show("Error en la conexión a la base de datos: " + error);
            }
        }
        #region Botones y Textos
        private void BT_Ingreso_Click(object sender, EventArgs e)
        {
            password = TxBx_Pass.Text;
            if (conex.Confirma_Pass(usuario, password))
            {
                AU_actividad = "Ingreso al Sistema escolar";
                AU_usuario = usuario;
                AU_fecha = Convert.ToDateTime(TxBx_Acces.Text);
                glb.Auditoria(AU_actividad, AU_usuario, AU_fecha);
                mn.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrectos");
            }
        }

        private void TxBx_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                usuario = TxBx_User.Text;
                if(conex.Buscar(usuario))
                {
                    Fotos();
                    Nivel_user();
                    TxBx_Acces.Text = DateTime.Now.ToString();
                    TxBx_Pass.Enabled = true;
                    TxBx_Pass.Focus();
                }
                else
                {
                    usuario = "profile-user";
                    ruta_foto = "A:\\Repositorios\\Escolar2021\\Icons\\";
                    foto = ruta_foto + usuario + ".png";
                    FT_User.Image = Image.FromFile(foto);
                }
            }
        }
        private void BT_Exit_Click(object sender, EventArgs e)
        {
            usuario = TxBx_User.Text;
            if (usuario != "")
            {
                AU_actividad = "Intento ingresar al Sistema escolar";
                AU_usuario = usuario;
                Ult_acceso = DateTime.Now.ToString();
                AU_fecha = Convert.ToDateTime(Ult_acceso);
                glb.Auditoria(AU_actividad, AU_usuario, AU_fecha);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        #endregion
    }
}
