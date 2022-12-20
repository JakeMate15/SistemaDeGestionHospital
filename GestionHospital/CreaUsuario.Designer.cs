namespace GestionHospital
{
    partial class CreaUsuario
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
            this.creaUs = new System.Windows.Forms.Button();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.usario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creaUs
            // 
            this.creaUs.Location = new System.Drawing.Point(161, 9);
            this.creaUs.Name = "creaUs";
            this.creaUs.Size = new System.Drawing.Size(75, 38);
            this.creaUs.TabIndex = 0;
            this.creaUs.Text = "Crear Usuario";
            this.creaUs.UseVisualStyleBackColor = true;
            this.creaUs.Click += new System.EventHandler(this.creaUs_Click);
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(55, 32);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(100, 20);
            this.contrasena.TabIndex = 1;
            // 
            // usario
            // 
            this.usario.Location = new System.Drawing.Point(55, 6);
            this.usario.Name = "usario";
            this.usario.Size = new System.Drawing.Size(100, 20);
            this.usario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave";
            // 
            // CreaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 69);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usario);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.creaUs);
            this.Name = "CreaUsuario";
            this.Text = "CreaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creaUs;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.TextBox usario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}