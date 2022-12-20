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
    public partial class modDatos : Form
    {
        string idPersona;
        SqlConnection conexion; 

        public modDatos(string idPersona,string cadenaCon)
        {
            InitializeComponent();
            conexion = new SqlConnection(cadenaCon);
            this.idPersona = idPersona;
        }

        private void modificaDir()
        {
            string idDir = "-1";
            string calle = calleTxt.Text;
            string numero = numTxt.Text;
            string colonia = colTxt.Text;
            string cp = cpTxt.Text;

            string telefono, mail;


            telefono = telTxt.Text;
            mail = mailTxt.Text;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select idDireccion from Persona where idPersona="+ idPersona, conexion);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                idDir = dt.Rows[0][0].ToString();

                
                SqlCommand actualiza = new SqlCommand("UPDATE Direccion\r\nSET Calle = '"+calle+"', Numero = '"+numero+"', Colonia = '"+colonia+"',CP = '"+cp+"'\r\nWHERE idDireccion ="+idDir, conexion);
                actualiza.ExecuteNonQuery();

                SqlCommand actDP = new SqlCommand("UPDATE Persona\r\nset Telefono="+telefono+",Mail='"+mail+"'\r\nwhere idPersona ="+idPersona, conexion);
                actDP.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            modificaDir();
            this.Close();
        }
    }
}
