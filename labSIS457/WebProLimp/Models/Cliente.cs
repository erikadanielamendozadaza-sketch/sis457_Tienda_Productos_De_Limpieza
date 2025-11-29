using System;
using System.Collections.Generic;

namespace WebProLimp.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? RazonSocial { get; set; }

    public string? CedulaIdentidad { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
