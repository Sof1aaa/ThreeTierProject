using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeTierProject;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form formulario)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.Manual;
            formulario.Location = new Point(0, 0);
            formulario.WindowState = FormWindowState.Maximized;

            formulario.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form1());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Producto());
        }
    }
}