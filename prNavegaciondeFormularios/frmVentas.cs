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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        public static frmVentas _instancia;

        public static frmVentas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmVentas();  
            }
            return _instancia;
        }

        public void setCliente(string cliente)
        {
            txtClientes.Text = cliente; 
        }


        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmClientes frmvista = new frmClientes();
            frmvista.ShowDialog();  
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
