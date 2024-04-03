using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class DetalleComprobante
    {
        public DetalleComprobante()
        {
            DetalleMovimientos = new HashSet<DetalleMovimiento>();
        }

        public int Iddetallecomprobante { get; set; }
        public int Idcomprobante { get; set; }
        public int Idproducto { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Peso { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public int Idalmacen { get; set; }
        public decimal Igv { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual Comprobante IdcomprobanteNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual ICollection<DetalleMovimiento> DetalleMovimientos { get; set; }
    }
}
