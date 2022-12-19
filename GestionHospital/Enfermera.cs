using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHospital
{
    public partial class Enfermera : Form
    {
        public Enfermera(string nombre)
        {
            InitializeComponent();
            lblMensaje.Text = nombre;
        }
    }
}
