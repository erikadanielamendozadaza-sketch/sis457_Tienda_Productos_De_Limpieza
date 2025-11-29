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
            dgvLista.Columns["razonSocial"].HeaderText = "Razon Social";
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "Cédula de Identidad";
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
            txtRazonSocial.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(876, 534);

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var cliente = ClienteCln.obtenerUno(id);
            txtRazonSocial.Text = cliente.razonSocial;
            txtCedulaIdentidad.Text = cliente.cedulaIdentidad;

            txtRazonSocial.Focus();
        }

        private void limpiar()
        {
            txtRazonSocial.Clear();
            txtCedulaIdentidad.Clear();
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
            erpRazonSocial.Clear();
            erpCedulaIdentidad.Clear();
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text) &&
                string.IsNullOrWhiteSpace(txtCedulaIdentidad.Text))
            {
                erpRazonSocial.SetError(txtRazonSocial, "Debe ingresar al menos un dato del cliente");
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "Debe ingresar al menos un dato del cliente");
                return false;
            }
            int? idActual = esNuevo ? (int?)null : (int)dgvLista.CurrentRow.Cells["id"].Value;
            var ced = txtCedulaIdentidad.Text.Trim();
            if (!string.IsNullOrWhiteSpace(ced) && ClienteCln.ExisteCedula(ced, idActual))
            {
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "La cédula ya está registrada.");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            try
            {
                var cliente = new Cliente
                {
                    razonSocial = txtRazonSocial.Text.Trim(),
                    cedulaIdentidad = txtCedulaIdentidad.Text.Trim(),
                    usuarioRegistro = Util.empleado.usuario
                };
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
                btnCancelar.PerformClick();
                MessageBox.Show("Cliente guardado correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex) 
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string cedulaIdentidad = dgvLista.CurrentRow.Cells["cedulaIdentidad"].Value.ToString();
            string razonSocial = dgvLista.CurrentRow.Cells["razonSocial"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el cliente {razonSocial}?",
                "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ClienteCln.eliminar(id, Util.empleado.usuario);
                listar();
                MessageBox.Show("Cliente dado de baja correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Size = new Size(876, 366);
            pnlAcciones.Enabled = true;
            limpiar();
        }
    }
}
