using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prNavegaciondeFormularios
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmVentas frm = frmVentas.GetInstancia();
            string part1 = cboSCliente.Text;
            frm.setCliente(part1);
            this.Hide();
        }
    }
}
