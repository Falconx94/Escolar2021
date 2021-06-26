using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Escolar2021.Forms;
using Escolar2021.Clases;

namespace Escolar2021.Forms
{
    public partial class Form_Menu : Form
    {
        string AU_actividad, AU_usuario;
        DateTime AU_fecha;
        int AU_Nivel;
        DateTime Mn_Fecha;
        Globales glb = new Globales();
        Form_respaldo resp = new Form_respaldo();
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            switch(Clases.Globales.nivel)
            {
                case 2: //NIVEL OPERADOR
                    BtMn_Auditoria.Enabled = false;
                    BtMnReg_Inscripciones.Enabled = false;
                    BtMn_Informes.Enabled = false;
                    break;
                case 3: //NIVEL INVITADO
                    BtMn_Auditoria.Enabled = false;
                    BtMnReg_Inscripciones.Enabled = false;
                    BtMn_Informes.Enabled = false;
                    BtMnUtl_Respaldo.Enabled = false;
                    break;
            }
        }
        #region Botones y Textos
        private void BtMn_Salir_Click(object sender, EventArgs e)
        {
            AU_fecha = DateTime.Now;
            AU_usuario = Clases.Globales.usuario;
            AU_actividad = "Cerro sesion";
            glb.Auditoria(AU_actividad, AU_usuario, AU_fecha, AU_Nivel);
            Application.Exit();
        }

        private void BtMnUtl_Respaldo_Click(object sender, EventArgs e)
        {
            AU_fecha = DateTime.Now;
            AU_usuario = Clases.Globales.usuario;
            AU_actividad = "Ingreso a Respaldo de Base de Datos";
            glb.Auditoria(AU_actividad, AU_usuario, AU_fecha, AU_Nivel);
            resp.ShowDialog();
        }
        #endregion
    }
}
