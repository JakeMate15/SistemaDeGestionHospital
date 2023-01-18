using GestionHospital.Modelo;
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
    public partial class CitaDesdeDr : Form
    {
        SqlConnection conexion;
        public CitaDesdeDr(string cadCon)
        {
            InitializeComponent();
            conexion = new SqlConnection(cadCon);

            try
            {
                conexion.Open();
                string query = "select * from Lugar where Disponibilidad =1";
                SqlCommand cmd = new SqlCommand(query, conexion);


                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    lugares.Items.Add(drd["TipoLugar"].ToString());
                }

                lugares.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void CitaDesdeDr_Load(object sender, EventArgs e)
        {

        }

        private void cita()
        {
            string nombre, paterno, idEmp, idLugar, fechaI, fechaS,idPaciente;

            nombre = nombreTxt.Text;
            paterno = paternoTxt.Text;
            idEmp = "-1";
            idPaciente = idPacienteTxt.Text;

            try
            {
                conexion.Open();


                SqlCommand comando = new SqlCommand("select idEmpleado, Nombre, Paterno from \r\nPersona join Empleado\r\non Persona.idPersona = Empleado.idPersona\r\nwhere Nombre = @nombre and Paterno = @paterno", conexion);
                comando.Parameters.AddWithValue("nombre", nombre);
                comando.Parameters.AddWithValue("paterno", paterno);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idEmp = dt.Rows[0][0].ToString();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }

            //jafdjlakj
            idLugar = "-1";

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idLugar from Lugar where TipoLugar = '" + lugares.Text + "'", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idLugar = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en selecciona idDireccion");
            }
            finally { conexion.Close(); }

            fechaI = fecha.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";
            fechaS = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";


            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idLugar from Lugar where TipoLugar = '" + lugares.Text + "'", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idLugar = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en selecciona idDireccion");
            }
            finally { conexion.Close(); }


            try
            {
                //Console.WriteLine("INSERT Cita(idEmpleado,idPaciente,idLugar,fechaInicio,fechaSalida) values (" + idDr + "," + idPaciente + "," + idLugar + ",CAST(N'" + fechaInicio + "' AS datetime),CAST(N'" + fechaFin + "' AS datetime))");
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT Cita(idEmpleado,idPaciente,idLugar,fechaInicio,fechaSalida) values (" + idEmp + "," + idPaciente + "," + idLugar + ",CAST(N'" + fechaI + "' AS datetime),CAST(N'" + fechaS + "' AS datetime))", conexion);

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cita();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
