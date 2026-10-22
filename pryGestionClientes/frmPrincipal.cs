using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargaClientes = new frmCargaDeClientes();
            cargaClientes.ShowDialog();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListadoClientes = new frmListadoClientes();
            ListadoClientes.ShowDialog();
        }

        private void listadoDeDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListadoDeudores = new frmDeudores();
            ListadoDeudores.ShowDialog();
        }

        

        private void listadoDeudoresOrdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListadoOrdenadoDeudores = new frmListadoOrdenadoDeudores();
            ListadoOrdenadoDeudores.ShowDialog();
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Principal = new frmPrincipal();
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: Bruno Capello \nLegajo: 46378757 \nCarrera: Analista de Sistemas", "Mis datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
