namespace GestionHospital
{
    partial class Enfermera
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
            this.msgBienvenido = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgBienvenido
            // 
            this.msgBienvenido.AutoSize = true;
            this.msgBienvenido.Location = new System.Drawing.Point(12, 9);
            this.msgBienvenido.Name = "msgBienvenido";
            this.msgBienvenido.Size = new System.Drawing.Size(60, 13);
            this.msgBienvenido.TabIndex = 0;
            this.msgBienvenido.Text = "Bienvenido";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(78, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(10, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = " ";
            // 
            // Enfermera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.msgBienvenido);
            this.Name = "Enfermera";
            this.Text = "Enfermera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgBienvenido;
        private System.Windows.Forms.Label lblMensaje;
    }
}