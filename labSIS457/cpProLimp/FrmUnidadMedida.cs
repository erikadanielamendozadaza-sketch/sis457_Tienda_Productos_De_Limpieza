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
    public partial class FrmUnidadMedida : Form
    {
        private bool esNuevo = false;
        public FrmUnidadMedida()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = UnidadMedidaCln.listarPa("");
            dgvLista.DataSource = lista;

            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";

            if (lista.Count > 0)
                dgvLista.CurrentCell = dgvLista.Rows[0].Cells["descripcion"];

            btnEditar.Enabled = lista.Count > 0;
            btnBorrar.Enabled = lista.Count > 0;
        }

        private void FrmUnidadMedida_Load(object sender, EventArgs e)
        {
            Size = new Size(831, 389);
            listar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(831, 497);
            txtUnidadMedida.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(831, 497);

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var unidadMedida = UnidadMedidaCln.obtenerUno(id);

            txtUnidadMedida.Text = unidadMedida.descripcion;

            txtUnidadMedida.Focus();
        }

        private void limpiar()
        {
            txtUnidadMedida.Clear();
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Size = new Size(831, 389);
            pnlAcciones.Enabled = true;
            limpiar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpUnidadMedida.Clear();

            if (string.IsNullOrEmpty(txtUnidadMedida.Text.Trim()))
            { 
                erpUnidadMedida.SetError(txtUnidadMedida, "Ingrese la descripción de la unidad de medida");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var unidadMedida = new UnidadMedida();
                unidadMedida.descripcion = txtUnidadMedida.Text.Trim();
                unidadMedida.usuarioRegistro = Util.empleado.usuario;

                if (esNuevo)
                {
                    unidadMedida.fechaRegistro = DateTime.Now;
                    unidadMedida.estado = 1;
                    UnidadMedidaCln.insertar(unidadMedida);
                }
                else
                {
                    unidadMedida.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                    UnidadMedidaCln.actualizar(unidadMedida);
                }
                listar();
                btnCanelar.PerformClick();
                MessageBox.Show("Descripción guardada correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string descripcion = dgvLista.CurrentRow.Cells["descripcion"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar la unidad de medida {descripcion}?",
                "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                UnidadMedidaCln.eliminar(id, Util.empleado.usuario);
                listar();
                MessageBox.Show("Unidad de medida borrada correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
