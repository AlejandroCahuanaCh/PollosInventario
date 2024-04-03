using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class DetalleMovimiento
    {
        public int Iddetallemovimiento { get; set; }
        public int Idmovimiento { get; set; }
        public int Iddetallecomprobante { get; set; }
        public int Idproducto { get; set; }
        public int Idproductoalmacen { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Peso { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual DetalleComprobante IddetallecomprobanteNavigation { get; set; } = null!;
        public virtual Movimiento IdmovimientoNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual ProductoAlmacen IdproductoalmacenNavigation { get; set; } = null!;
    }
}
