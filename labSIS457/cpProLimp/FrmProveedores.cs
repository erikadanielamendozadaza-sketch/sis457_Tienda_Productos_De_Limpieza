using CadProLimp;
using ClnProLimp;
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
    public partial class FrmProveedores : Form
    {
        private bool esNuevo = false;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = ProveedorCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;

            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombreEmpresa"].HeaderText= "Nombre de la empresa";
            dgvLista.Columns["telefono"].HeaderText = "Telefono";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["email"].HeaderText = "Email";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["nombreEmpresa"];
            btnEditar.Enabled = lista.Count > 0;
            btnBorrar.Enabled = lista.Count > 0;
        }



        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Size = new Size(879, 363);
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlAcciones.Visible = true;
            Size = new Size(879, 524);
        }

        private bool validar()
        {
            bool esValido = true;

            erpNombreEmpresa.Clear();
            erpTelefono.Clear();
            erpDireccion.Clear();
            erpEmail.Clear();

            if (string.IsNullOrWhiteSpace(txtNombreEmpresa.Text))
            {
                erpNombreEmpresa.SetError(txtNombreEmpresa, "El nombre de la empresa es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                erpTelefono.SetError(txtTelefono, "El teléfono es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                erpTelefono.SetError(txtDireccion, "La dirección es obligatoria");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                erpTelefono.SetError(txtEmail, "El email es obligatorio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var proveedor = new Proveedor();
                proveedor.nombreEmpresa = txtNombreEmpresa.Text.Trim();
                proveedor.telefono = txtTelefono.Text.Trim().Length > 0 ? long.Parse(txtTelefono.Text.Trim()) : 0;
                proveedor.direccion = txtDireccion.Text.Trim();
                proveedor.email = txtEmail.Text.Trim();
                proveedor.usuarioRegistro = Util.empleado.usuario;

                if (esNuevo)
                {
                    proveedor.fechaRegistro = DateTime.Now;
                    proveedor.estado = 1;

                    ProveedorCln.insertar(proveedor);
                }
                else
                {
                    proveedor.id = (int)dgvLista.CurrentRow.Cells["id"].Value;

                    ProveedorCln.actualizar(proveedor);
                }


                listar();
                btnCanelar.PerformClick();
                MessageBox.Show("Proveedor guardado correctamente", "::: Mensaje - ProLimp :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            txtNombreEmpresa.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Size = new Size(879, 365);
            pnlAcciones.Enabled = true;
            limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string nombreEmpresa = dgvLista.CurrentRow.Cells["nombreEmpresa"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el proveedor {nombreEmpresa}?",
                "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ProveedorCln.eliminar(id, Util.empleado.usuario);
                listar();
                MessageBox.Show("Proveedor eliminado correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(879, 524);

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var proveedor = ProveedorCln.obtenerUno(id);

            txtNombreEmpresa.Text = proveedor.nombreEmpresa;
            txtTelefono.Text = proveedor.telefono.ToString();
            txtDireccion.Text = proveedor.direccion;
            txtEmail.Text = proveedor.email;

            txtNombreEmpresa.Focus();

        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
    }
}
