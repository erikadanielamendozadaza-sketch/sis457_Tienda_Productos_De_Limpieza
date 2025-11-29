using System;
using System.Collections.Generic;

namespace WebProLimp.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public string NombreEmpresa { get; set; } = null!;

    public long Telefono { get; set; }

    public string? Direccion { get; set; }

    public string Email { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Producto> Producto { get; set; } = new List<Producto>();
}
