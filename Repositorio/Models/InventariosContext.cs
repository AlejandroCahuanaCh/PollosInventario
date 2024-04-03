using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repositorio.Models
{
    public partial class InventariosContext : DbContext
    {
        public InventariosContext()
        {
        }

        public InventariosContext(DbContextOptions<InventariosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacen> Almacens { get; set; } = null!;
        public virtual DbSet<Comprobante> Comprobantes { get; set; } = null!;
        public virtual DbSet<CondicionPago> CondicionPagos { get; set; } = null!;
        public virtual DbSet<DetalleComprobante> DetalleComprobantes { get; set; } = null!;
        public virtual DbSet<DetalleMovimiento> DetalleMovimientos { get; set; } = null!;
        public virtual DbSet<Entidad> Entidads { get; set; } = null!;
        public virtual DbSet<EntidadComprobante> EntidadComprobantes { get; set; } = null!;
        public virtual DbSet<FormaPago> FormaPagos { get; set; } = null!;
        public virtual DbSet<Movimiento> Movimientos { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<ProductoAlmacen> ProductoAlmacens { get; set; } = null!;
        public virtual DbSet<ProductoPrecio> ProductoPrecios { get; set; } = null!;
        public virtual DbSet<Serie> Series { get; set; } = null!;
        public virtual DbSet<TipoComprobante> TipoComprobantes { get; set; } = null!;
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; } = null!;
        public virtual DbSet<TipoPrecio> TipoPrecios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-6PI00Q4\\SQLEXPRESS;database=Inventarios;user id=javo;password=javo1009;persist security info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasKey(e => e.Idalmacen);

                entity.ToTable("almacen");

                entity.Property(e => e.Idalmacen).HasColumnName("idalmacen");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");
            });

            modelBuilder.Entity<Comprobante>(entity =>
            {
                entity.HasKey(e => e.Idcomprobante);

                entity.ToTable("comprobante");

                entity.Property(e => e.Idcomprobante)
                    .ValueGeneratedNever()
                    .HasColumnName("idcomprobante");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_emision");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.Idcondicionpago).HasColumnName("idcondicionpago");

                entity.Property(e => e.IdentidadEmisor).HasColumnName("identidad_emisor");

                entity.Property(e => e.IdentidadReceptor).HasColumnName("identidad_receptor");

                entity.Property(e => e.Idformapago).HasColumnName("idformapago");

                entity.Property(e => e.Idserie).HasColumnName("idserie");

                entity.Property(e => e.NumeroComprobante).HasColumnName("numero_comprobante");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Tipoaplicacion).HasColumnName("tipoaplicacion");

                entity.HasOne(d => d.IdcondicionpagoNavigation)
                    .WithMany(p => p.Comprobantes)
                    .HasForeignKey(d => d.Idcondicionpago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_comprobante_condicion_pago");

                entity.HasOne(d => d.IdformapagoNavigation)
                    .WithMany(p => p.Comprobantes)
                    .HasForeignKey(d => d.Idformapago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_comprobante_forma_pago");

                entity.HasOne(d => d.IdserieNavigation)
                    .WithMany(p => p.Comprobantes)
                    .HasForeignKey(d => d.Idserie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_comprobante_serie");
            });

            modelBuilder.Entity<CondicionPago>(entity =>
            {
                entity.HasKey(e => e.Idcondicionpago);

                entity.ToTable("condicion_pago");

                entity.Property(e => e.Idcondicionpago)
                    .ValueGeneratedNever()
                    .HasColumnName("idcondicionpago");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");
            });

            modelBuilder.Entity<DetalleComprobante>(entity =>
            {
                entity.HasKey(e => e.Iddetallecomprobante)
                    .HasName("PK_detalle_comprobante_1");

                entity.ToTable("detalle_comprobante");

                entity.Property(e => e.Iddetallecomprobante).HasColumnName("iddetallecomprobante");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Idalmacen).HasColumnName("idalmacen");

                entity.Property(e => e.Idcomprobante).HasColumnName("idcomprobante");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Igv)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("igv");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("peso");

                entity.Property(e => e.PrecioTotal)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("precio_total");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("precio_unitario");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("total");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("valor_total");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("valor_unitario");

                entity.HasOne(d => d.IdalmacenNavigation)
                    .WithMany(p => p.DetalleComprobantes)
                    .HasForeignKey(d => d.Idalmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_comprobante_almacen");

                entity.HasOne(d => d.IdcomprobanteNavigation)
                    .WithMany(p => p.DetalleComprobantes)
                    .HasForeignKey(d => d.Idcomprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_comprobante_comprobante");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.DetalleComprobantes)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_comprobante_producto");
            });

            modelBuilder.Entity<DetalleMovimiento>(entity =>
            {
                entity.HasKey(e => e.Iddetallemovimiento);

                entity.ToTable("detalle_movimiento");

                entity.Property(e => e.Iddetallemovimiento).HasColumnName("iddetallemovimiento");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Iddetallecomprobante).HasColumnName("iddetallecomprobante");

                entity.Property(e => e.Idmovimiento).HasColumnName("idmovimiento");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Idproductoalmacen).HasColumnName("idproductoalmacen");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("peso");

                entity.HasOne(d => d.IddetallecomprobanteNavigation)
                    .WithMany(p => p.DetalleMovimientos)
                    .HasForeignKey(d => d.Iddetallecomprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_movimiento_detalle_comprobante");

                entity.HasOne(d => d.IdmovimientoNavigation)
                    .WithMany(p => p.DetalleMovimientos)
                    .HasForeignKey(d => d.Idmovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_movimiento_movimiento");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.DetalleMovimientos)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_movimiento_producto");

                entity.HasOne(d => d.IdproductoalmacenNavigation)
                    .WithMany(p => p.DetalleMovimientos)
                    .HasForeignKey(d => d.Idproductoalmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_movimiento_producto_almacen");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.HasKey(e => e.Identidad);

                entity.ToTable("entidad");

                entity.Property(e => e.Identidad).HasColumnName("identidad");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido_materno");

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido_paterno");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Idtipodocumento).HasColumnName("idtipodocumento");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_documento");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("razon_social");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.IdtipodocumentoNavigation)
                    .WithMany(p => p.Entidads)
                    .HasForeignKey(d => d.Idtipodocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_entidad_tipo_documento");
            });

            modelBuilder.Entity<EntidadComprobante>(entity =>
            {
                entity.HasKey(e => e.Identidadcompronte);

                entity.ToTable("entidad_comprobante");

                entity.Property(e => e.Identidadcompronte).HasColumnName("identidadcompronte");

                entity.Property(e => e.Idcomprobante).HasColumnName("idcomprobante");

                entity.Property(e => e.Identidad).HasColumnName("identidad");

                entity.Property(e => e.Idtipoentidad).HasColumnName("idtipoentidad");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_documento");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("razon_social");

                entity.HasOne(d => d.IdcomprobanteNavigation)
                    .WithMany(p => p.EntidadComprobantes)
                    .HasForeignKey(d => d.Idcomprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_entidad_comprobante_comprobante");

                entity.HasOne(d => d.IdentidadNavigation)
                    .WithMany(p => p.EntidadComprobantes)
                    .HasForeignKey(d => d.Identidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_entidad_comprobante_entidad");
            });

            modelBuilder.Entity<FormaPago>(entity =>
            {
                entity.HasKey(e => e.Idformapago);

                entity.ToTable("forma_pago");

                entity.Property(e => e.Idformapago)
                    .ValueGeneratedNever()
                    .HasColumnName("idformapago");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");
            });

            modelBuilder.Entity<Movimiento>(entity =>
            {
                entity.HasKey(e => e.Idmovimiento);

                entity.ToTable("movimiento");

                entity.Property(e => e.Idmovimiento).HasColumnName("idmovimiento");

                entity.Property(e => e.FechaMovimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_movimiento");

                entity.Property(e => e.Idalmacendestino).HasColumnName("idalmacendestino");

                entity.Property(e => e.Idalmacenorigen).HasColumnName("idalmacenorigen");

                entity.Property(e => e.Idcomprobante).HasColumnName("idcomprobante");

                entity.Property(e => e.IdtipoMovimiento).HasColumnName("idtipo_movimiento");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.HasOne(d => d.IdalmacendestinoNavigation)
                    .WithMany(p => p.MovimientoIdalmacendestinoNavigations)
                    .HasForeignKey(d => d.Idalmacendestino)
                    .HasConstraintName("FK_movimiento_almacen1");

                entity.HasOne(d => d.IdalmacenorigenNavigation)
                    .WithMany(p => p.MovimientoIdalmacenorigenNavigations)
                    .HasForeignKey(d => d.Idalmacenorigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movimiento_almacen");

                entity.HasOne(d => d.IdcomprobanteNavigation)
                    .WithMany(p => p.Movimientos)
                    .HasForeignKey(d => d.Idcomprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movimiento_comprobante");

                entity.HasOne(d => d.IdtipoMovimientoNavigation)
                    .WithMany(p => p.Movimientos)
                    .HasForeignKey(d => d.IdtipoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movimiento_tipo_movimiento");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto);

                entity.ToTable("producto");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("precio");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("unidad");
            });

            modelBuilder.Entity<ProductoAlmacen>(entity =>
            {
                entity.HasKey(e => e.Idproductoalmacen);

                entity.ToTable("producto_almacen");

                entity.Property(e => e.Idproductoalmacen).HasColumnName("idproductoalmacen");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Idalmacen).HasColumnName("idalmacen");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("peso");

                entity.HasOne(d => d.IdalmacenNavigation)
                    .WithMany(p => p.ProductoAlmacens)
                    .HasForeignKey(d => d.Idalmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_almacen_almacen");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.ProductoAlmacens)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_almacen_producto");
            });

            modelBuilder.Entity<ProductoPrecio>(entity =>
            {
                entity.HasKey(e => e.Idproductoprecio);

                entity.ToTable("producto_precio");

                entity.Property(e => e.Idproductoprecio)
                    .ValueGeneratedNever()
                    .HasColumnName("idproductoprecio");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.IdtipoPrecio).HasColumnName("idtipo_precio");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.TipoDescuento).HasColumnName("tipo_descuento");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.ProductoPrecios)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_precio_producto");

                entity.HasOne(d => d.IdtipoPrecioNavigation)
                    .WithMany(p => p.ProductoPrecios)
                    .HasForeignKey(d => d.IdtipoPrecio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_precio_tipo_precio");
            });

            modelBuilder.Entity<Serie>(entity =>
            {
                entity.HasKey(e => e.Idserie);

                entity.ToTable("serie");

                entity.Property(e => e.Idserie).HasColumnName("idserie");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Identidad).HasColumnName("identidad");

                entity.Property(e => e.IdtipoComprobante).HasColumnName("idtipo_comprobante");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.HasOne(d => d.IdentidadNavigation)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.Identidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_serie_entidad");

                entity.HasOne(d => d.IdtipoComprobanteNavigation)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.IdtipoComprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_serie_tipo_comprobante");
            });

            modelBuilder.Entity<TipoComprobante>(entity =>
            {
                entity.HasKey(e => e.Idtipocomprobante);

                entity.ToTable("tipo_comprobante");

                entity.Property(e => e.Idtipocomprobante)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipocomprobante");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.Idtipodocumento);

                entity.ToTable("tipo_documento");

                entity.Property(e => e.Idtipodocumento)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipodocumento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");
            });

            modelBuilder.Entity<TipoMovimiento>(entity =>
            {
                entity.HasKey(e => e.Idtipomovimiento);

                entity.ToTable("tipo_movimiento");

                entity.Property(e => e.Idtipomovimiento)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipomovimiento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<TipoPrecio>(entity =>
            {
                entity.HasKey(e => e.Idtipoprecio);

                entity.ToTable("tipo_precio");

                entity.Property(e => e.Idtipoprecio)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipoprecio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.LogEstado).HasColumnName("log_estado");

                entity.Property(e => e.LogFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_creacion");

                entity.Property(e => e.LogFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("log_fecha_modificacion");

                entity.Property(e => e.LogUsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_creacion");

                entity.Property(e => e.LogUsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_usuario_modificacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
