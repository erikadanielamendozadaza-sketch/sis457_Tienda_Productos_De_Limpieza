using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebProLimp.Models;

public partial class LabProLimpContext : DbContext
{
    public LabProLimpContext()
    {
    }

    public LabProLimpContext(DbContextOptions<LabProLimpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    public virtual DbSet<Empleado> Empleado { get; set; }

    public virtual DbSet<Marca> Marca { get; set; }

    public virtual DbSet<Producto> Producto { get; set; }

    public virtual DbSet<Proveedor> Proveedor { get; set; }

    public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=LabProLimp;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3213E83F34D41874");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3213E83FF97A2AE2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CedulaIdentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cedulaIdentidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("razonSocial");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<DetalleVenta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DetalleV__3213E83F861C4F94");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Idproducto).HasColumnName("idproducto");
            entity.Property(e => e.Idventa).HasColumnName("idventa");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precioUnitario");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("subtotal");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdproductoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.Idproducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DetalleVenta_Producto");

            entity.HasOne(d => d.IdventaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.Idventa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DetalleVenta_Venta");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empleado__3213E83F48FA25C2");

            entity.HasIndex(e => e.Usuario, "UQ__Empleado__9AFF8FC6261C7EC9").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CedulaIdentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cedulaIdentidad");
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombres)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("primerApellido");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("segundoApellido");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Marca__3213E83F50423074");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3213E83F8AE6FC23");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CantidadMinimaStock)
                .HasDefaultValue(5)
                .HasColumnName("cantidadMinimaStock");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fechaVencimiento");
            entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");
            entity.Property(e => e.Idmarca).HasColumnName("idmarca");
            entity.Property(e => e.Idproveedor).HasColumnName("idproveedor");
            entity.Property(e => e.IdunidadMedida).HasColumnName("idunidadMedida");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precioCompra");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precioUnitario");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdcategoriaNavigation).WithMany(p => p.Producto)
                .HasForeignKey(d => d.Idcategoria)
                .HasConstraintName("fk_Producto_Categoria");

            entity.HasOne(d => d.IdmarcaNavigation).WithMany(p => p.Producto)
                .HasForeignKey(d => d.Idmarca)
                .HasConstraintName("fk_Producto_Marca");

            entity.HasOne(d => d.IdproveedorNavigation).WithMany(p => p.Producto)
                .HasForeignKey(d => d.Idproveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Producto_Proveedor");

            entity.HasOne(d => d.IdunidadMedidaNavigation).WithMany(p => p.Producto)
                .HasForeignKey(d => d.IdunidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Producto_UnidadMedida");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3213E83FD6D90E54");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreEmpresa");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<UnidadMedida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnidadMe__3213E83F952BA7A1");

            entity.HasIndex(e => e.Descripcion, "UQ__UnidadMe__298336B6DBD357BC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Venta__3213E83FB967462E");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Idcliente).HasColumnName("idcliente");
            entity.Property(e => e.Idempleado).HasColumnName("idempleado");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Venta_Cliente");

            entity.HasOne(d => d.IdempleadoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.Idempleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Venta_Empleado");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
