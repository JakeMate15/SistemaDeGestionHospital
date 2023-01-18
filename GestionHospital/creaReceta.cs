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
    public partial class creaReceta : Form
    {
        SqlConnection conexion;
        string idCita;


        public creaReceta(string cadCon,string idCita)
        {
            InitializeComponent();
            conexion = new SqlConnection(cadCon);
            this.idCita= idCita;

            try
            {
                conexion.Open();
                string query = "select Nombre from Medicamento";
                SqlCommand cmd = new SqlCommand(query, conexion);


                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    medicamentos.Items.Add(drd["Nombre"].ToString());
                }

                medicamentos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            try
            {
                conexion.Open();
                string query = "select Nombre from Tratamiento";
                SqlCommand cmd = new SqlCommand(query, conexion);


                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    tratamientos.Items.Add(drd["Nombre"].ToString());
                }

                tratamientos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            try
            {
                conexion.Open();
                string query = "select Nombre from Estudios";
                SqlCommand cmd = new SqlCommand(query, conexion);


                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    estudios.Items.Add(drd["Nombre"].ToString());
                }

                estudios.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void addMed_Click(object sender, EventArgs e)
        {
            string idHistorial = "-1";
            string idMed = "-1";

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idHistorial from Cita join Historial on Cita.idCita = Historial.idCita where cita.idCita=" + idCita, conexion);
                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idHistorial = dt.Rows[0][0].ToString();
                
                SqlCommand comando2 = new SqlCommand("select idMedicamento from Medicamento where Nombre='" + medicamentos.Text+"'", conexion);
                SqlDataAdapter consulta2 = new SqlDataAdapter(comando2);
                DataTable dt2 = new DataTable();
                consulta2.Fill(dt2);

                idMed = dt2.Rows[0][0].ToString();

                SqlCommand comando3 = new SqlCommand("insert HistorialMedicamento(idHistorial,idMedicamento)\tvalues\t("+idHistorial+","+idMed+")", conexion);
                comando3.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void addTrat_Click(object sender, EventArgs e)
        {
            string idHistorial = "-1";
            string idTrat = "-1";

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idHistorial from Cita join Historial on Cita.idCita = Historial.idCita where cita.idCita=" + idCita, conexion);
                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idHistorial = dt.Rows[0][0].ToString();

                SqlCommand comando2 = new SqlCommand("select idTratamiento from Tratamiento where Nombre='" + tratamientos.Text + "'", conexion);
                //Console.WriteLine("select idTratamiento from Tratamiento where Nombre='" + tratamientos.Text + "'");
                SqlDataAdapter consulta2 = new SqlDataAdapter(comando2);
                DataTable dt2 = new DataTable();
                consulta2.Fill(dt2);

                idTrat = dt2.Rows[0][0].ToString();
                
                SqlCommand comando3 = new SqlCommand("insert HistorialTratamiento(idHistorial,idTratamiento)\tvalues\t(" + idHistorial + "," + idTrat + ")", conexion);
                comando3.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void addEstudio_Click(object sender, EventArgs e)
        {
            string idHistorial = "-1";
            string idEst = "-1";

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idHistorial from Cita join Historial on Cita.idCita = Historial.idCita where cita.idCita=" + idCita, conexion);
                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idHistorial = dt.Rows[0][0].ToString();

                SqlCommand comando2 = new SqlCommand("select idEstudio from Estudios where Nombre='" + estudios.Text + "'", conexion);
                SqlDataAdapter consulta2 = new SqlDataAdapter(comando2);
                DataTable dt2 = new DataTable();
                consulta2.Fill(dt2);

                idEst = dt2.Rows[0][0].ToString();

                SqlCommand comando3 = new SqlCommand("insert HistorialEstudios(idHistorial,idEstudio)\tvalues\t(" + idHistorial + "," + idEst + ")", conexion);
                comando3.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }
    }
}
