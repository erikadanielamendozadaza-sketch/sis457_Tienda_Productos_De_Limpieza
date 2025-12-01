using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebProLimp.Models;

public partial class Producto
{
    public int Id { get; set; }

    public int IdunidadMedida { get; set; }

    public int Idproveedor { get; set; }

    public int? Idcategoria { get; set; }

    public int? Idmarca { get; set; }

    [Required(ErrorMessage = "El código es obligatorio.")]
    [StringLength(50, ErrorMessage = "El código no puede exceder 50 caracteres.")]
    public string Codigo { get; set; } = null!;
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
    public string Nombre { get; set; } = null!;
    [Required(ErrorMessage = "El precio de venta es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio de venta debe ser mayor a 0.")]
    public decimal PrecioUnitario { get; set; } // Cambiado de PrecioUnitario para coincidir con formulario
    [Required(ErrorMessage = "El stock es obligatorio.")]
    [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo.")]
    public int Stock { get; set; } // Usado para validaciones de stock en formulario
    public DateOnly? FechaVencimiento { get; set; } // Mantén DateOnly o cambia a DateTime? si prefieres
    [Required(ErrorMessage = "El precio de compra es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio de compra debe ser mayor a 0.")]
    public decimal PrecioCompra { get; set; }
    [Required(ErrorMessage = "La cantidad mínima de stock es obligatoria.")]
    [Range(0, int.MaxValue, ErrorMessage = "La cantidad mínima no puede ser negativa.")]
    public int CantidadMinimaStock { get; set; }
    [Required(ErrorMessage = "El usuario de registro es obligatorio.")]
    public string UsuarioRegistro { get; set; } = null!;
    public DateTime FechaRegistro { get; set; } = DateTime.Now; // Valor por defecto agregado
    public short Estado { get; set; } = 1;

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Categoria? IdcategoriaNavigation { get; set; }

    public virtual Marca? IdmarcaNavigation { get; set; }

    public virtual Proveedor IdproveedorNavigation { get; set; } = null!;

    public virtual UnidadMedida IdunidadMedidaNavigation { get; set; } = null!;
}
