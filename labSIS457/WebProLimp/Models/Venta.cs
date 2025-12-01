using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebProLimp.Models;

public partial class Venta
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El cliente es obligatorio.")]
    public int Idcliente { get; set; }
    [Required(ErrorMessage = "El empleado es obligatorio.")]
    public int Idempleado { get; set; }
    [Required(ErrorMessage = "La fecha es obligatoria.")]
    public DateTime Fecha { get; set; } = DateTime.Now; // Cambiado de DateOnly a DateTime para consistencia con formulario
    [Required(ErrorMessage = "El total es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El total debe ser mayor a 0.")]
    public decimal Total { get; set; }
    [Required(ErrorMessage = "El usuario de registro es obligatorio.")]
    public string UsuarioRegistro { get; set; } = null!;
    public DateTime FechaRegistro { get; set; } = DateTime.Now; // Valor por defecto agregado
    public short Estado { get; set; } = 1;

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Cliente IdclienteNavigation { get; set; } = null!;

    public virtual Empleado IdempleadoNavigation { get; set; } = null!;
}
