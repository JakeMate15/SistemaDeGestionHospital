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
    public partial class Dr : Form
    {
        public Dr(string nombre)
        {
            InitializeComponent();
            nomDr.Text = nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
