using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Escolar2021.Forms
{
    public partial class Form_respaldo : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string servidor = "FALCON-DELL";
        bool band = false;
        string
            ruta = "A:\\BaseDatos",
            nombre_res = "\\Respaldo Escolar2021-",
            query,error;

        public Form_respaldo()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + servidor + ";Initial Catalog=Escolar2021;Integrated Security=True");
        }

       
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

        public void Respaldo()
        {
            if (Con_Main())
            {
                this.TxBx_Ruta.Text = ruta + nombre_res + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak";
                query = "BACKUP DATABASE Escolar2021 TO DISK ='" + ruta + nombre_res + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak'";
                cmd = new SqlCommand(query, con);
                if (MessageBox.Show("Esta seguro de generar el respaldo??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Respaldo realizado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Respaldo Anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxBx_Ruta.Clear();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Error en la conexión a la base de datos: " + error);
            }
        }
        #endregion
        private void Bt_Respaldo_Click(object sender, EventArgs e)
        {
            Respaldo();
        }
        private void Bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}