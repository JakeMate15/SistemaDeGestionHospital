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
    public partial class CreaUsuario : Form
    {
        SqlConnection conexion;

        public CreaUsuario(string cadCon)
        {
            InitializeComponent();
            conexion = new SqlConnection(cadCon);
        }

        private void generaUser()
        {
            string id;
            string user = usario.Text;
            string pass = contrasena.Text;

            
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT TOP 1 * FROM  Empleado ORDER BY idEmpleado desc", conexion);
                

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);
                id = dt.Rows[0][0].ToString();

                SqlCommand c1 = new SqlCommand("select * from Usuario where idUsuario = '" + id + "'", conexion);
                SqlDataAdapter consulta1 = new SqlDataAdapter(c1);
                DataTable dt1 = new DataTable();
                consulta1.Fill(dt1);

                if(dt1.Rows.Count == 0)
                {
                    SqlCommand c2 = new SqlCommand("INSERT Usuario (idUsuario,IdEmpleado,Contraseña) VALUES  (N'"+user+"',"+id+",N'"+pass+"')", conexion);
                    c2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Usuario no disponible");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void creaUs_Click(object sender, EventArgs e)
        {
            generaUser();
            this.Close();
        }
    }
}
