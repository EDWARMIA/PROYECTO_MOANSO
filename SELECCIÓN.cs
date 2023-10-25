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
    public partial class SELECCIÓN : Form
    {
        public SELECCIÓN()
        {
            InitializeComponent();
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new REGISTRO_CLIENTE();
            formulario.Show();
            this.Hide();
        }

        private void btnReservaciónPasaje_Click(object sender, EventArgs e)
        {
            Form formulario = new RESERVACIONES();
            formulario.Show();
            this.Hide();
        }

        private void btnRegistroEquipaje_Click(object sender, EventArgs e)
        {
            Form formulario = new REGISTRO_EQUIPAJE();
            formulario.Show();
            this.Hide();
        }

        private void btnReprogramacion_Click(object sender, EventArgs e)
        {
            Form formulario = new REPROGRAMACIÓN();
            formulario.Show();
            this.Hide();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            Form formulario = new SUCURSALES();
            formulario.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form formulario = new SELECCIÓN();
            formulario.Show();
            this.Hide();
        }
    }
}
