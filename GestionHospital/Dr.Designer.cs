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
            this.idCitaHisTxt = new System.Windows.Forms.TextBox();
            this.historial = new System.Windows.Forms.Button();
            this.consultaHistorial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idHistorial = new System.Windows.Forms.TextBox();
            this.recetar = new System.Windows.Forms.Button();
            this.historialData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.idCitaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descHist = new System.Windows.Forms.TextBox();
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
            this.consultaCitas.Click += new System.EventHandler(this.consultaCitas_Click);
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
            this.agregaCitas.Click += new System.EventHandler(this.agregaCitas_Click);
            // 
            // quitaCita
            // 
            this.quitaCita.Location = new System.Drawing.Point(522, 60);
            this.quitaCita.Name = "quitaCita";
            this.quitaCita.Size = new System.Drawing.Size(130, 28);
            this.quitaCita.TabIndex = 27;
            this.quitaCita.Text = "Elimina Cita";
            this.quitaCita.UseVisualStyleBackColor = true;
            // 
            // modCita
            // 
            this.modCita.Location = new System.Drawing.Point(658, 60);
            this.modCita.Name = "modCita";
            this.modCita.Size = new System.Drawing.Size(130, 28);
            this.modCita.TabIndex = 28;
            this.modCita.Text = "Modifica Cita";
            this.modCita.UseVisualStyleBackColor = true;
            // 
            // idCitaHisTxt
            // 
            this.idCitaHisTxt.Location = new System.Drawing.Point(81, 254);
            this.idCitaHisTxt.Name = "idCitaHisTxt";
            this.idCitaHisTxt.Size = new System.Drawing.Size(61, 20);
            this.idCitaHisTxt.TabIndex = 29;
            this.idCitaHisTxt.TextChanged += new System.EventHandler(this.idPaciente_TextChanged);
            // 
            // historial
            // 
            this.historial.Location = new System.Drawing.Point(148, 313);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(130, 23);
            this.historial.TabIndex = 31;
            this.historial.Text = "Genera Historial";
            this.historial.UseVisualStyleBackColor = true;
            this.historial.Click += new System.EventHandler(this.historial_Click);
            // 
            // consultaHistorial
            // 
            this.consultaHistorial.Location = new System.Drawing.Point(658, 261);
            this.consultaHistorial.Name = "consultaHistorial";
            this.consultaHistorial.Size = new System.Drawing.Size(130, 23);
            this.consultaHistorial.TabIndex = 32;
            this.consultaHistorial.Text = "Consulta Historial";
            this.consultaHistorial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID Historial";
            // 
            // idHistorial
            // 
            this.idHistorial.Location = new System.Drawing.Point(591, 290);
            this.idHistorial.Name = "idHistorial";
            this.idHistorial.Size = new System.Drawing.Size(61, 20);
            this.idHistorial.TabIndex = 33;
            // 
            // recetar
            // 
            this.recetar.Location = new System.Drawing.Point(658, 290);
            this.recetar.Name = "recetar";
            this.recetar.Size = new System.Drawing.Size(130, 23);
            this.recetar.TabIndex = 35;
            this.recetar.Text = "Receta";
            this.recetar.UseVisualStyleBackColor = true;
            // 
            // historialData
            // 
            this.historialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialData.Location = new System.Drawing.Point(15, 342);
            this.historialData.Name = "historialData";
            this.historialData.Size = new System.Drawing.Size(776, 143);
            this.historialData.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID Cita";
            // 
            // idCitaTxt
            // 
            this.idCitaTxt.Location = new System.Drawing.Point(450, 63);
            this.idCitaTxt.Name = "idCitaTxt";
            this.idCitaTxt.Size = new System.Drawing.Size(61, 20);
            this.idCitaTxt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID Cita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Descripción";
            // 
            // descHist
            // 
            this.descHist.Location = new System.Drawing.Point(81, 287);
            this.descHist.Name = "descHist";
            this.descHist.Size = new System.Drawing.Size(344, 20);
            this.descHist.TabIndex = 40;
            // 
            // Dr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.descHist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idCitaTxt);
            this.Controls.Add(this.historialData);
            this.Controls.Add(this.recetar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idHistorial);
            this.Controls.Add(this.consultaHistorial);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCitaHisTxt);
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
        private System.Windows.Forms.TextBox idCitaHisTxt;
        private System.Windows.Forms.Button historial;
        private System.Windows.Forms.Button consultaHistorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idHistorial;
        private System.Windows.Forms.Button recetar;
        private System.Windows.Forms.DataGridView historialData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idCitaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descHist;
    }
}