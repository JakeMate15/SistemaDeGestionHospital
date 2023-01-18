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
    public partial class AltaPac : Form
    {
        private string cadCon;
        SqlConnection conexion;
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-I0DIDO3\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public AltaPac(string cadCon)
        {
            InitializeComponent();
            this.cadCon = cadCon;
            conexion = new SqlConnection(cadCon);
            sexoOpt.Items.Add("Masculino");
            sexoOpt.Items.Add("Femenino");
            sexoOpt.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnPac_Click(object sender, EventArgs e)
        {
            insertaDir();
            insertaPersona();
            insertaPacinete();
            this.Close();
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
                SqlCommand comando = new SqlCommand("INSERT Direccion(Calle, Numero, Colonia, CP) VALUES(N'" + calle + "', N'" + numero + "', N'" + colonia + "', N'" + cp + "')", conexion) ;
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
            materno= maternoTxt.Text;
            telefono = telTxt.Text;
            mail = mailTxt.Text;
            fechaNac = fechaNacI.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00.000";
            if(sexoOpt.Text == "Masculino")
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
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT Persona (Nombre,Paterno,Materno,idDireccion,Telefono,Mail,fechaNac,Sexo) \r\n\tVALUES   (N'" + nombre + "',N'" + paterno + "',N'" + materno + "'," + idDireccion + "," + telefono + ",N'" + mail + "',CAST(N'" + fechaNac + "' AS datetime)," + sexo + ")", conexion);
                comando.ExecuteNonQuery();

                //SqlDataAdapter consulta = new SqlDataAdapter(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void insertaPacinete()
        {
            string idPersona, altura, peso;

            idPersona = "";
            altura = alturaTxt.Text;
            peso = pesoTxt.Text;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT TOP 1 * FROM  Persona ORDER BY idPersona desc", conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idPersona = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT Paciente(idPersona,Altura,Peso) VALUES   (" + idPersona + ",N'" + altura + "',N'" + peso + "')", conexion);
                comando.ExecuteNonQuery();

                //SqlDataAdapter consulta = new SqlDataAdapter(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void sexoOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
//