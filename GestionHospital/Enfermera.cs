using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHospital.Modelo;

namespace GestionHospital
{
    public partial class Enfermera : Form
    {
        string cadCon;
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        SqlConnection conexion;
        private string nombre;
        private string paterno;

        public Enfermera(string nombre,string paterno,string cadCon)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.paterno= paterno;
            lblMensaje.Text = nombre + " " + paterno;
            this.cadCon = cadCon;
            conexion = new SqlConnection(cadCon);
        }

        private void cerrarS_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void infoPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select Nombre + ' ' + paterno + ' ' + ISNULL(materno,'') as Nombre, idCita,fechaInicio,fechaSalida\r\nfrom Persona as per\r\n\tinner join\r\n\tPaciente as pac\r\n\ton per.idPersona = pac.idPersona\r\n\tINNER JOIN\r\n\t(SELECT idPaciente,idCita,fechaInicio,fechaSalida\r\n\t\t\t\t\tFROM Empleado AS e\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   TipoTrabajador as t\r\n\t\t\t\t\t   ON e.idTipoTrabajador = t.idTipoTrabajador\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   Persona AS p\r\n\t\t\t\t\t   ON e.idPersona = p.idPersona\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   Cita as c\r\n\t\t\t\t\t   ON c.idEmpleado = e.idEmpleado \r\n\t\t\t\t\twhere t.tipoTrabajador = 'Enfermera' and  Nombre=@nombre and Paterno=@paterno) as con\r\n\tON con.idPaciente = pac.idPaciente \r\nwhere fechaSalida >= getdate()", conexion);
                comando.Parameters.AddWithValue("nombre", nombre);
                comando.Parameters.AddWithValue("paterno", paterno);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                datosPaciente.DataSource= dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void medicamentos_Click(object sender, EventArgs e)
        {
            int cita = Int32.Parse(idPaciente.Text);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT Nombre as Medicamento\r\nfrom Historial as h\r\ninner join \r\nHistorialMedicamento as hm\r\non h.idHistorial = hm.idHistorial\r\ninner join\r\nMedicamento as m\r\non hm.idMedicamento = m.idMedicamento\r\nwhere h.idCita = @idCita",conexion);
                comando.Parameters.AddWithValue("idCita", cita);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                listaMed.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void estudios_Click(object sender, EventArgs e)
        {
            int cita = Int32.Parse(idPaciente.Text);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT Nombre as Estudio\r\nfrom Historial as h\r\ninner join \r\nHistorialEstudios as hm\r\non h.idHistorial = hm.idHistorial\r\ninner join\r\nEstudios as m\r\non hm.idEstudio = m.idEstudio\r\nwhere h.idCita = @idCita", conexion);
                comando.Parameters.AddWithValue("idCita", cita);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                listaEst.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void trata_Click(object sender, EventArgs e)
        {
            int cita = Int32.Parse(idPaciente.Text);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT Nombre as Tratamiento\r\nfrom Historial as h\r\ninner join \r\nHistorialTratamiento as hm\r\non h.idHistorial = hm.idHistorial\r\ninner join\r\nTratamiento as m\r\non hm.idTratamiento = m.idTratamiento\r\nwhere h.idCita = @idCita", conexion);
                comando.Parameters.AddWithValue("idCita", cita);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                listaTrat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }
    }
}
