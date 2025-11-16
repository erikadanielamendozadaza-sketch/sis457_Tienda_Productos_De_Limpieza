using CadProLimp;
using ClnProLimp;
using System;
using System.Collections;
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
    public partial class FrmVentas : Form
    {
        public class ItemVenta
        {
            public int idProducto { get; set; }
            public string nombre { get; set; }
            public decimal precioUnitario { get; set; }
            public decimal cantidad { get; set; }
            public decimal subtotal { get; set; }
        }


        List<ItemVenta> detalle = new List<ItemVenta>();
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void cargarClientes()
        {
            var lista = ClienteCln.listarPa("");
            var listaMod = lista.Select(x => new
            {
                x.id,
                nombreCompleto = x.nombres + " " + x.primerApellido + " " + x.segundoApellido
            }).ToList();

            cbxCliente.DataSource = listaMod;
            cbxCliente.DisplayMember = "nombreCompleto";
            cbxCliente.ValueMember = "id";
        }

        private void listarProductos()
        {
            var lista = ProductoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;

            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idunidadMedida"].Visible = false;
            dgvLista.Columns["idproveedor"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["unidadMedida"].Visible = false;
            dgvLista.Columns["fechaVencimiento"].Visible = false;
            dgvLista.Columns["fechaUltimaCompra"].Visible = false;
            dgvLista.Columns["precioCompra"].Visible = false;
            dgvLista.Columns["cantidadMinimaStock"].Visible = false;
            dgvLista.Columns["proveedor"].Visible = false;
            dgvLista.Columns["usuarioRegistro"].Visible = false;
            dgvLista.Columns["fechaRegistro"].Visible = false;

            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["categoria"].HeaderText = "Categoría";
            dgvLista.Columns["stock"].HeaderText = "Stock";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio Venta";

            dgvLista.Columns["codigo"].DisplayIndex = 0;
            dgvLista.Columns["nombre"].DisplayIndex = 1;
            dgvLista.Columns["categoria"].DisplayIndex = 2;
            dgvLista.Columns["stock"].DisplayIndex = 3;
            dgvLista.Columns["precioVenta"].DisplayIndex = 4;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cargarClientes();

            lblEmplead.Text = Util.empleado.nombres + " " +
                       Util.empleado.primerApellido;

            lblUsuari.Text = Util.empleado.usuario;

            dtpFechaVenta.Value = DateTime.Now;

            listarProductos();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
            cargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listarProductos();
        }

        private void btnBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listarProductos();
        }

        private void calcularTotal()
        {
            decimal total = detalle.Sum(d => d.subtotal);
            lblTotal.Text = total.ToString("0.00");
        }

        private void refrescarDetalle()
        {
            dgvVenta.DataSource = null;
            dgvVenta.DataSource = detalle;

            dgvVenta.Columns["idProducto"].Visible = false;
            dgvVenta.Columns["nombre"].HeaderText = "Producto";
            dgvVenta.Columns["precioUnitario"].HeaderText = "Precio unit.";
            dgvVenta.Columns["cantidad"].HeaderText = "Cantidad";
            dgvVenta.Columns["subtotal"].HeaderText = "Sub total";

            calcularTotal();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow == null) return;

            int idProd = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string nombre = dgvLista.CurrentRow.Cells["nombre"].Value.ToString();
            decimal precio = decimal.Parse(dgvLista.CurrentRow.Cells["precioVenta"].Value.ToString());
            int stock = (int)dgvLista.CurrentRow.Cells["stock"].Value;
            var existente = detalle.FirstOrDefault(x => x.idProducto == idProd);
            if (existente != null)
            {
                if (existente.cantidad + 1 > stock)
                {
                    MessageBox.Show("No hay suficiente stock para agregar más unidades.", "::: Mensaje - ProLimp :::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existente.cantidad += 1;
                existente.subtotal = existente.precioUnitario * existente.cantidad;
            }
            else
            {
                if (stock < 1)
                {
                    MessageBox.Show("Este producto no tiene stock disponible.", "::: Mensaje - ProLimp :::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var item = new ItemVenta
                {
                    idProducto = idProd,
                    nombre = nombre,
                    precioUnitario = precio,
                    cantidad = 1,
                    subtotal = precio * 1
                };
                detalle.Add(item);
            }

            refrescarDetalle();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (detalle.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "::: Mensaje - ProLimp :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var venta = new Venta();
            venta.idcliente = (int)cbxCliente.SelectedValue;
            venta.idempleado = Util.empleado.id;
            venta.fecha = DateTime.Now;
            venta.total = detalle.Sum(x => x.subtotal);

            venta.fechaRegistro = DateTime.Now;
            venta.estado = 1;
            venta.usuarioRegistro = Util.empleado.usuario;
            int idVenta = VentaCln.insertar(venta);
            foreach (var item in detalle)
            {
                var det = new DetalleVenta();
                det.idventa = idVenta;
                det.idproducto = item.idProducto;
                det.cantidad = item.cantidad;
                det.precioUnitario = item.precioUnitario;
                det.subtotal = item.subtotal;

                det.usuarioRegistro = Util.empleado.usuario;
                det.fechaRegistro = DateTime.Now;
                det.estado = 1;
                DetalleVentaCln.insertar(det);
            }
            MessageBox.Show("Venta registrada correctamente.", "::: Mensaje - ProLimp :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            detalle.Clear();
            refrescarDetalle();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow == null) return;

            int idProd = (int)dgvVenta.CurrentRow.Cells["idProducto"].Value;

            var item = detalle.FirstOrDefault(x => x.idProducto == idProd);
            if (item == null) return;

            var filaProd = dgvLista.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => (int)r.Cells["id"].Value == idProd);

            if (filaProd == null) return;

            int stock = (int)filaProd.Cells["stock"].Value;

            if (item.cantidad + 1 > stock)
            {
                MessageBox.Show("No hay suficiente stock para agregar más unidades.", "::: Mensaje - ProLimp :::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            item.cantidad += 1;
            item.subtotal = item.cantidad * item.precioUnitario;

            refrescarDetalle();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow == null) return;

            int idProd = (int)dgvVenta.CurrentRow.Cells["idProducto"].Value;
            var item = detalle.FirstOrDefault(x => x.idProducto == idProd);

            if (item != null)
            {
                if (item.cantidad > 1)
                {
                    item.cantidad -= 1;
                    item.subtotal = item.cantidad * item.precioUnitario;
                }
                else
                {
                    detalle.Remove(item);
                }
            }

            refrescarDetalle();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "::: Mensaje - ProLimp :::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProd = (int)dgvVenta.CurrentRow.Cells["idProducto"].Value;
            var item = detalle.FirstOrDefault(x => x.idProducto == idProd);

            if (item != null)
            {
                detalle.Remove(item);
            }

            refrescarDetalle();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (detalle.Count == 0) return;

            var r = MessageBox.Show("¿Seguro que desea vaciar toda la venta?", "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.No) return;

            detalle.Clear();
            refrescarDetalle();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Desea cancelar la venta? Se perderán los datos.", "::: Mensaje - ProLimp :::", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
