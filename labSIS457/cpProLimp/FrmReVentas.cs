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
    public partial class FrmReVentas : Form
    {
        public FrmReVentas()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = VentaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;

            var listaVentas = VentaCln.listar(); 
            var listaClientes = ClienteCln.listar();
            var listaEmpleados = EmpleadoCln.listar();

            var listaCompleta = from v in listaVentas
                                join c in listaClientes on v.idcliente equals c.id
                                join e in listaEmpleados on v.idempleado equals e.id
                                where v.estado != -1
                                select new
                                {
                                    v.id,
                                    v.fecha,
                                    Cliente = c.nombres + " " + c.primerApellido,
                                    Empleado = e.nombres + " " + e.primerApellido,
                                    v.total,
                                    v.usuarioRegistro,
                                    v.fechaRegistro
                                };

            if (!string.IsNullOrEmpty(txtParametro.Text))
            {
                listaCompleta = listaCompleta.Where(x =>
                    x.Cliente.Contains(txtParametro.Text) ||
                    x.Empleado.Contains(txtParametro.Text));
            }

            dgvLista.DataSource = listaCompleta.ToList();

            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["fecha"].HeaderText = "Fecha Venta";
            dgvLista.Columns["Cliente"].HeaderText = "Cliente";
            dgvLista.Columns["Empleado"].HeaderText = "Vendedor";
            dgvLista.Columns["total"].HeaderText = "Total Bs.";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
        }

        private void FrmReVentas_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
