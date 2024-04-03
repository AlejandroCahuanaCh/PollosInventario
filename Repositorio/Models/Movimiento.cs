using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class Movimiento
    {
        public Movimiento()
        {
            DetalleMovimientos = new HashSet<DetalleMovimiento>();
        }

        public int Idmovimiento { get; set; }
        public int Idcomprobante { get; set; }
        public int IdtipoMovimiento { get; set; }
        public int Idalmacenorigen { get; set; }
        public int? Idalmacendestino { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual Almacen? IdalmacendestinoNavigation { get; set; }
        public virtual Almacen IdalmacenorigenNavigation { get; set; } = null!;
        public virtual Comprobante IdcomprobanteNavigation { get; set; } = null!;
        public virtual TipoMovimiento IdtipoMovimientoNavigation { get; set; } = null!;
        public virtual ICollection<DetalleMovimiento> DetalleMovimientos { get; set; }
    }
}
