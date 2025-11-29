using System;
using System.Collections.Generic;

namespace WebProLimp.Models;

public partial class DetalleVenta
{
    public int Id { get; set; }

    public int Idventa { get; set; }

    public int Idproducto { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Subtotal { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Producto IdproductoNavigation { get; set; } = null!;

    public virtual Venta IdventaNavigation { get; set; } = null!;
}
