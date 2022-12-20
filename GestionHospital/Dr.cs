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
    public partial class Dr : Form
    {
        private string nombre;
        private string paterno;
        string cadCon;
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        SqlConnection conexion;

        public Dr(string nombre,string paterno,string cadCon)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.paterno = paterno;
            nomDr.Text = nombre + " " + paterno;
            this.cadCon = cadCon;
            conexion = new SqlConnection(cadCon);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dr_Load(object sender, EventArgs e)
        {

        }

        private void cerrarS_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void consultaCitas_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select Nombre + ' ' + paterno + ' ' + ISNULL(materno,'') as Nombre, con.idPaciente, idCita,fechaInicio,fechaSalida\r\nfrom Persona as per\r\n\tinner join\r\n\tPaciente as pac\r\n\ton per.idPersona = pac.idPersona\r\n\tINNER JOIN\r\n\t(SELECT idPaciente,idCita,fechaInicio,fechaSalida\r\n\t\t\t\t\tFROM Empleado AS e\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   TipoTrabajador as t\r\n\t\t\t\t\t   ON e.idTipoTrabajador = t.idTipoTrabajador\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   Persona AS p\r\n\t\t\t\t\t   ON e.idPersona = p.idPersona\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   Cita as c\r\n\t\t\t\t\t   ON c.idEmpleado = e.idEmpleado \r\n\t\t\t\t\twhere t.tipoTrabajador = 'Médico' and Nombre=@nombre and Paterno=@paterno) as con\r\n\tON con.idPaciente = pac.idPaciente\r\n   where fechaSalida >= getdate()", conexion);
                comando.Parameters.AddWithValue("nombre", nombre);
                comando.Parameters.AddWithValue("paterno", paterno);

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

        private void idPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void generaHistoria()
        {
            string id = idCitaHisTxt.Text;
            string desc = descHist.Text;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert Historial(idCita,Descripcion)	values	("+id+",N'"+desc+"')", conexion);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void historial_Click(object sender, EventArgs e)
        {
            generaHistoria();
        }

        public void citaDr()
        {

        }

        private void agregaCitas_Click(object sender, EventArgs e)
        {
            /*
             select idEmpleado, Nombre, Paterno from 
            Persona join Empleado
            on Persona.idPersona = Empleado.idPersona
            where Nombre = 'Erik' and Paterno = 'Morales'
             */
        }
    }
}
