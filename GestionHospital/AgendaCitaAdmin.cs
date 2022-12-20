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
    public partial class AgendaCitaAdmin : Form
    {
        string idPaciente, idDr;
        SqlConnection conexion;

        public AgendaCitaAdmin(string idD, string idP, string cadCon)
        {
            InitializeComponent();
            idPaciente= idP;
            idDr= idD;
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

        private void generaCita()
        {
            string fechaInicio = fecha.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";
            string fechaFin = fecha.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";
            string idLugar = "-1";

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idLugar from Lugar where TipoLugar = '"+lugares.Text+"'", conexion);

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

            Console.WriteLine(idDr);

            try
            {
                //Console.WriteLine("INSERT Cita(idEmpleado,idPaciente,idLugar,fechaInicio,fechaSalida) values (" + idDr + "," + idPaciente + "," + idLugar + ",CAST(N'" + fechaInicio + "' AS datetime),CAST(N'" + fechaFin + "' AS datetime))");
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT Cita(idEmpleado,idPaciente,idLugar,fechaInicio,fechaSalida) values ("+idDr+","+idPaciente+","+idLugar+",CAST(N'"+fechaInicio+"' AS datetime),CAST(N'"+fechaFin+"' AS datetime))", conexion);
                
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generaCita();
            this.Close();
        }
    }
}
