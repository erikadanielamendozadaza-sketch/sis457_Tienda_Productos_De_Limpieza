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
    public partial class FrmClientes : Form
    {
        private bool esNuevo = false;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = ClienteCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombres"].HeaderText = "Nombres";
            dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "Cédula de Identidad";
            dgvLista.Columns["telefono"].HeaderText = "Teléfono/Celular";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["cedulaIdentidad"];
            btnEditar.Enabled = lista.Count > 0;
            btnBorrar.Enabled = lista.Count > 0;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Size = new Size(876, 366);
            listar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(876, 534);
            txtNombres.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(876, 534);

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var cliente = ClienteCln.obtenerUno(id);
            txtNombres.Text = cliente.nombres;
            txtPrimerApellido.Text = cliente.primerApellido;
            txtSegundoApellido.Text = cliente.segundoApellido;
            txtCedulaIdentidad.Text = cliente.cedulaIdentidad;
            txtTelefono.Text = cliente.telefono.ToString();

            txtNombres.Focus();
        }

        private void limpiar()
        {
            txtNombres.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtCedulaIdentidad.Clear();
            txtTelefono.Clear();
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Size = new Size(876, 366);
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
            erpCedulaIdentidad.Clear();
            erpTelefono.Clear();

            if (string.IsNullOrEmpty(txtNombres.Text.Trim()))
            {
                erpNombres.SetError(txtNombres, "El campo nombres es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text.Trim()))
            {
                erpPrimerApellido.SetError(txtPrimerApellido, "El campo primer apellido es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtSegundoApellido.Text.Trim()))
            {
                erpSegundoApellido.SetError(txtSegundoApellido, "El campo segundo apellido es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text.Trim()))
            {
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo cédula de identidad es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                erpTelefono.SetError(txtTelefono, "El campo teléfono/celular es obligatorio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var cliente = new Cliente();
                cliente.nombres = txtNombres.Text.Trim();
                cliente.primerApellido = txtPrimerApellido.Text.Trim();
                cliente.segundoApellido = txtSegundoApellido.Text.Trim();
                cliente.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                cliente.telefono = txtTelefono.Text.Trim().Length > 0 ? long.Parse(txtTelefono.Text.Trim()) : 0;
                cliente.usuarioRegistro = Util.empleado.usuario;

                if (esNuevo)
                {
                    cliente.fechaRegistro = DateTime.Now;
                    cliente.estado = 1;
                    ClienteCln.insertar(cliente);
                }
                else
                {
                    cliente.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                    ClienteCln.actualizar(cliente);
                }
                listar();
                btnCanelar.PerformClick();
                MessageBox.Show("Cliente guardado correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string cedulaIdentidad = dgvLista.CurrentRow.Cells["cedulaIdentidad"].Value.ToString();
            string nombres = dgvLista.CurrentRow.Cells["nombres"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el cliente {nombres}?",
                "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ClienteCln.eliminar(id, Util.empleado.usuario);
                listar();
                MessageBox.Show("Cliente dado de baja correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
