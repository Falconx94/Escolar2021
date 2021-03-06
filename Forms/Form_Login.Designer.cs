
namespace Escolar2021.Forms
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.TxBx_User = new System.Windows.Forms.TextBox();
            this.TxBx_Pass = new System.Windows.Forms.TextBox();
            this.TxBx_Lvl = new System.Windows.Forms.TextBox();
            this.TxBx_Acces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Ingreso = new System.Windows.Forms.Button();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.FT_User = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FT_User)).BeginInit();
            this.SuspendLayout();
            // 
            // TxBx_User
            // 
            this.TxBx_User.Location = new System.Drawing.Point(150, 48);
            this.TxBx_User.Name = "TxBx_User";
            this.TxBx_User.Size = new System.Drawing.Size(171, 23);
            this.TxBx_User.TabIndex = 0;
            this.TxBx_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBx_User_KeyPress);
            // 
            // TxBx_Pass
            // 
            this.TxBx_Pass.Location = new System.Drawing.Point(150, 89);
            this.TxBx_Pass.Name = "TxBx_Pass";
            this.TxBx_Pass.PasswordChar = '♠';
            this.TxBx_Pass.Size = new System.Drawing.Size(171, 23);
            this.TxBx_Pass.TabIndex = 1;
            this.TxBx_Pass.Tag = "";
            this.TxBx_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBx_Pass_KeyPress);
            // 
            // TxBx_Lvl
            // 
            this.TxBx_Lvl.Location = new System.Drawing.Point(150, 128);
            this.TxBx_Lvl.Name = "TxBx_Lvl";
            this.TxBx_Lvl.Size = new System.Drawing.Size(120, 23);
            this.TxBx_Lvl.TabIndex = 2;
            // 
            // TxBx_Acces
            // 
            this.TxBx_Acces.Location = new System.Drawing.Point(150, 167);
            this.TxBx_Acces.Name = "TxBx_Acces";
            this.TxBx_Acces.Size = new System.Drawing.Size(171, 23);
            this.TxBx_Acces.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nivel:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ultimo acceso:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_Ingreso
            // 
            this.BT_Ingreso.BackgroundImage = global::Escolar2021.Properties.Resources.log_in;
            this.BT_Ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Ingreso.Location = new System.Drawing.Point(96, 205);
            this.BT_Ingreso.Name = "BT_Ingreso";
            this.BT_Ingreso.Size = new System.Drawing.Size(73, 72);
            this.BT_Ingreso.TabIndex = 8;
            this.BT_Ingreso.UseVisualStyleBackColor = true;
            this.BT_Ingreso.Click += new System.EventHandler(this.BT_Ingreso_Click);
            // 
            // BT_Exit
            // 
            this.BT_Exit.BackgroundImage = global::Escolar2021.Properties.Resources.close_button;
            this.BT_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Exit.Location = new System.Drawing.Point(212, 205);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(75, 72);
            this.BT_Exit.TabIndex = 9;
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // FT_User
            // 
            this.FT_User.Image = global::Escolar2021.Properties.Resources.profile_user;
            this.FT_User.Location = new System.Drawing.Point(377, 30);
            this.FT_User.Name = "FT_User";
            this.FT_User.Size = new System.Drawing.Size(232, 242);
            this.FT_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FT_User.TabIndex = 10;
            this.FT_User.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 299);
            this.Controls.Add(this.FT_User);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Ingreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBx_Acces);
            this.Controls.Add(this.TxBx_Lvl);
            this.Controls.Add(this.TxBx_Pass);
            this.Controls.Add(this.TxBx_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.Text = "Escolar2021  Login";
            ((System.ComponentModel.ISupportInitialize)(this.FT_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBx_User;
        private System.Windows.Forms.TextBox TxBx_Pass;
        private System.Windows.Forms.TextBox TxBx_Lvl;
        private System.Windows.Forms.TextBox TxBx_Acces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_Ingreso;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.PictureBox FT_User;
    }
}