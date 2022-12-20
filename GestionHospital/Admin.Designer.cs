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
            this.components = new System.ComponentModel.Container();
            this.bienvenidaAdmin = new System.Windows.Forms.Label();
            this.nombreAdmin = new System.Windows.Forms.Label();
            this.cerrarS = new System.Windows.Forms.Button();
            this.mPacientes = new System.Windows.Forms.Button();
            this.muestraEnf = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.muestraDr = new System.Windows.Forms.Button();
            this.altaPac = new System.Windows.Forms.Button();
            this.altaEmp = new System.Windows.Forms.Button();
            this.modDatos = new System.Windows.Forms.Button();
            this.elimina = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.agregaCitas = new System.Windows.Forms.Button();
            this.consultaCitas = new System.Windows.Forms.Button();
            this.listaCitas = new System.Windows.Forms.DataGridView();
            this.idPacienteCita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idDrCitalabel = new System.Windows.Forms.Label();
            this.idDrCita = new System.Windows.Forms.TextBox();
            this.idCitaCosto = new System.Windows.Forms.Label();
            this.idCitaTxtCosto = new System.Windows.Forms.TextBox();
            this.costoLabel = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.paternoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idPersona = new System.Windows.Forms.Label();
            this.idPersonatxt = new System.Windows.Forms.TextBox();
            this.verPersonas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitas)).BeginInit();
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
            // cerrarS
            // 
            this.cerrarS.Location = new System.Drawing.Point(643, 9);
            this.cerrarS.Name = "cerrarS";
            this.cerrarS.Size = new System.Drawing.Size(75, 37);
            this.cerrarS.TabIndex = 23;
            this.cerrarS.Text = "Cerrar Sesión";
            this.cerrarS.UseVisualStyleBackColor = true;
            this.cerrarS.Click += new System.EventHandler(this.cerrarS_Click);
            // 
            // mPacientes
            // 
            this.mPacientes.Location = new System.Drawing.Point(12, 60);
            this.mPacientes.Name = "mPacientes";
            this.mPacientes.Size = new System.Drawing.Size(75, 35);
            this.mPacientes.TabIndex = 24;
            this.mPacientes.Text = "Muestra Pacientes";
            this.mPacientes.UseVisualStyleBackColor = true;
            this.mPacientes.Click += new System.EventHandler(this.mPacientes_Click);
            // 
            // muestraEnf
            // 
            this.muestraEnf.Location = new System.Drawing.Point(12, 101);
            this.muestraEnf.Name = "muestraEnf";
            this.muestraEnf.Size = new System.Drawing.Size(75, 35);
            this.muestraEnf.TabIndex = 25;
            this.muestraEnf.Text = "Muestra Enfermeras";
            this.muestraEnf.UseVisualStyleBackColor = true;
            this.muestraEnf.Click += new System.EventHandler(this.muestraEnf_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // muestraDr
            // 
            this.muestraDr.Location = new System.Drawing.Point(93, 60);
            this.muestraDr.Name = "muestraDr";
            this.muestraDr.Size = new System.Drawing.Size(75, 35);
            this.muestraDr.TabIndex = 27;
            this.muestraDr.Text = "Muestra Doctores";
            this.muestraDr.UseVisualStyleBackColor = true;
            this.muestraDr.Click += new System.EventHandler(this.muestraDr_Click);
            // 
            // altaPac
            // 
            this.altaPac.Location = new System.Drawing.Point(208, 60);
            this.altaPac.Name = "altaPac";
            this.altaPac.Size = new System.Drawing.Size(75, 35);
            this.altaPac.TabIndex = 28;
            this.altaPac.Text = "Alta Paciente";
            this.altaPac.UseVisualStyleBackColor = true;
            this.altaPac.Click += new System.EventHandler(this.altaPac_Click);
            // 
            // altaEmp
            // 
            this.altaEmp.Location = new System.Drawing.Point(208, 101);
            this.altaEmp.Name = "altaEmp";
            this.altaEmp.Size = new System.Drawing.Size(75, 35);
            this.altaEmp.TabIndex = 29;
            this.altaEmp.Text = "Alta Empleado";
            this.altaEmp.UseVisualStyleBackColor = true;
            this.altaEmp.Click += new System.EventHandler(this.altaEmp_Click);
            // 
            // modDatos
            // 
            this.modDatos.Location = new System.Drawing.Point(562, 86);
            this.modDatos.Name = "modDatos";
            this.modDatos.Size = new System.Drawing.Size(75, 35);
            this.modDatos.TabIndex = 30;
            this.modDatos.Text = "Modifica Datos";
            this.modDatos.UseVisualStyleBackColor = true;
            this.modDatos.Click += new System.EventHandler(this.modDatos_Click);
            // 
            // elimina
            // 
            this.elimina.Location = new System.Drawing.Point(643, 86);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(75, 35);
            this.elimina.TabIndex = 31;
            this.elimina.Text = "Elimina persona";
            this.elimina.UseVisualStyleBackColor = true;
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(391, 114);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 32;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // agregaCitas
            // 
            this.agregaCitas.Location = new System.Drawing.Point(208, 346);
            this.agregaCitas.Name = "agregaCitas";
            this.agregaCitas.Size = new System.Drawing.Size(130, 28);
            this.agregaCitas.TabIndex = 36;
            this.agregaCitas.Text = "Agregar Cita";
            this.agregaCitas.UseVisualStyleBackColor = true;
            this.agregaCitas.Click += new System.EventHandler(this.agregaCitas_Click);
            // 
            // consultaCitas
            // 
            this.consultaCitas.Location = new System.Drawing.Point(208, 312);
            this.consultaCitas.Name = "consultaCitas";
            this.consultaCitas.Size = new System.Drawing.Size(130, 28);
            this.consultaCitas.TabIndex = 35;
            this.consultaCitas.Text = "Consultar Citas Dr";
            this.consultaCitas.UseVisualStyleBackColor = true;
            this.consultaCitas.Click += new System.EventHandler(this.consultaCitas_Click);
            // 
            // listaCitas
            // 
            this.listaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCitas.Location = new System.Drawing.Point(12, 385);
            this.listaCitas.Name = "listaCitas";
            this.listaCitas.Size = new System.Drawing.Size(706, 147);
            this.listaCitas.TabIndex = 34;
            // 
            // idPacienteCita
            // 
            this.idPacienteCita.Location = new System.Drawing.Point(84, 348);
            this.idPacienteCita.Name = "idPacienteCita";
            this.idPacienteCita.Size = new System.Drawing.Size(100, 20);
            this.idPacienteCita.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID Paciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idDrCitalabel
            // 
            this.idDrCitalabel.AutoSize = true;
            this.idDrCitalabel.Location = new System.Drawing.Point(15, 320);
            this.idDrCitalabel.Name = "idDrCitalabel";
            this.idDrCitalabel.Size = new System.Drawing.Size(53, 13);
            this.idDrCitalabel.TabIndex = 42;
            this.idDrCitalabel.Text = "ID Doctor";
            // 
            // idDrCita
            // 
            this.idDrCita.Location = new System.Drawing.Point(84, 317);
            this.idDrCita.Name = "idDrCita";
            this.idDrCita.Size = new System.Drawing.Size(100, 20);
            this.idDrCita.TabIndex = 41;
            // 
            // idCitaCosto
            // 
            this.idCitaCosto.AutoSize = true;
            this.idCitaCosto.Location = new System.Drawing.Point(539, 312);
            this.idCitaCosto.Name = "idCitaCosto";
            this.idCitaCosto.Size = new System.Drawing.Size(39, 13);
            this.idCitaCosto.TabIndex = 44;
            this.idCitaCosto.Text = "ID Cita";
            // 
            // idCitaTxtCosto
            // 
            this.idCitaTxtCosto.Location = new System.Drawing.Point(623, 312);
            this.idCitaTxtCosto.Name = "idCitaTxtCosto";
            this.idCitaTxtCosto.Size = new System.Drawing.Size(31, 20);
            this.idCitaTxtCosto.TabIndex = 43;
            this.idCitaTxtCosto.TextChanged += new System.EventHandler(this.idCitaTxtCosto_TextChanged);
            // 
            // costoLabel
            // 
            this.costoLabel.AutoSize = true;
            this.costoLabel.Location = new System.Drawing.Point(620, 346);
            this.costoLabel.Name = "costoLabel";
            this.costoLabel.Size = new System.Drawing.Size(34, 13);
            this.costoLabel.TabIndex = 46;
            this.costoLabel.Text = "  0.00";
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(532, 340);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(67, 28);
            this.costo.TabIndex = 47;
            this.costo.Text = "Costo Cita";
            this.costo.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(382, 57);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreTxt.TabIndex = 49;
            // 
            // paternoTxt
            // 
            this.paternoTxt.Location = new System.Drawing.Point(382, 83);
            this.paternoTxt.Name = "paternoTxt";
            this.paternoTxt.Size = new System.Drawing.Size(100, 20);
            this.paternoTxt.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "A. Paterno:";
            // 
            // idPersona
            // 
            this.idPersona.AutoSize = true;
            this.idPersona.Location = new System.Drawing.Point(559, 60);
            this.idPersona.Name = "idPersona";
            this.idPersona.Size = new System.Drawing.Size(60, 13);
            this.idPersona.TabIndex = 53;
            this.idPersona.Text = "ID Persona";
            // 
            // idPersonatxt
            // 
            this.idPersonatxt.Location = new System.Drawing.Point(625, 57);
            this.idPersonatxt.Name = "idPersonatxt";
            this.idPersonatxt.Size = new System.Drawing.Size(93, 20);
            this.idPersonatxt.TabIndex = 54;
            // 
            // verPersonas
            // 
            this.verPersonas.Location = new System.Drawing.Point(93, 101);
            this.verPersonas.Name = "verPersonas";
            this.verPersonas.Size = new System.Drawing.Size(75, 35);
            this.verPersonas.TabIndex = 55;
            this.verPersonas.Text = "Ver Personas";
            this.verPersonas.UseVisualStyleBackColor = true;
            this.verPersonas.Click += new System.EventHandler(this.verPersonas_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 544);
            this.Controls.Add(this.verPersonas);
            this.Controls.Add(this.idPersonatxt);
            this.Controls.Add(this.idPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paternoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.costoLabel);
            this.Controls.Add(this.idCitaCosto);
            this.Controls.Add(this.idCitaTxtCosto);
            this.Controls.Add(this.idDrCitalabel);
            this.Controls.Add(this.idDrCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPacienteCita);
            this.Controls.Add(this.agregaCitas);
            this.Controls.Add(this.consultaCitas);
            this.Controls.Add(this.listaCitas);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.modDatos);
            this.Controls.Add(this.altaEmp);
            this.Controls.Add(this.altaPac);
            this.Controls.Add(this.muestraDr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.muestraEnf);
            this.Controls.Add(this.mPacientes);
            this.Controls.Add(this.cerrarS);
            this.Controls.Add(this.nombreAdmin);
            this.Controls.Add(this.bienvenidaAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenidaAdmin;
        private System.Windows.Forms.Label nombreAdmin;
        private System.Windows.Forms.Button cerrarS;
        private System.Windows.Forms.Button mPacientes;
        private System.Windows.Forms.Button muestraEnf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button muestraDr;
        private System.Windows.Forms.Button altaPac;
        private System.Windows.Forms.Button altaEmp;
        private System.Windows.Forms.Button modDatos;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button agregaCitas;
        private System.Windows.Forms.Button consultaCitas;
        private System.Windows.Forms.DataGridView listaCitas;
        private System.Windows.Forms.TextBox idPacienteCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idDrCitalabel;
        private System.Windows.Forms.TextBox idDrCita;
        private System.Windows.Forms.Label idCitaCosto;
        private System.Windows.Forms.TextBox idCitaTxtCosto;
        private System.Windows.Forms.Label costoLabel;
        private System.Windows.Forms.Button costo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox paternoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idPersona;
        private System.Windows.Forms.TextBox idPersonatxt;
        private System.Windows.Forms.Button verPersonas;
    }
}