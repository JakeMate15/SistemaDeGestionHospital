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
            this.listaMed = new System.Windows.Forms.DataGridView();
            this.listaTrat = new System.Windows.Forms.DataGridView();
            this.listaEst = new System.Windows.Forms.DataGridView();
            this.trata = new System.Windows.Forms.Button();
            this.medicamentos = new System.Windows.Forms.Button();
            this.estudios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idPaciente = new System.Windows.Forms.TextBox();
            this.infoPacientes = new System.Windows.Forms.Button();
            this.datosPaciente = new System.Windows.Forms.DataGridView();
            this.cerrarS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPaciente)).BeginInit();
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
            // listaMed
            // 
            this.listaMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMed.Location = new System.Drawing.Point(278, 284);
            this.listaMed.Name = "listaMed";
            this.listaMed.Size = new System.Drawing.Size(240, 150);
            this.listaMed.TabIndex = 21;
            // 
            // listaTrat
            // 
            this.listaTrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaTrat.Location = new System.Drawing.Point(545, 284);
            this.listaTrat.Name = "listaTrat";
            this.listaTrat.Size = new System.Drawing.Size(240, 150);
            this.listaTrat.TabIndex = 20;
            // 
            // listaEst
            // 
            this.listaEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEst.Location = new System.Drawing.Point(12, 284);
            this.listaEst.Name = "listaEst";
            this.listaEst.Size = new System.Drawing.Size(240, 150);
            this.listaEst.TabIndex = 19;
            // 
            // trata
            // 
            this.trata.Location = new System.Drawing.Point(621, 242);
            this.trata.Name = "trata";
            this.trata.Size = new System.Drawing.Size(75, 36);
            this.trata.TabIndex = 18;
            this.trata.Text = "Ver tratamientos";
            this.trata.UseVisualStyleBackColor = true;
            this.trata.Click += new System.EventHandler(this.trata_Click);
            // 
            // medicamentos
            // 
            this.medicamentos.Location = new System.Drawing.Point(353, 242);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Size = new System.Drawing.Size(89, 37);
            this.medicamentos.TabIndex = 17;
            this.medicamentos.Text = "Ver medicamentos";
            this.medicamentos.UseVisualStyleBackColor = true;
            this.medicamentos.Click += new System.EventHandler(this.medicamentos_Click);
            // 
            // estudios
            // 
            this.estudios.Location = new System.Drawing.Point(91, 242);
            this.estudios.Name = "estudios";
            this.estudios.Size = new System.Drawing.Size(75, 36);
            this.estudios.TabIndex = 16;
            this.estudios.Text = "Ver estudios";
            this.estudios.UseVisualStyleBackColor = true;
            this.estudios.Click += new System.EventHandler(this.estudios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Cita";
            // 
            // idPaciente
            // 
            this.idPaciente.Location = new System.Drawing.Point(78, 201);
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.Size = new System.Drawing.Size(61, 20);
            this.idPaciente.TabIndex = 14;
            // 
            // infoPacientes
            // 
            this.infoPacientes.Location = new System.Drawing.Point(12, 41);
            this.infoPacientes.Name = "infoPacientes";
            this.infoPacientes.Size = new System.Drawing.Size(127, 28);
            this.infoPacientes.TabIndex = 13;
            this.infoPacientes.Text = "Consultar Pacientes";
            this.infoPacientes.UseVisualStyleBackColor = true;
            this.infoPacientes.Click += new System.EventHandler(this.infoPacientes_Click);
            // 
            // datosPaciente
            // 
            this.datosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosPaciente.Location = new System.Drawing.Point(12, 75);
            this.datosPaciente.Name = "datosPaciente";
            this.datosPaciente.Size = new System.Drawing.Size(773, 111);
            this.datosPaciente.TabIndex = 12;
            // 
            // cerrarS
            // 
            this.cerrarS.Location = new System.Drawing.Point(710, 12);
            this.cerrarS.Name = "cerrarS";
            this.cerrarS.Size = new System.Drawing.Size(75, 37);
            this.cerrarS.TabIndex = 22;
            this.cerrarS.Text = "Cerrar Sesión";
            this.cerrarS.UseVisualStyleBackColor = true;
            this.cerrarS.Click += new System.EventHandler(this.cerrarS_Click);
            // 
            // Enfermera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cerrarS);
            this.Controls.Add(this.listaMed);
            this.Controls.Add(this.listaTrat);
            this.Controls.Add(this.listaEst);
            this.Controls.Add(this.trata);
            this.Controls.Add(this.medicamentos);
            this.Controls.Add(this.estudios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPaciente);
            this.Controls.Add(this.infoPacientes);
            this.Controls.Add(this.datosPaciente);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.msgBienvenido);
            this.Name = "Enfermera";
            this.Text = "Enfermera";
            ((System.ComponentModel.ISupportInitialize)(this.listaMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgBienvenido;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView listaMed;
        private System.Windows.Forms.DataGridView listaTrat;
        private System.Windows.Forms.DataGridView listaEst;
        private System.Windows.Forms.Button trata;
        private System.Windows.Forms.Button medicamentos;
        private System.Windows.Forms.Button estudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idPaciente;
        private System.Windows.Forms.Button infoPacientes;
        private System.Windows.Forms.DataGridView datosPaciente;
        private System.Windows.Forms.Button cerrarS;
    }
}