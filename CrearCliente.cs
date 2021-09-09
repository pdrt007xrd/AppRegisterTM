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
    public partial class frmCrearCliente : Form
    {
        public frmCrearCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearTextBox();


        }

        public void ClearTextBox()
        {
            var dialogResult = MessageBox.Show("Seguro que quieres borrar todos los Campos? ", "Limpieza de Campos", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtAseguradora.Clear();
                txtBienesAsegurados.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedulaRnc.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtDireccionPersonal.Clear();
                txtTelefonoLaboral.Clear();
                txtdireccionlaboral.Clear();
                txtAprobacion.Clear();
                txtAseguradora.Focus();

            }
        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                ClientesFormAppTableAdapters.ClientesTableAdapter cli = new ClientesFormAppTableAdapters.ClientesTableAdapter();
                cli.Add(

                DtpFechaActual.Value.ToString(),
                txtAseguradora.Text.Trim(),
                txtBienesAsegurados.Text.Trim(),
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtCedulaRnc.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtTelefonoLaboral.Text.Trim(),
                txtDireccionPersonal.Text.Trim(),
                txtdireccionlaboral.Text.Trim(),
                txtEmail.Text.Trim(),
                CboPeriodo.Text.Trim(),
                DtpFechaPago.Value.ToString(),
                cboPagoDepositado.Text.Trim(),
                txtAprobacion.Text.Trim(),
                cboOfac.Text.Trim(),
                cboOnu.Text.Trim(),
                cboInterpol.Text.Trim(),
                CboConoceCliente.Text.Trim(),
                CboGoogle.Text.Trim()

                    );

                MessageBox.Show("Cliente Agregado Correctamente!");
                ClearTextBox();

            }
            catch (Exception x)
            {

                MessageBox.Show("Error en la conexión" + x);
            }

        }
    }
}
