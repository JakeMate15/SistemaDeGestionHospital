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
    public partial class CambiaFecha : Form
    {
        SqlConnection conexion;
        string idCita;

        public CambiaFecha(string canCon,string idCita)
        {
            InitializeComponent();
            conexion = new SqlConnection(canCon);
            this.idCita = idCita;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string fechaI, fechaS;

            fechaI = fecha.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";
            fechaS = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";

            try
            {
                //Console.WriteLine("INSERT Cita(idEmpleado,idPaciente,idLugar,fechaInicio,fechaSalida) values (" + idDr + "," + idPaciente + "," + idLugar + ",CAST(N'" + fechaInicio + "' AS datetime),CAST(N'" + fechaFin + "' AS datetime))");
                conexion.Open();
                SqlCommand comando = new SqlCommand("update cita\r\nset fechaInicio = CAST(N'" + fechaI + "' AS datetime), fechaSalida =CAST(N'" + fechaS + "' AS datetime)\r\nwhere idCita = " + idCita, conexion);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            this.Close();
        }
    }
}
