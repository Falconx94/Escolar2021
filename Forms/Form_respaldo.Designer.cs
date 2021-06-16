
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxBx_Ruta = new System.Windows.Forms.TextBox();
            this.Bt_Respaldo = new System.Windows.Forms.Button();
            this.Bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta de Respaldo:";
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
            // Form_respaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 235);
            this.Controls.Add(this.Bt_exit);
            this.Controls.Add(this.Bt_Respaldo);
            this.Controls.Add(this.TxBx_Ruta);
            this.Controls.Add(this.label1);
            this.Name = "Form_respaldo";
            this.Text = "Form_respaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxBx_Ruta;
        private System.Windows.Forms.Button Bt_Respaldo;
        private System.Windows.Forms.Button Bt_exit;
    }
}