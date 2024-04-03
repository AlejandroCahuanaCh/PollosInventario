using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleComprobantes = new HashSet<DetalleComprobante>();
            DetalleMovimientos = new HashSet<DetalleMovimiento>();
            ProductoAlmacens = new HashSet<ProductoAlmacen>();
            ProductoPrecios = new HashSet<ProductoPrecio>();
        }

        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public decimal Precio { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual ICollection<DetalleComprobante> DetalleComprobantes { get; set; }
        public virtual ICollection<DetalleMovimiento> DetalleMovimientos { get; set; }
        public virtual ICollection<ProductoAlmacen> ProductoAlmacens { get; set; }
        public virtual ICollection<ProductoPrecio> ProductoPrecios { get; set; }
    }
}
