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
    public partial class FrmEmpleados : Form
    {
        private bool esNuevo = false;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = EmpleadoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombres"].HeaderText = "Nombres";
            dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvLista.Columns["usuario"].HeaderText = "Usuario";
            dgvLista.Columns["telefono"].HeaderText = "Teléfono/Celular";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["usuario"];
            btnEditar.Enabled = lista.Count > 0;
            btnBorrar.Enabled = lista.Count > 0;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            Size = new Size(834, 373);
            listar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(834, 582);
            txtNombres.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(834, 582);

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var empleado = EmpleadoCln.obtenerUno(id);
            txtNombres.Text = empleado.nombres;
            txtPrimerApellido.Text = empleado.primerApellido;
            txtSegundoApellido.Text = empleado.segundoApellido;
            txtUsuario.Text = empleado.usuario;
            txtClave.Text = empleado.clave;
            txtTelefono.Text = empleado.telefono.ToString();

            txtNombres.Focus();
        }

        private void limpiar()
        {
            txtNombres.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            txtTelefono.Clear();
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Size = new Size(834, 373);
            pnlAcciones.Enabled = true;
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpNombres.Clear();
            erpPrimerApellido.Clear();
            erpSegundoApellido.Clear();
            erpUsuario.Clear();
            erpContraseña.Clear();
            erpTelefono.Clear();

            if (string.IsNullOrEmpty(txtNombres.Text.Trim()))
            {
                erpNombres.SetError(txtNombres, "El campo nombres es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text.Trim()))
            {
                erpNombres.SetError(txtPrimerApellido, "El campo primer apellido es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtSegundoApellido.Text.Trim()))
            {
                erpNombres.SetError(txtSegundoApellido, "El campo segundo apellido es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                erpNombres.SetError(txtUsuario, "El campo usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text.Trim()))
            {
                erpNombres.SetError(txtClave, "El campo clave es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                erpNombres.SetError(txtTelefono, "El campo clave es obligatorio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado();
                empleado.nombres = txtNombres.Text.Trim();
                empleado.primerApellido = txtPrimerApellido.Text.Trim();
                empleado.segundoApellido = txtSegundoApellido.Text.Trim();
                empleado.usuario = txtUsuario.Text.Trim();
                empleado.clave = txtClave.Text.Trim();
                empleado.telefono = txtTelefono.Text.Trim().Length > 0 ? long.Parse(txtTelefono.Text.Trim()) : 0;

                if (esNuevo)
                {
                    empleado.fechaRegistro = DateTime.Now;
                    empleado.estado = 1;
                    EmpleadoCln.insertar(empleado);
                }
                else
                {
                    empleado.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                    EmpleadoCln.actualizar(empleado);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Empleado guardado correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string nombres = dgvLista.CurrentRow.Cells["nombres"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el cliente {nombres}?",
                "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                EmpleadoCln.eliminar(id, Util.empleado.usuario);
                listar();
                MessageBox.Show("Empleado dado de baja correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
