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
    public partial class FrmReProductos : Form
    {
        public FrmReProductos()
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
        }

        private void FrmReProductos_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
    }
}
