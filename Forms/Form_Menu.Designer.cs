
namespace Escolar2021.Forms
{
    partial class Form_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtMn_Registro = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMn_Consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMn_Informes = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMn_Auditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMn_Utileria = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMn_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnReg_Inscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnReg_ReInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnReg_Calificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnReg_Profesores = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnReg_Asignaturas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnReg_Carreras = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnInf_Kardex = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnInf_Boleta = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnInf_ListasDeAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnInf_ActaDeCalificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.BtMnUtl_Respaldo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtMn_Registro,
            this.BtMn_Consultas,
            this.BtMn_Informes,
            this.BtMn_Auditoria,
            this.BtMn_Utileria,
            this.BtMn_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtMn_Registro
            // 
            this.BtMn_Registro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtMnReg_Inscripciones,
            this.BtMnReg_ReInscripciones,
            this.BtMnReg_Calificaciones,
            this.BtMnReg_Profesores,
            this.BtMnReg_Asignaturas,
            this.BtMnReg_Carreras});
            this.BtMn_Registro.Name = "BtMn_Registro";
            this.BtMn_Registro.Size = new System.Drawing.Size(67, 20);
            this.BtMn_Registro.Text = "Registros";
            // 
            // BtMn_Consultas
            // 
            this.BtMn_Consultas.Name = "BtMn_Consultas";
            this.BtMn_Consultas.Size = new System.Drawing.Size(71, 20);
            this.BtMn_Consultas.Text = "Consultas";
            // 
            // BtMn_Informes
            // 
            this.BtMn_Informes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtMnInf_Kardex,
            this.BtMnInf_Boleta,
            this.BtMnInf_ListasDeAsistencia,
            this.BtMnInf_ActaDeCalificaciones});
            this.BtMn_Informes.Name = "BtMn_Informes";
            this.BtMn_Informes.Size = new System.Drawing.Size(66, 20);
            this.BtMn_Informes.Text = "Informes";
            // 
            // BtMn_Auditoria
            // 
            this.BtMn_Auditoria.Name = "BtMn_Auditoria";
            this.BtMn_Auditoria.Size = new System.Drawing.Size(68, 20);
            this.BtMn_Auditoria.Text = "Auditoria";
            // 
            // BtMn_Utileria
            // 
            this.BtMn_Utileria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtMnUtl_Respaldo});
            this.BtMn_Utileria.Name = "BtMn_Utileria";
            this.BtMn_Utileria.Size = new System.Drawing.Size(56, 20);
            this.BtMn_Utileria.Text = "Utileria";
            // 
            // BtMn_Salir
            // 
            this.BtMn_Salir.Name = "BtMn_Salir";
            this.BtMn_Salir.Size = new System.Drawing.Size(41, 20);
            this.BtMn_Salir.Text = "Salir";
            this.BtMn_Salir.Click += new System.EventHandler(this.BtMn_Salir_Click);
            // 
            // BtMnReg_Inscripciones
            // 
            this.BtMnReg_Inscripciones.Name = "BtMnReg_Inscripciones";
            this.BtMnReg_Inscripciones.Size = new System.Drawing.Size(180, 22);
            this.BtMnReg_Inscripciones.Text = "Inscripciones";
            // 
            // BtMnReg_ReInscripciones
            // 
            this.BtMnReg_ReInscripciones.Name = "BtMnReg_ReInscripciones";
            this.BtMnReg_ReInscripciones.Size = new System.Drawing.Size(180, 22);
            this.BtMnReg_ReInscripciones.Text = "Re-Inscripciones";
            // 
            // BtMnReg_Calificaciones
            // 
            this.BtMnReg_Calificaciones.Name = "BtMnReg_Calificaciones";
            this.BtMnReg_Calificaciones.Size = new System.Drawing.Size(180, 22);
            this.BtMnReg_Calificaciones.Text = "Calificaciones";
            // 
            // BtMnReg_Profesores
            // 
            this.BtMnReg_Profesores.Name = "BtMnReg_Profesores";
            this.BtMnReg_Profesores.Size = new System.Drawing.Size(180, 22);
            this.BtMnReg_Profesores.Text = "Profesores";
            // 
            // BtMnReg_Asignaturas
            // 
            this.BtMnReg_Asignaturas.Name = "BtMnReg_Asignaturas";
            this.BtMnReg_Asignaturas.Size = new System.Drawing.Size(180, 22);
            this.BtMnReg_Asignaturas.Text = "Asignaturas";
            // 
            // BtMnReg_Carreras
            // 
            this.BtMnReg_Carreras.Name = "BtMnReg_Carreras";
            this.BtMnReg_Carreras.Size = new System.Drawing.Size(180, 22);
            this.BtMnReg_Carreras.Text = "Carreras";
            // 
            // BtMnInf_Kardex
            // 
            this.BtMnInf_Kardex.Name = "BtMnInf_Kardex";
            this.BtMnInf_Kardex.Size = new System.Drawing.Size(190, 22);
            this.BtMnInf_Kardex.Text = "Kardex";
            // 
            // BtMnInf_Boleta
            // 
            this.BtMnInf_Boleta.Name = "BtMnInf_Boleta";
            this.BtMnInf_Boleta.Size = new System.Drawing.Size(190, 22);
            this.BtMnInf_Boleta.Text = "Boleta";
            // 
            // BtMnInf_ListasDeAsistencia
            // 
            this.BtMnInf_ListasDeAsistencia.Name = "BtMnInf_ListasDeAsistencia";
            this.BtMnInf_ListasDeAsistencia.Size = new System.Drawing.Size(190, 22);
            this.BtMnInf_ListasDeAsistencia.Text = "Listas de Asistencia";
            // 
            // BtMnInf_ActaDeCalificaciones
            // 
            this.BtMnInf_ActaDeCalificaciones.Name = "BtMnInf_ActaDeCalificaciones";
            this.BtMnInf_ActaDeCalificaciones.Size = new System.Drawing.Size(190, 22);
            this.BtMnInf_ActaDeCalificaciones.Text = "Acta de Calificaciones";
            // 
            // BtMnUtl_Respaldo
            // 
            this.BtMnUtl_Respaldo.Name = "BtMnUtl_Respaldo";
            this.BtMnUtl_Respaldo.Size = new System.Drawing.Size(214, 22);
            this.BtMnUtl_Respaldo.Text = "Respaldo de Base de Datos";
            this.BtMnUtl_Respaldo.Click += new System.EventHandler(this.BtMnUtl_Respaldo_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 476);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Menu";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtMn_Registro;
        private System.Windows.Forms.ToolStripMenuItem BtMn_Consultas;
        private System.Windows.Forms.ToolStripMenuItem BtMnReg_Inscripciones;
        private System.Windows.Forms.ToolStripMenuItem BtMnReg_ReInscripciones;
        private System.Windows.Forms.ToolStripMenuItem BtMnReg_Calificaciones;
        private System.Windows.Forms.ToolStripMenuItem BtMnReg_Profesores;
        private System.Windows.Forms.ToolStripMenuItem BtMnReg_Asignaturas;
        private System.Windows.Forms.ToolStripMenuItem BtMnReg_Carreras;
        private System.Windows.Forms.ToolStripMenuItem BtMn_Informes;
        private System.Windows.Forms.ToolStripMenuItem BtMnInf_Kardex;
        private System.Windows.Forms.ToolStripMenuItem BtMnInf_Boleta;
        private System.Windows.Forms.ToolStripMenuItem BtMnInf_ListasDeAsistencia;
        private System.Windows.Forms.ToolStripMenuItem BtMnInf_ActaDeCalificaciones;
        private System.Windows.Forms.ToolStripMenuItem BtMn_Auditoria;
        private System.Windows.Forms.ToolStripMenuItem BtMn_Utileria;
        private System.Windows.Forms.ToolStripMenuItem BtMnUtl_Respaldo;
        private System.Windows.Forms.ToolStripMenuItem BtMn_Salir;
    }
}