using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Escolar2021.Clases;

namespace Escolar2021.Forms
{
    public partial class Form_respaldo : Form
    {
        Globales glb = new Globales();
        int AU_Nivel;
        string AU_actividad, AU_usuario;
        DateTime AU_fecha;
        string servidor = "FALCON-DELL";
        SqlConnection con;
        SqlCommand cmd;
        bool band = false;
        string  ruta,
                nombre_res = "\\Respaldo Escolar2021-",
                query,error;

        public Form_respaldo()
        {
            InitializeComponent();
            Bt_Respaldo.Enabled = false;
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
                ruta = folderBrowserDialog1.SelectedPath;
                query = "BACKUP DATABASE Escolar2021 TO DISK ='" + ruta + nombre_res + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak'";
                cmd = new SqlCommand(query, con);
                if (MessageBox.Show("Esta seguro de generar el respaldo??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Respaldo realizado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AU_fecha = DateTime.Now;
                    AU_usuario = Clases.Globales.usuario;
                    AU_actividad = "Creo Respaldo a Base de Datos";
                    glb.Auditoria(AU_actividad, AU_usuario, AU_fecha, AU_Nivel);
                }
                else
                {
                    MessageBox.Show("Respaldo Anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AU_fecha = DateTime.Now;
                    AU_usuario = Clases.Globales.usuario;
                    AU_actividad = "Anulo creacion de Respaldo a Base de Datos";
                    glb.Auditoria(AU_actividad, AU_usuario, AU_fecha, AU_Nivel);
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
        private void Lbl_Escoge_Respaldo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            TxBx_Ruta.Text = folderBrowserDialog1.SelectedPath + nombre_res + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak";
            Bt_Respaldo.Enabled = true;
        }
    }
}