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

namespace GestionHospital
{
    public partial class Admin : Form
    {
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        private string cadCon;
        SqlConnection conexion;
        private string nombre;
        private string paterno;

        public Admin(string nombre, string paterno, string cadCon)
        {
            InitializeComponent();
            this.cadCon = cadCon;
            conexion = new SqlConnection(cadCon);
            this.nombre = nombre;
            this.paterno = paterno;
            nombreAdmin.Text = nombre + " " + paterno;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void idCitaTxtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrarS_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void mPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select Persona.idPersona,idPaciente,Nombre + ' ' + paterno + ' ' + ISNULL(materno,'') as Nombre,Telefono,Mail,fechaNac, Calle+' '+Numero+', col '+Colonia+' '+CP as Dirección\r\nfrom (Paciente join Persona on Paciente.idPersona = Persona.idPersona) join Direccion on Persona.idDireccion = Direccion.idDireccion", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void muestraDr_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select Persona.idPersona,idEmpleado,Nombre + ' ' + paterno + ' ' + ISNULL(materno,'') as Nombre,Telefono,Mail,Dia as Jornada\r\nfrom \r\n\t(Persona join Empleado on Empleado.idPersona = Persona.idPersona)\r\n\tjoin DiaJornada \r\n\ton Empleado.idJornada = DiaJornada.idDia\r\nwhere idTipoTrabajador = 1", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void muestraEnf_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select Persona.idPersona,idEmpleado,Nombre + ' ' + paterno + ' ' + ISNULL(materno,'') as Nombre,Telefono,Mail,Dia as Jornada\r\nfrom \r\n\t(Persona join Empleado on Empleado.idPersona = Persona.idPersona)\r\n\tjoin DiaJornada \r\n\ton Empleado.idJornada = DiaJornada.idDia\r\nwhere idTipoTrabajador = 2", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

        }

        private void altaPac_Click(object sender, EventArgs e)
        {
            new AltaPac().Show();

        }

        private void altaEmp_Click(object sender, EventArgs e)
        {
            new AltaEmp().Show();
        }

        private void verPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idPersona,Nombre + ' ' + paterno + ' ' + ISNULL(materno,'')as Nombre,Telefono,Mail,fechaNac from Persona", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string nombre, paterno;

            nombre = nombreTxt.Text;
            paterno = paternoTxt.Text;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idPersona,Nombre + ' ' + paterno + ' ' + ISNULL(materno,'')as Nombre,Telefono,Mail,fechaNac from Persona where nombre = '"+ nombre +"' and Paterno = '"+paterno+"'", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            string id = idPersonatxt.Text;
            if (id == "")
            {
                id = "-1";
            }

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("delete from Persona where idPersona="+ id , conexion);

                
                comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void modDatos_Click(object sender, EventArgs e)
        {
            new modDatos(idPersonatxt.Text, cadCon).Show();
        }

        private void consultaCitas_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select fechaInicio as Fecha from \r\n(Cita join Empleado on Cita.idEmpleado = Empleado.idEmpleado)\r\nwhere Empleado.idEmpleado = @id", conexion);
                comando.Parameters.AddWithValue("id", idDrCita.Text);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                listaCitas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void agregaCitas_Click(object sender, EventArgs e)
        {
            new AgendaCitaAdmin(idDrCita.Text, idPacienteCita.Text,cadCon).Show();
        }
    }
}
