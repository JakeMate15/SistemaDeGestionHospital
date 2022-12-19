namespace GestionHospital
{
    partial class Admin
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
            this.bienvenidaAdmin = new System.Windows.Forms.Label();
            this.nombreAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bienvenidaAdmin
            // 
            this.bienvenidaAdmin.AutoSize = true;
            this.bienvenidaAdmin.Location = new System.Drawing.Point(12, 9);
            this.bienvenidaAdmin.Name = "bienvenidaAdmin";
            this.bienvenidaAdmin.Size = new System.Drawing.Size(60, 13);
            this.bienvenidaAdmin.TabIndex = 0;
            this.bienvenidaAdmin.Text = "Bienvenido";
            // 
            // nombreAdmin
            // 
            this.nombreAdmin.AutoSize = true;
            this.nombreAdmin.Location = new System.Drawing.Point(78, 9);
            this.nombreAdmin.Name = "nombreAdmin";
            this.nombreAdmin.Size = new System.Drawing.Size(10, 13);
            this.nombreAdmin.TabIndex = 1;
            this.nombreAdmin.Text = " ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombreAdmin);
            this.Controls.Add(this.bienvenidaAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenidaAdmin;
        private System.Windows.Forms.Label nombreAdmin;
    }
}