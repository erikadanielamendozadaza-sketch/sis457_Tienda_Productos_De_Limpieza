using System;
using System.Collections.Generic;

namespace WebProLimp.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public string CedulaIdentidad { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public long Telefono { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
