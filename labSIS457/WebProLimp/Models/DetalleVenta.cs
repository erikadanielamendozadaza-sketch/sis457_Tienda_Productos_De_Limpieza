using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebProLimp.Models;

public partial class DetalleVenta
{
    public int Id { get; set; }
    [Required(ErrorMessage = "La venta es obligatoria.")]
    public int Idventa { get; set; }
    [Required(ErrorMessage = "El producto es obligatorio.")]
    public int Idproducto { get; set; }
    [Required(ErrorMessage = "La cantidad es obligatoria.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0.")]
    public decimal Cantidad { get; set; }
    [Required(ErrorMessage = "El precio unitario es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio unitario debe ser mayor a 0.")]
    public decimal PrecioUnitario { get; set; }
    [Required(ErrorMessage = "El subtotal es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El subtotal debe ser mayor a 0.")]
    public decimal Subtotal { get; set; } // Calculado en controlador: Cantidad * PrecioUnitario
    [Required(ErrorMessage = "El usuario de registro es obligatorio.")]
    public string UsuarioRegistro { get; set; } = null!;
    public DateTime FechaRegistro { get; set; } = DateTime.Now; // Valor por defecto agregado
    public short Estado { get; set; } = 1;

    public virtual Producto IdproductoNavigation { get; set; } = null!;

    public virtual Venta IdventaNavigation { get; set; } = null!;
}
