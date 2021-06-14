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

namespace Escolar2021.Forms
{
    public partial class Form_Login : Form
    {
        string Query, usuario, Contraseña, Nivel, Ult_acceso, error;
        string servidor = "FALCON-DELL";
        bool band = false;
        SqlConnection con;
        Conexion conex;

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
        public void Armar()
        {
            TxBx_Pass.Enabled = true;
            TxBx_Lvl.Enabled = true;
            TxBx_Acces.Enabled = true;
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
        private void BT_Ingreso_Click(object sender, EventArgs e)
        {

        }

        private void TxBx_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                usuario = TxBx_User.Text;
                conex.Buscar(usuario);
                Armar();
            }
        }
    }
}
