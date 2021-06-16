
namespace Escolar2021.Forms
{
    partial class Form_respaldo
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
            this.Lbl_Ruta = new System.Windows.Forms.Label();
            this.TxBx_Ruta = new System.Windows.Forms.TextBox();
            this.Bt_Respaldo = new System.Windows.Forms.Button();
            this.Bt_exit = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Lbl_Escoge_Respaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Ruta
            // 
            this.Lbl_Ruta.AutoSize = true;
            this.Lbl_Ruta.Location = new System.Drawing.Point(27, 65);
            this.Lbl_Ruta.Name = "Lbl_Ruta";
            this.Lbl_Ruta.Size = new System.Drawing.Size(101, 15);
            this.Lbl_Ruta.TabIndex = 0;
            this.Lbl_Ruta.Text = "Ruta de Respaldo:";
            // 
            // TxBx_Ruta
            // 
            this.TxBx_Ruta.Location = new System.Drawing.Point(134, 61);
            this.TxBx_Ruta.Name = "TxBx_Ruta";
            this.TxBx_Ruta.Size = new System.Drawing.Size(343, 23);
            this.TxBx_Ruta.TabIndex = 1;
            // 
            // Bt_Respaldo
            // 
            this.Bt_Respaldo.Location = new System.Drawing.Point(140, 141);
            this.Bt_Respaldo.Name = "Bt_Respaldo";
            this.Bt_Respaldo.Size = new System.Drawing.Size(75, 48);
            this.Bt_Respaldo.TabIndex = 2;
            this.Bt_Respaldo.Text = "Generar Respaldo";
            this.Bt_Respaldo.UseVisualStyleBackColor = true;
            this.Bt_Respaldo.Click += new System.EventHandler(this.Bt_Respaldo_Click);
            // 
            // Bt_exit
            // 
            this.Bt_exit.Location = new System.Drawing.Point(325, 141);
            this.Bt_exit.Name = "Bt_exit";
            this.Bt_exit.Size = new System.Drawing.Size(75, 48);
            this.Bt_exit.TabIndex = 3;
            this.Bt_exit.Text = "Salir";
            this.Bt_exit.UseVisualStyleBackColor = true;
            this.Bt_exit.Click += new System.EventHandler(this.Bt_exit_Click);
            // 
            // Lbl_Escoge_Respaldo
            // 
            this.Lbl_Escoge_Respaldo.AutoSize = true;
            this.Lbl_Escoge_Respaldo.Location = new System.Drawing.Point(140, 26);
            this.Lbl_Escoge_Respaldo.Name = "Lbl_Escoge_Respaldo";
            this.Lbl_Escoge_Respaldo.Size = new System.Drawing.Size(280, 15);
            this.Lbl_Escoge_Respaldo.TabIndex = 4;
            this.Lbl_Escoge_Respaldo.Text = "Click aquí para escoger carpeta destino del respaldo";
            this.Lbl_Escoge_Respaldo.Click += new System.EventHandler(this.Lbl_Escoge_Respaldo_Click);
            // 
            // Form_respaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 235);
            this.Controls.Add(this.Lbl_Escoge_Respaldo);
            this.Controls.Add(this.Bt_exit);
            this.Controls.Add(this.Bt_Respaldo);
            this.Controls.Add(this.TxBx_Ruta);
            this.Controls.Add(this.Lbl_Ruta);
            this.Name = "Form_respaldo";
            this.Text = "Form_respaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Ruta;
        private System.Windows.Forms.TextBox TxBx_Ruta;
        private System.Windows.Forms.Button Bt_Respaldo;
        private System.Windows.Forms.Button Bt_exit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Lbl_Escoge_Respaldo;
    }
}