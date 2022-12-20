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
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-I0DIDO3\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public Dr(string nombre,string paterno)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.paterno = paterno;
            nomDr.Text = nombre + " " + paterno;
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
                SqlCommand comando = new SqlCommand("select Nombre + ' ' + paterno + ' ' + ISNULL(materno,'') as Nombre, idCita,fechaInicio,fechaSalida\r\nfrom Persona as per\r\n\tinner join\r\n\tPaciente as pac\r\n\ton per.idPersona = pac.idPersona\r\n\tINNER JOIN\r\n\t(SELECT idPaciente,idCita,fechaInicio,fechaSalida\r\n\t\t\t\t\tFROM Empleado AS e\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   TipoTrabajador as t\r\n\t\t\t\t\t   ON e.idTipoTrabajador = t.idTipoTrabajador\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   Persona AS p\r\n\t\t\t\t\t   ON e.idPersona = p.idPersona\r\n\t\t\t\t\t   INNER JOIN\r\n\t\t\t\t\t   Cita as c\r\n\t\t\t\t\t   ON c.idEmpleado = e.idEmpleado \r\n\t\t\t\t\twhere t.tipoTrabajador = 'Médico' and Nombre=@nombre and Paterno=@paterno) as con\r\n\tON con.idPaciente = pac.idPaciente\r\n   where fechaSalida >= getdate()", conexion);
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
    }
}
