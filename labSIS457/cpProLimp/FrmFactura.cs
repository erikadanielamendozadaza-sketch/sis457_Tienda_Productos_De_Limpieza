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
    public partial class FrmFactura : Form
    {
        private int idVenta;
        private string nombreCliente;
        private string ciCliente;
        private DateTime fechaVenta;
        private decimal totalVenta;
        private List<FrmVentas.ItemVenta> detalleVenta;
        public FrmFactura(int idVenta, string cliente, string ci,
                         DateTime fecha, decimal total, List<FrmVentas.ItemVenta> detalle)
        {
            InitializeComponent();
            this.idVenta = idVenta;
            this.nombreCliente = cliente;
            this.ciCliente = ci;
            this.fechaVenta = fecha;
            this.totalVenta = total;
            this.detalleVenta = detalle;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            this.Text = $"Factura N° {idVenta}";
            lblTitulo.Text = "FACTURA DE VENTA";
            lblNumero.Text = $"N° {idVenta.ToString("00000")}";
            lblFecha.Text = $"Fecha: {fechaVenta:dd/MM/yyyy HH:mm}";
            lblCliente.Text = $"Cliente: {nombreCliente}";
            lblCI.Text = $"CI: {ciCliente}";

            dgvDetalle.DataSource = detalleVenta;

            dgvDetalle.Columns["idProducto"].Visible = false;
            dgvDetalle.Columns["nombre"].HeaderText = "Producto";
            dgvDetalle.Columns["cantidad"].HeaderText = "Cantidad";
            dgvDetalle.Columns["precioUnitario"].HeaderText = "Precio Unit.";
            dgvDetalle.Columns["subtotal"].HeaderText = "Subtotal";

            dgvDetalle.Columns["cantidad"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["precioUnitario"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["subtotal"].DefaultCellStyle.Format = "N2";

            lblTotal.Text = $"TOTAL: Bs. {totalVenta:N2}";
            lblTotal.Font = new Font(lblTotal.Font.FontFamily, 14, FontStyle.Bold);
            lblTotal.ForeColor = Color.Green;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
