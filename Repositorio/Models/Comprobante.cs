using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class Comprobante
    {
        public Comprobante()
        {
            DetalleComprobantes = new HashSet<DetalleComprobante>();
            EntidadComprobantes = new HashSet<EntidadComprobante>();
            Movimientos = new HashSet<Movimiento>();
        }

        public int Idcomprobante { get; set; }
        public int Idserie { get; set; }
        public int NumeroComprobante { get; set; }
        public int IdentidadEmisor { get; set; }
        public int IdentidadReceptor { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Idcondicionpago { get; set; }
        public int Idformapago { get; set; }
        public short Tipoaplicacion { get; set; }
        public string? Observaciones { get; set; }

        public virtual CondicionPago IdcondicionpagoNavigation { get; set; } = null!;
        public virtual FormaPago IdformapagoNavigation { get; set; } = null!;
        public virtual Serie IdserieNavigation { get; set; } = null!;
        public virtual ICollection<DetalleComprobante> DetalleComprobantes { get; set; }
        public virtual ICollection<EntidadComprobante> EntidadComprobantes { get; set; }
        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}
