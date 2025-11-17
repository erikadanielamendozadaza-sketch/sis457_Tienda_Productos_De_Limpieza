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
    public partial class FrmProductos : Form
    {
        private bool esNuevo = false;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = ProductoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idunidadMedida"].Visible = false;
            dgvLista.Columns["idproveedor"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["categoria"].HeaderText = "Categoria";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["stock"].HeaderText = "Stock";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio Venta";
            dgvLista.Columns["fechaVencimiento"].HeaderText = "Fecha de Vencimiento";
            dgvLista.Columns["fechaUltimaCompra"].HeaderText = "Fecha de Ultima Compra";
            dgvLista.Columns["precioCompra"].HeaderText = "Precio de Compra";
            dgvLista.Columns["cantidadMinimaStock"].HeaderText = "Cantidad Mínima Stock";
            dgvLista.Columns["proveedor"].HeaderText = "Proveedor";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";


            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["codigo"];
            btnEditar.Enabled = lista.Count > 0;
            btnBorrar.Enabled = lista.Count > 0;
        }

        private void cargarUnidadMedida()
        {
            var lista = UnidadMedidaCln.listar();
            cbxUnidadMedida.DataSource = lista;
            cbxUnidadMedida.ValueMember = "id";
            cbxUnidadMedida.DisplayMember = "descripcion";
            cbxUnidadMedida.SelectedIndex = -1;
        }

        private void cargarProveedor()
        {
            var lista = ProveedorCln.listar();
            cbxProveedor.DataSource = lista;
            cbxProveedor.ValueMember = "id";
            cbxProveedor.DisplayMember = "nombreEmpresa";
            cbxProveedor.SelectedIndex = -1;
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Size = new Size(1143, 563);
            listar();
            cargarUnidadMedida();
            cargarProveedor();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlAcciones.Enabled = false;
            Size = new Size(1143, 838);
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(1143, 838);

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var producto = ProductoCln.obtenerUno(id);

            txtCodigo.Text = producto.codigo;
            txtNombreProducto.Text = producto.nombre;
            txtCategoria.Text = producto.categoria;
            cbxUnidadMedida.SelectedValue = producto.idunidadMedida;
            nudStock.Value = producto.stock;
            nudPrecioUnitario.Value = producto.precioUnitario;
            nudPrecioCompra.Value = producto.precioCompra;
            dtpFechaVencimiento.Value = producto.fechaVencimiento;
            dtpFechaUltimaCompra.Value = producto.fechaUltimaCompra;
            cbxProveedor.SelectedValue = producto.idproveedor;
            nudCantidadMinimaStock.Value = producto.cantidadMinimaStock;
            txtCategoria.Focus();
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            txtCategoria.Clear();
            cbxUnidadMedida.SelectedIndex = -1;
            cbxProveedor.SelectedIndex = -1;
            nudStock.Value = 0;
            nudPrecioUnitario.Value = 0;
            nudPrecioCompra.Value = 0;
            nudCantidadMinimaStock.Value = 5; 
            dtpFechaVencimiento.Value = DateTime.Now; 
            dtpFechaUltimaCompra.Value = DateTime.Now;
        }
        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1143, 563);
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

            erpCodigo.Clear();
            erpDescripcion.Clear();
            erpUnidadMedida.Clear();
            erpStock.Clear();
            erpPrecioUnitario.Clear();
            erpFechaVencimiento.Clear();
            erpProveedor.Clear();
            erpCategoria.Clear();
            erpFechaUltimaCompra.Clear();
            erpPrecioCompra.Clear();
            erpCantidadMinimaStock.Clear();

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                erpCodigo.SetError(txtCodigo, "El código es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                erpDescripcion.SetError(txtNombreProducto, "El nombre del producto es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                erpCategoria.SetError(txtCategoria, "La categoría es obligatoria");
                esValido = false;
            }
            if (cbxUnidadMedida.SelectedIndex == -1)
            {
                erpUnidadMedida.SetError(cbxUnidadMedida, "Seleccione una unidad de medida");
                esValido = false;
            }
            if (nudStock.Value < 0) 
            {
                erpStock.SetError(nudStock, "El stock no puede ser negativo");
            }
            if (nudPrecioCompra.Value <= 0)
            {
                erpPrecioCompra.SetError(nudPrecioCompra, "El precio de compra debe ser mayor a cero");
                esValido = false;
            }
            if (nudPrecioUnitario.Value <= nudPrecioCompra.Value)
            {
                erpPrecioUnitario.SetError(nudPrecioUnitario,
                    "El precio de venta debe ser mayor al precio de compra");
                esValido = false;
            }
            if (dtpFechaVencimiento.Value < DateTime.Today)
            {
                var result = MessageBox.Show(
                    "La fecha de vencimiento es anterior a hoy. ¿Desea continuar?",
                    "::: Advertencia - ProLimp :::",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    erpFechaVencimiento.SetError(dtpFechaVencimiento,
                        "La fecha de vencimiento no puede ser anterior a hoy");
                    esValido = false;
                }
            }
            if (dtpFechaUltimaCompra.Value > DateTime.Today)
            {
                erpFechaUltimaCompra.SetError(dtpFechaUltimaCompra,
                    "La fecha de última compra no puede ser futura");
                esValido = false;
            }
            if (cbxProveedor.SelectedIndex == -1)
            {
                erpProveedor.SetError(cbxProveedor, "Seleccione un proveedor");
                esValido = false;
            }
            if (nudCantidadMinimaStock.Value <= 0)
            {
                erpCantidadMinimaStock.SetError(nudCantidadMinimaStock,
                    "La cantidad mínima debe ser mayor a cero");
                esValido = false;
            }

            return esValido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var producto = new Producto();
                producto.codigo = txtCodigo.Text.Trim();
                producto.nombre = txtNombreProducto.Text.Trim();
                producto.categoria = txtCategoria.Text.Trim();
                producto.idunidadMedida = (int)cbxUnidadMedida.SelectedValue;
                producto.stock = (int)nudStock.Value;
                producto.precioUnitario = nudPrecioUnitario.Value;
                producto.precioCompra = nudPrecioCompra.Value;
                producto.fechaVencimiento = dtpFechaVencimiento.Value;
                producto.fechaUltimaCompra = dtpFechaUltimaCompra.Value;
                producto.idproveedor = (int)cbxProveedor.SelectedValue;
                producto.cantidadMinimaStock = (int)nudCantidadMinimaStock.Value;
                producto.usuarioRegistro = Util.empleado.usuario;
                if (esNuevo)
                {
                    producto.fechaRegistro = DateTime.Now;
                    producto.estado = 1;
                    ProductoCln.insertar(producto);

                    MessageBox.Show("Producto agregado correctamente",
                        "::: Mensaje - ProLimp :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    producto.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                    ProductoCln.actualizar(producto);

                    MessageBox.Show("Producto actualizado correctamente",
                        "::: Mensaje - ProLimp :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                listar();
                btnCanelar.PerformClick();
                MessageBox.Show("Producto guardado correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string nombre = dgvLista.CurrentRow.Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el producto {nombre}?",
                "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ProductoCln.eliminar(id, Util.empleado.usuario);
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
