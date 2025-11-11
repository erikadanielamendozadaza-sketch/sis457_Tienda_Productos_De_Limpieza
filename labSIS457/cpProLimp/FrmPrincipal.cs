using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpProLimp
{
    public partial class FrmPrincipal : Form
    {
        private FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;

        }

        private void btnCaEmpleados_Click(object sender, EventArgs e)
        {
            new FrmEmpleados().ShowDialog();
        }

        private void btnCaProductos_Click(object sender, EventArgs e)
        {
            new FrmProductos().ShowDialog();
        }

        private void btnCaClientes_Click(object sender, EventArgs e)
        {
            new FrmClientes().ShowDialog();
        }

        private void btnOpVenta_Click(object sender, EventArgs e)
        {
            new FrmVentas().ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.empleado = null;
            frmAutenticacion.Show();
        }

        private void btnReProveedores_Click(object sender, EventArgs e)
        {
            new FrmReProveedores().ShowDialog();
        }

        private void btnReClientes_Click(object sender, EventArgs e)
        {
            new FrmReClientes().ShowDialog();
        }

        private void btnAdEmpleados_Click(object sender, EventArgs e)
        {
            new FrmReEmpleados().ShowDialog();
        }

        private void btnReProductos_Click(object sender, EventArgs e)
        {
            new FrmReProductos().ShowDialog();
        }

        private void btnReVentas_Click(object sender, EventArgs e)
        {
            new FrmReVentas().ShowDialog();
        }
    }
}
