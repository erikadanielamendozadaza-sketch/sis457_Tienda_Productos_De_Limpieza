using ClnProLimp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpProLimp
{
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FrmAutenticacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpUsuario.Clear();
            erpClave.Clear();

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                erpClave.SetError(txtClave, "La clave es obligatoria");
                esValido = false;
            }

            return esValido;
        }
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = EmpleadoCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (empleado != null)
                {
                    Util.empleado = empleado;
                    txtClave.Clear();
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    Hide();
                    new FrmPrincipal(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "::: Mensaje - ProLimp :) :::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; 

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtClave.Focus();
                txtClave.SelectAll();
            }
        }

        private void FrmAutenticacion_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
