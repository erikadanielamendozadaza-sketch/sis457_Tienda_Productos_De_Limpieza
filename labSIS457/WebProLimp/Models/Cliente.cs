using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebProLimp.Models;

public partial class Cliente
{
    public int Id { get; set; }
    [Required(ErrorMessage = "La razón social es obligatoria.")]
    [StringLength(50, ErrorMessage = "La razón social no puede exceder 50 caracteres.")]
    public string? RazonSocial { get; set; }
    [Required(ErrorMessage = "La cédula de identidad es obligatoria.")]
    [StringLength(10, ErrorMessage = "La cédula no puede exceder 10 caracteres.")]
    public string? CedulaIdentidad { get; set; } // Usado para búsqueda por CI en formulario
    [Required(ErrorMessage = "El usuario de registro es obligatorio.")]
    public string UsuarioRegistro { get; set; } = null!;
    public DateTime FechaRegistro { get; set; } = DateTime.Now; // Valor por defecto agregado
    public short Estado { get; set; } = 1;

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
