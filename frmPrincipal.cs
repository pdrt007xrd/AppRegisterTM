using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegisterTM
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearCliente Crear = new frmCrearCliente();
            Crear.MdiParent = this;
            Crear.Show();
            

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarClientes consultar = new frmConsultarClientes();
            consultar.MdiParent = this;
            consultar.Show();
            
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte reportes = new frmReporte();
            reportes.MdiParent = this;
            reportes.Show();
        }
    }
}
