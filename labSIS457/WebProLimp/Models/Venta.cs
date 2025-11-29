using System;
using System.Collections.Generic;

namespace WebProLimp.Models;

public partial class Venta
{
    public int Id { get; set; }

    public int Idcliente { get; set; }

    public int Idempleado { get; set; }

    public DateOnly Fecha { get; set; }

    public decimal Total { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Cliente IdclienteNavigation { get; set; } = null!;

    public virtual Empleado IdempleadoNavigation { get; set; } = null!;
}
