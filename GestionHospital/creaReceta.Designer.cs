namespace GestionHospital
{
    partial class creaReceta
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
            this.medicamentos = new System.Windows.Forms.ComboBox();
            this.tratamientos = new System.Windows.Forms.ComboBox();
            this.estudios = new System.Windows.Forms.ComboBox();
            this.addMed = new System.Windows.Forms.Button();
            this.addTrat = new System.Windows.Forms.Button();
            this.addEstudio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medicamentos
            // 
            this.medicamentos.FormattingEnabled = true;
            this.medicamentos.Location = new System.Drawing.Point(89, 6);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Size = new System.Drawing.Size(121, 21);
            this.medicamentos.TabIndex = 0;
            // 
            // tratamientos
            // 
            this.tratamientos.FormattingEnabled = true;
            this.tratamientos.Location = new System.Drawing.Point(89, 30);
            this.tratamientos.Name = "tratamientos";
            this.tratamientos.Size = new System.Drawing.Size(121, 21);
            this.tratamientos.TabIndex = 1;
            // 
            // estudios
            // 
            this.estudios.FormattingEnabled = true;
            this.estudios.Location = new System.Drawing.Point(89, 55);
            this.estudios.Name = "estudios";
            this.estudios.Size = new System.Drawing.Size(121, 21);
            this.estudios.TabIndex = 2;
            // 
            // addMed
            // 
            this.addMed.Location = new System.Drawing.Point(216, 4);
            this.addMed.Name = "addMed";
            this.addMed.Size = new System.Drawing.Size(75, 23);
            this.addMed.TabIndex = 3;
            this.addMed.Text = "Añadir";
            this.addMed.UseVisualStyleBackColor = true;
            this.addMed.Click += new System.EventHandler(this.addMed_Click);
            // 
            // addTrat
            // 
            this.addTrat.Location = new System.Drawing.Point(216, 29);
            this.addTrat.Name = "addTrat";
            this.addTrat.Size = new System.Drawing.Size(75, 23);
            this.addTrat.TabIndex = 4;
            this.addTrat.Text = "Añadir";
            this.addTrat.UseVisualStyleBackColor = true;
            this.addTrat.Click += new System.EventHandler(this.addTrat_Click);
            // 
            // addEstudio
            // 
            this.addEstudio.Location = new System.Drawing.Point(216, 55);
            this.addEstudio.Name = "addEstudio";
            this.addEstudio.Size = new System.Drawing.Size(75, 23);
            this.addEstudio.TabIndex = 5;
            this.addEstudio.Text = "Añadir";
            this.addEstudio.UseVisualStyleBackColor = true;
            this.addEstudio.Click += new System.EventHandler(this.addEstudio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tratamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estudio";
            // 
            // cerrar
            // 
            this.cerrar.AutoEllipsis = true;
            this.cerrar.Location = new System.Drawing.Point(116, 82);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 9;
            this.cerrar.Text = "Listo";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // creaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 117);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEstudio);
            this.Controls.Add(this.addTrat);
            this.Controls.Add(this.addMed);
            this.Controls.Add(this.estudios);
            this.Controls.Add(this.tratamientos);
            this.Controls.Add(this.medicamentos);
            this.Name = "creaReceta";
            this.Text = "creaReceta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox medicamentos;
        private System.Windows.Forms.ComboBox tratamientos;
        private System.Windows.Forms.ComboBox estudios;
        private System.Windows.Forms.Button addMed;
        private System.Windows.Forms.Button addTrat;
        private System.Windows.Forms.Button addEstudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cerrar;
    }
}