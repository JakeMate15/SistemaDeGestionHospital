using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionHospital
{

    public partial class Form1 : Form
    {
        //SqlConnection conexion = new SqlConnection(@"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        string cadCon;
        SqlConnection conexion; 


        public Form1(){
            InitializeComponent();
            cadCon = @"data source=DESKTOP-GJ16MIS\SQLEXPRESS;initial catalog=Hospital;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            conexion = new SqlConnection(cadCon);
        }

        public void loggin(string usuario, string contrasena){

            try{
                conexion.Open();


                SqlCommand comando = new SqlCommand("SELECT Nombre, paterno, idTipoTrabajador FROM Usuario AS u INNER JOIN Empleado AS e ON u.IdEmpleado = e.idEmpleado INNER JOIN Persona AS p ON e.idPersona = p.idPersona where u.idUsuario =@usuario and u.Contraseña=@contrasena",conexion);
                comando.Parameters.AddWithValue("usuario", usuario);
                comando.Parameters.AddWithValue("contrasena", contrasena);

                SqlDataAdapter consulta = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                consulta.Fill(dt);

                
                if (dt.Rows.Count == 1){
                    this.Hide();
                    
                    //Doctor
                    if (dt.Rows[0][2].ToString() == "1"){
                        new Dr(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), cadCon).Show();
                    }

                    //Enfermera
                    else if (dt.Rows[0][2].ToString() == "2"){
                        new Enfermera(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), cadCon).Show();
                    }

                    //Admin
                    else if (dt.Rows[0][2].ToString() == "3"){
                        new Admin(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(),cadCon).Show();
                    }

                }
                else{
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                }

            }
            catch(Exception e){
                
                MessageBox.Show(e.Message);
            }
            finally{
                conexion.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){
            string usuario = this.usuario.Text;
            string cont = this.cont.Text;

            loggin(usuario,cont);
        }
    }
}
