namespace GestionHospital
{
    partial class Dr
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
            this.mensaje = new System.Windows.Forms.Label();
            this.nomDr = new System.Windows.Forms.Label();
            this.cerrarS = new System.Windows.Forms.Button();
            this.consultaCitas = new System.Windows.Forms.Button();
            this.listaCitas = new System.Windows.Forms.DataGridView();
            this.agregaCitas = new System.Windows.Forms.Button();
            this.quitaCita = new System.Windows.Forms.Button();
            this.modCita = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idPaciente = new System.Windows.Forms.TextBox();
            this.historial = new System.Windows.Forms.Button();
            this.consultaHistorial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idHistorial = new System.Windows.Forms.TextBox();
            this.recetar = new System.Windows.Forms.Button();
            this.historialData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Location = new System.Drawing.Point(78, 9);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 13);
            this.mensaje.TabIndex = 1;
            // 
            // nomDr
            // 
            this.nomDr.AutoSize = true;
            this.nomDr.Location = new System.Drawing.Point(84, 18);
            this.nomDr.Name = "nomDr";
            this.nomDr.Size = new System.Drawing.Size(10, 13);
            this.nomDr.TabIndex = 2;
            this.nomDr.Text = " ";
            // 
            // cerrarS
            // 
            this.cerrarS.Location = new System.Drawing.Point(713, 12);
            this.cerrarS.Name = "cerrarS";
            this.cerrarS.Size = new System.Drawing.Size(75, 37);
            this.cerrarS.TabIndex = 23;
            this.cerrarS.Text = "Cerrar Sesión";
            this.cerrarS.UseVisualStyleBackColor = true;
            this.cerrarS.Click += new System.EventHandler(this.cerrarS_Click);
            // 
            // consultaCitas
            // 
            this.consultaCitas.Location = new System.Drawing.Point(12, 60);
            this.consultaCitas.Name = "consultaCitas";
            this.consultaCitas.Size = new System.Drawing.Size(130, 28);
            this.consultaCitas.TabIndex = 25;
            this.consultaCitas.Text = "Consultar Citas";
            this.consultaCitas.UseVisualStyleBackColor = true;
            // 
            // listaCitas
            // 
            this.listaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCitas.Location = new System.Drawing.Point(12, 94);
            this.listaCitas.Name = "listaCitas";
            this.listaCitas.Size = new System.Drawing.Size(776, 147);
            this.listaCitas.TabIndex = 24;
            // 
            // agregaCitas
            // 
            this.agregaCitas.Location = new System.Drawing.Point(148, 60);
            this.agregaCitas.Name = "agregaCitas";
            this.agregaCitas.Size = new System.Drawing.Size(130, 28);
            this.agregaCitas.TabIndex = 26;
            this.agregaCitas.Text = "Agregar Cita";
            this.agregaCitas.UseVisualStyleBackColor = true;
            // 
            // quitaCita
            // 
            this.quitaCita.Location = new System.Drawing.Point(284, 60);
            this.quitaCita.Name = "quitaCita";
            this.quitaCita.Size = new System.Drawing.Size(130, 28);
            this.quitaCita.TabIndex = 27;
            this.quitaCita.Text = "Elimina Cita";
            this.quitaCita.UseVisualStyleBackColor = true;
            // 
            // modCita
            // 
            this.modCita.Location = new System.Drawing.Point(420, 60);
            this.modCita.Name = "modCita";
            this.modCita.Size = new System.Drawing.Size(130, 28);
            this.modCita.TabIndex = 28;
            this.modCita.Text = "Modifica Cita";
            this.modCita.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID Paciente";
            // 
            // idPaciente
            // 
            this.idPaciente.Location = new System.Drawing.Point(78, 268);
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.Size = new System.Drawing.Size(61, 20);
            this.idPaciente.TabIndex = 29;
            // 
            // historial
            // 
            this.historial.Location = new System.Drawing.Point(148, 266);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(130, 23);
            this.historial.TabIndex = 31;
            this.historial.Text = "Genera Historial";
            this.historial.UseVisualStyleBackColor = true;
            // 
            // consultaHistorial
            // 
            this.consultaHistorial.Location = new System.Drawing.Point(522, 265);
            this.consultaHistorial.Name = "consultaHistorial";
            this.consultaHistorial.Size = new System.Drawing.Size(130, 23);
            this.consultaHistorial.TabIndex = 32;
            this.consultaHistorial.Text = "Consulta Historial";
            this.consultaHistorial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID Historial";
            // 
            // idHistorial
            // 
            this.idHistorial.Location = new System.Drawing.Point(450, 266);
            this.idHistorial.Name = "idHistorial";
            this.idHistorial.Size = new System.Drawing.Size(61, 20);
            this.idHistorial.TabIndex = 33;
            // 
            // recetar
            // 
            this.recetar.Location = new System.Drawing.Point(658, 266);
            this.recetar.Name = "recetar";
            this.recetar.Size = new System.Drawing.Size(130, 23);
            this.recetar.TabIndex = 35;
            this.recetar.Text = "Receta";
            this.recetar.UseVisualStyleBackColor = true;
            // 
            // historialData
            // 
            this.historialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialData.Location = new System.Drawing.Point(15, 295);
            this.historialData.Name = "historialData";
            this.historialData.Size = new System.Drawing.Size(776, 143);
            this.historialData.TabIndex = 36;
            // 
            // Dr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historialData);
            this.Controls.Add(this.recetar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idHistorial);
            this.Controls.Add(this.consultaHistorial);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idPaciente);
            this.Controls.Add(this.modCita);
            this.Controls.Add(this.quitaCita);
            this.Controls.Add(this.agregaCitas);
            this.Controls.Add(this.consultaCitas);
            this.Controls.Add(this.listaCitas);
            this.Controls.Add(this.cerrarS);
            this.Controls.Add(this.nomDr);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.label1);
            this.Name = "Dr";
            this.Text = "Dr";
            this.Load += new System.EventHandler(this.Dr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Label nomDr;
        private System.Windows.Forms.Button cerrarS;
        private System.Windows.Forms.Button consultaCitas;
        private System.Windows.Forms.DataGridView listaCitas;
        private System.Windows.Forms.Button agregaCitas;
        private System.Windows.Forms.Button quitaCita;
        private System.Windows.Forms.Button modCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idPaciente;
        private System.Windows.Forms.Button historial;
        private System.Windows.Forms.Button consultaHistorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idHistorial;
        private System.Windows.Forms.Button recetar;
        private System.Windows.Forms.DataGridView historialData;
    }
}