using System;
using System.Collections.Generic;

namespace WebProLimp.Models;

public partial class Producto
{
    public int Id { get; set; }

    public int IdunidadMedida { get; set; }

    public int Idproveedor { get; set; }

    public int? Idcategoria { get; set; }

    public int? Idmarca { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public decimal PrecioUnitario { get; set; }

    public int Stock { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public decimal PrecioCompra { get; set; }

    public int CantidadMinimaStock { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Categoria? IdcategoriaNavigation { get; set; }

    public virtual Marca? IdmarcaNavigation { get; set; }

    public virtual Proveedor IdproveedorNavigation { get; set; } = null!;

    public virtual UnidadMedida IdunidadMedidaNavigation { get; set; } = null!;
}
