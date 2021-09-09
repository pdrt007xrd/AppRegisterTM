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
    public partial class frmConsultarClientes : Form
    {
        public frmConsultarClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //carga los datos al grid
            ClientesFormAppTableAdapters.ClientesTableAdapter ta = new ClientesFormAppTableAdapters.ClientesTableAdapter();
            ClientesFormApp.ClientesDataTable dt = ta.GetData();
            dataGridView1.DataSource = dt;
        }
    }
}
