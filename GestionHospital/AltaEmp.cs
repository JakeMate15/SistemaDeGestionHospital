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
    public partial class AltaEmp : Form
    {
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        private string cadCon;
        SqlConnection conexion;


        public AltaEmp(string cadCon)
        {
            InitializeComponent();
            this.cadCon = cadCon;
            conexion = new SqlConnection(cadCon);
            salarioTxt.Text = "10000.1";

            try
            {
                conexion.Open();
                string query = "select idEspecialidad, Especialidad from Especialidad";
                SqlCommand cmd = new SqlCommand(query,conexion);
                
                
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    optEsp.Items.Add(drd["Especialidad"].ToString());
                }

                optEsp.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            try
            {
                conexion.Open();
                string query = "select * from TipoTrabajador";
                SqlCommand cmd = new SqlCommand(query, conexion);


                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    optTipoT.Items.Add(drd["TipoTrabajador"].ToString());
                }

                optTipoT.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            optJor.Items.Add("Entre semana mañana");
            optJor.Items.Add("Entre semana día");
            optJor.Items.Add("Entre semana noche");
            optJor.Items.Add("Fin de semana mañana");
            optJor.Items.Add("Fin de semana día");
            optJor.Items.Add("Fin de semana noche");
            optJor.SelectedIndex= 0;

            sexoOpt.Items.Add("Masculino");
            sexoOpt.Items.Add("Femenino");
            sexoOpt.SelectedIndex = 0;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPac_Click(object sender, EventArgs e)
        {
            insertaDir();
            insertaPersona();
            insertaEmpleado();
            this.Close();
            new CreaUsuario(cadCon).Show();
        }

        private void insertaDir()
        {
            string calle, numero, colonia, cp;

            calle = calleTxt.Text;
            numero = numTxt.Text;
            colonia = colTxt.Text;
            cp = cpTxt.Text;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT Direccion(Calle, Numero, Colonia, CP) VALUES(N'" + calle + "', N'" + numero + "', N'" + colonia + "', N'" + cp + "')", conexion);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void insertaPersona()
        {
            string nombre, paterno, materno, idDireccion, telefono, mail, fechaNac, sexo;

            nombre = nombreTxt.Text;
            paterno = paternoTxt.Text;
            materno = maternoTxt.Text;
            telefono = telTxt.Text;
            mail = mailTxt.Text;
            fechaNac = fechaNacI.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";
            if (sexoOpt.Text == "Masculino")
            {
                sexo = "0";
            }
            else { sexo = "1"; }
            idDireccion = "";


            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT TOP 1 * FROM  Direccion ORDER BY idDireccion desc", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idDireccion = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en selecciona idDireccion");
            }
            finally { conexion.Close(); }

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT Persona (Nombre,Paterno,Materno,idDireccion,Telefono,Mail,fechaNac,Sexo) \r\n\tVALUES   (N'" + nombre + "',N'" + paterno + "',N'" + materno + "'," + idDireccion + "," + telefono + ",N'" + mail + "',CAST(N'" + fechaNac + "' AS datetime)," + sexo + ")", conexion);
                //Console.WriteLine("INSERT Persona (Nombre,Paterno,Materno,idDireccion,Telefono,Mail,fechaNac,Sexo) \r\n\tVALUES   (N'" + nombre + "',N'" + paterno + "',N'" + materno + "'," + idDireccion + "," + telefono + ",N'" + mail + "',CAST(N'" + fechaNac + "' AS datetime)," + sexo + ")");
                
                comando.ExecuteNonQuery();

                //SqlDataAdapter consulta = new SqlDataAdapter(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en inserta persona");
            }
            finally { conexion.Close(); }
        }

        private void insertaEmpleado()
        {
            string idPersona, idTipoTrabajador, idEspecialidad,idJornada,salario;

            idPersona = "";
            idTipoTrabajador = "";
            idEspecialidad = "";
            idJornada = "";
            salario = salarioTxt.Text;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT TOP 1 * FROM  Persona ORDER BY idPersona desc", conexion);
                SqlCommand c1 = new SqlCommand("select idTipoTrabajador from TipoTrabajador where tipoTrabajador='"+optTipoT.Text+"'", conexion);
                SqlCommand c2 = new SqlCommand("select idEspecialidad from Especialidad where Especialidad='"+optEsp.Text+"'", conexion);
                SqlCommand c3 = new SqlCommand("select idDia from DiaJornada where Dia='"+ optJor.Text +"'", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                SqlDataAdapter consulta1 = new SqlDataAdapter(c1);
                DataTable dt1 = new DataTable();
                consulta1.Fill(dt1);

                SqlDataAdapter consulta2 = new SqlDataAdapter(c2);
                DataTable dt2 = new DataTable();
                consulta2.Fill(dt2);

                SqlDataAdapter consulta3 = new SqlDataAdapter(c3);
                DataTable dt3 = new DataTable();
                consulta3.Fill(dt3);

                idPersona = dt.Rows[0][0].ToString();
                idTipoTrabajador = dt1.Rows[0][0].ToString();
                idEspecialidad = dt2.Rows[0][0].ToString();
                idJornada = dt3.Rows[0][0].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT Empleado (idPersona,idTipoTrabajador,idEspecialidad,idJornada,Salario) VALUES   ("+idPersona+","+idTipoTrabajador+","+idEspecialidad+","+idJornada+","+salario+")", conexion);
                Console.WriteLine("INSERT Empleado (idPersona,idTipoTrabajador,idEspecialidad,idJornada,Salario) VALUES   (" + idPersona + "," + idTipoTrabajador + "," + idEspecialidad + "," + idJornada + "," + salario + ")");
                comando.ExecuteNonQuery();

                //SqlDataAdapter consulta = new SqlDataAdapter(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en inserta emp");
            }
            finally { conexion.Close(); }
        }
    }
}
