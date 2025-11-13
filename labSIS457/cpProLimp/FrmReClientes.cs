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
    public partial class FrmReClientes : Form
    {
        public FrmReClientes()
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void FrmReClientes_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
