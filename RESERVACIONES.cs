using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearCaapas
{
    public partial class RESERVACIONES : Form
    {
        public RESERVACIONES()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form formulario = new SELECCIÓN();
            formulario.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form formulario = new SELECCIÓN();
            formulario.Show();
            this.Hide();
        }
    }
}
